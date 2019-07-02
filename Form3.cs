using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form1 form1;
        public Form3(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            this.co_varType.Items.Clear();
            this.co_varType.Items.AddRange(Enum.GetNames(typeof(VarType)));
            this.co_plcAreaType.Items.Clear();
            this.co_plcAreaType.Items.AddRange(Enum.GetNames(typeof(DataType)));
        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Bt_varAddCheck_Click(object sender, EventArgs e)
        {
            TreeNode CurSelectedNode = form1.treeView1.SelectedNode;
            var CurPlc = form1.Pmg.FindPLCByName(CurSelectedNode.Name);
            var varName = tx_varName.Text;
            var datatype = (DataType)Enum.Parse(typeof(DataType), co_plcAreaType.Text);
            var db = int.Parse(DBNumber.Text);
            var startAddr = int.Parse(tx_varAddr.Text);
            var varType = (VarType)Enum.Parse(typeof(VarType), co_varType.Text);
            var count = int.Parse(tx_varLenth.Text);
            var bitNumber = (Byte)int.Parse(tx_varBitAddr.Text);
            var s7PlcValItem = new s7plcVarItem(form1.VarGridView,CurPlc,varName ,datatype,db,startAddr,varType,count,bitNumber);
            s7PlcValItem.Node.ContextMenuStrip = form1.varContextStrip;
            s7PlcValItem.TreeView1 = form1.treeView1;
            CurPlc.Add(s7PlcValItem);
            this.DialogResult = DialogResult.OK;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
    }
}
