using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;
using System.Windows.Forms;
using System.Reflection;
namespace WindowsFormsApp2
{
    public class s7plcVarItem
    {
        public string name { get; set; }
        public DataType dt { get; set; }
       
        public int db { get; set; }
        public int startByteAdr { get; set; }
       public VarType varType { get; set; }
        public int varCount { get; set; }
        public byte bitAdr { get; set; }
        public TreeNode Node { get; set; }
        public TreeView TreeView1 { get; set; }

        public DataGridView varGridView { get; set; }
        public DataGridViewRow[] rows;
        public s7Plc varPlc { get; set; }
        public s7plcVarItem(DataGridView varGridView1,s7Plc plc,string name1,DataType dataType, int db1, int startByteAdr1, VarType varType1, int varCount1, byte bitAdr1 = 0)
        {
            varGridView = varGridView1;
            varPlc = plc;
            name = name1; 
            dt = dataType;
            db = db1;
            startByteAdr = startByteAdr1;
            varType = varType1;
            varCount = varCount1;
            bitAdr = bitAdr1;
            //创建Node和子node，用于存储和保存变量；
            Node = new TreeNode();
            Node.Name = this.name;
            Node.Text = this.name;
            Node.Tag = this;
            var NodeAry = new TreeNode[varCount];
            for (var i=0;i<varCount;i++)
            {
                NodeAry[i] = new TreeNode();
                NodeAry[i].Name = $"{this.name}[{i.ToString()}]";
                NodeAry[i].Text = "unKnown";
                NodeAry[i].Tag = null;
            }
            Node.Nodes.AddRange(NodeAry);
            //创建DataGridVIew增加文本。
            rows = new DataGridViewRow[varCount];
            SetupRows(rows);
            //UpdateRows(rows);
            varGridView.Rows.AddRange(rows);
            








            

        }
        public void GetPLCValOneByOne(s7Plc plc)
        {
            var t1 = DateTime.Now;
            var result= plc.Read(dt, db, startByteAdr, varType, varCount, bitAdr);
            var t2 = t1 - DateTime.Now;
            MessageBox.Show(t2.TotalMilliseconds.ToString());

            
               // Node.Nodes[0].Text = result.ToString();
                if (varCount == 1)
                {
                    Node.Nodes[0].Tag = result;
                    //Node.Nodes[0].Text = result.ToString();

                 }
                else
                {


                    var count = 0;
                    foreach (var i in (Array)result)
                    {
                        Node.Nodes[count].Tag = i;
                        
                       //Node.Nodes[count].Text = GetString(i);
                        

                        

                        count++;
                    }
                }

            UpdateRows(rows);







        }
        public string GetString(object obj) 
        {
            switch (varType)
            {
                case VarType.Byte:
                    
                        return ((Byte)obj).ToString();
                  
                case VarType.Word:
                   
                        return ((ushort)obj).ToString();

                case VarType.Int:
                    return ((short)obj).ToString();
                case VarType.DWord:
                    return ((UInt32)obj).ToString();
                case VarType.DInt:
                    return ((Int32)obj).ToString();
                case VarType.Real:
                    return ((float)obj).ToString();
                case VarType.String:
                    return ((string)obj).ToString();
                case VarType.StringEx:
                    return ((string)obj).ToString();

                case VarType.Timer:
                    return ((double)obj).ToString();
                case VarType.Counter:
                    return ((ushort)obj).ToString();
                case VarType.Bit:
                    return ((bool)obj).ToString();
                default:
                    return null;
            }
        }
        public void SetupRows(DataGridViewRow[] rows)
        {
            for (var i = 0; i < rows.Count(); i++)
            {
                rows[i] = new DataGridViewRow();
                rows[i].CreateCells(varGridView);
                rows[i].Cells[0].Value = varCount == 1 ? Node.Name : Node.Nodes[i].Name;
                rows[i].Cells[1].Value = varPlc.name;
                rows[i].Cells[2].Value = varType.ToString();
                rows[i].Cells[3].Value = GetVarAddrStr(i);
                rows[i].Cells[4].Value = Node.Nodes[i].Text;
            }
        }

            public void UpdateRows(DataGridViewRow[] rows)
        {
            
                for (var i = 0; i < rows.Count(); i++)
                {
                    rows[i].Cells[4].Value = GetString(Node.Nodes[i].Tag);
                }
            


                
        }
        public string GetVarAddrStr(int count)
        {
            var dictDataType = new Dictionary<DataType, string>();
            dictDataType.Add(DataType.Input, "I");
            dictDataType.Add(DataType.Output, "Q");
            dictDataType.Add(DataType.DataBlock, "DB");
            dictDataType.Add(DataType.Memory, "M");
            var varTypeCount = VarTypeToByteLength(varType);
            var pre1 = dictDataType[dt];
            var pre2 = dt == DataType.DataBlock ? db.ToString() + ".DB" : "";
            var pre3 = "";
            if (varType == VarType.String | varType == VarType.StringEx | varType == VarType.Bit)
            {
                pre3 = dt == DataType.DataBlock ? "X" : "";
            }
            else
            {
                pre3 = "";
                switch (varTypeCount)
                {
                    case 1:
                        pre3 = "B";
                        break;
                    case 2:
                        pre3 = "W";
                        break;
                    case 4:
                        pre3 = "D";
                        break;

                }
            }
            var pre4 = "";
            if (varType == VarType.Bit)
            {
                pre4 = (startByteAdr + ((bitAdr + count ) / 8)).ToString();
            }
            else
            {
                pre4 = (startByteAdr + varTypeCount * (count )).ToString();
            }
            var pre5 = "";
            if(varType == VarType.Bit)
            pre5 = "." + ((bitAdr + count ) % 8).ToString();
            return pre1 + pre2 + pre3 + pre4 + pre5;
        }
        private int VarTypeToByteLength(VarType varType, int varCount = 1)
        {
            switch (varType)
            {
                case VarType.Bit:
                    return varCount; //TODO
                case VarType.Byte:
                    return (varCount < 1) ? 1 : varCount;
                case VarType.String:
                    return varCount;
                case VarType.StringEx:
                    return varCount + 2;
                case VarType.Word:
                case VarType.Timer:
                case VarType.Int:
                case VarType.Counter:
                    return varCount * 2;
                case VarType.DWord:
                case VarType.DInt:
                case VarType.Real:
                    return varCount * 4;
                default:
                    return 0;
            }
        }
    } 
}
