using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private PlcManager pmg=new PlcManager();
       
        public ContextMenuStrip plcContextStrip => contextMenuStrip3;
        public ContextMenuStrip varContextStrip => contextMenuStrip4;
        public PlcManager Pmg => pmg;
        
        public DataGridView VarGridView=>varGridView1;
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void S7协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
       

        private void ContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode();
            treeNode1.Name = e.ClickedItem.Name;
            treeNode1.Text = treeNode1.Name;
            treeNode1.ContextMenuStrip = contextMenuStrip2;
            this.treeView1.TopNode.Nodes.Add(treeNode1);
            e.ClickedItem.Enabled = false;
        }

        private void ContextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TreeNode CurSelectedNode = treeView1.SelectedNode;
            ToolStripItem Item1 = e.ClickedItem;
            if (Item1.Equals(this.contextMenuStrip2.Items[0]))
            {
                if (CurSelectedNode.Nodes.Count==0)
                {
                    treeView1.Nodes.Remove(CurSelectedNode);
                    contextMenuStrip1.Items[CurSelectedNode.Name].Enabled = true;
                }
                else
                {
                    MessageBox.Show("CurTreeNode is not Empty!");
                }
                return;
            }
            else
            {
                Form2 AddPlcFormDlg = new Form2();
                AddPlcFormDlg.ParentForm1 = this;
                if (AddPlcFormDlg.ShowDialog() == DialogResult.OK)
                {
                    CurSelectedNode.Nodes.Clear();
                    var nodes = from plc in this.pmg.List
                                select plc.Node;
                    CurSelectedNode.Nodes.AddRange(nodes.ToArray());
                    treeView1.ExpandAll();
                }
                else
                {
                    MessageBox.Show("Cancel");
                }
                AddPlcFormDlg.Close();

                return;

            }
        }

        private void TreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode curNode=this.treeView1.GetNodeAt(e.Location);
            if (curNode is null) return;
            treeView1.SelectedNode = curNode;
        }

        private void addPlcVar(object sender, EventArgs e)
        {
           
        }

        private void ContextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TreeNode CurSelectedNode = treeView1.SelectedNode;
            ToolStripItem Item1 = e.ClickedItem;
            var plc = pmg.FindPLCByName(CurSelectedNode.Name);
            

            if (Item1.Equals(this.contextMenuStrip3.Items[3]))
            {
             
          
                Form3 AddvarDlg = new Form3(this);
   
                if (AddvarDlg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("新增PLC变量成功");
                }
                else
                {
                    MessageBox.Show("取消增加PLC变量");
                }
                AddvarDlg.Close();



            }
            if (Item1.Equals(this.contextMenuStrip3.Items[1]))
            {
                try
                {
                    plc.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                    //throw;
                    
                }
                if(plc.IsConnected)
                {
                    plc.CycleTimer.Enabled = true;
                    plc.Node.BackColor = Color.Blue;



                }
                else
                {
                    MessageBox.Show(string.Format($"{0} is not connected yet", plc.name));
                }


                return;
            }
            if (Item1.Equals(this.contextMenuStrip3.Items[2]))
            {
                if (plc.IsConnected)
                {
                   
                    plc.CycleTimer.Enabled = false;
                    plc.Close();
                    plc.Node.BackColor = Color.Black;
                    MessageBox.Show("PLC has been closed!");


                }
                else
                {
                    MessageBox.Show(string.Format($"{0} is not connected yet", plc.name));
                }




            }
            if (Item1.Equals(this.contextMenuStrip3.Items[0]))
            {
       
                if(plc.IsConnected)
                {
                    MessageBox.Show("请断开当前PLC！");
                    return;
                }
                else
                {
                    CurSelectedNode.Nodes.Remove(plc.Node);
                    Pmg.del(plc);
                    MessageBox.Show(string.Format($"PLC{0}已被删除",plc.name));
                    plc = null;
                    return;
                }



            }

        }

        private void 开始连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void ContextMenuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            TreeNode CurSelectedNode = treeView1.SelectedNode;
            TreeNode ParentNode = CurSelectedNode.Parent;
            ToolStripItem Item1 = e.ClickedItem;
            var plc = pmg.FindPLCByName(ParentNode.Name);
            if (Item1.Equals(this.contextMenuStrip3.Items[0]))
            {

                plc.varlist.Remove(plc.FindvarItemByName(CurSelectedNode.Text));
                CurSelectedNode.Remove();


            }


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

