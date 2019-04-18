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
        private PlcManager pmg;
        public Form1()
        {
            InitializeComponent();
           
        }
        public PlcManager Pmg => pmg;
        private void Form1_Load(object sender, EventArgs e)
        {
             pmg = new PlcManager();
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
                treeView1.Nodes.Remove(CurSelectedNode);
                contextMenuStrip1.Items[CurSelectedNode.Name].Enabled = true;

            }
            else
            {
                Form2 AddPlcFormDlg = new Form2();
                AddPlcFormDlg.ParentForm1 = this;
                if (AddPlcFormDlg.ShowDialog() == DialogResult.OK)
                {
                    CurSelectedNode.Nodes.Clear();
                    var nodes = from plc in this.pmg.List
                                select new TreeNode { Name = ((s7Plc)plc).name, Text = ((s7Plc)plc).name,ContextMenuStrip =contextMenuStrip3};
                    CurSelectedNode.Nodes.AddRange(nodes.ToArray());
                    treeView1.ExpandAll();
                }
                else
                {
                    MessageBox.Show("Cancel");
                }
                AddPlcFormDlg.Close();



            }
        }

        private void TreeView1_MouseClick(object sender, MouseEventArgs e)
        {
            TreeNode curNode=this.treeView1.GetNodeAt(e.Location);
            if (curNode is null) return;
            treeView1.SelectedNode = curNode;
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}

