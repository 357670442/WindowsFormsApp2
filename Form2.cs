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
    public partial class Form2 : Form
    {
        public Form1 ParentForm1 { get; set; }
        public Form2()
        {
            InitializeComponent();
            this.S7PLCType.Items.Clear();
            this.S7PLCType.Items.AddRange(Enum.GetNames(typeof(CpuType)));
            this.S7PLCType.SelectedItem = CpuType.S71200.ToString();
        }

       

        private void PlcAddCheck_Click(object sender, EventArgs e)
        {
            int tmp1,tmp2;
            if ((!int.TryParse(plcRack.Text, out tmp1 )) | (!int.TryParse(plcRack.Text, out tmp2)))
            {
                MessageBox.Show("请正确输入数字");
                return;
            }
            if (checkParaOk())
            {
                MessageBox.Show("plc名称重复！");
                return;
            }

            CpuType cputype = (CpuType)Enum.Parse(typeof(CpuType), S7PLCType.Text);
            
            s7Plc newplc = new s7Plc(plcName.Text, cputype, plcAddr.Text, (short)tmp1, (short)tmp2);
            newplc.Node.ContextMenuStrip = ParentForm1.plcContextStrip;
            this.ParentForm1.Pmg.add(newplc);
            this.DialogResult = DialogResult.OK;

        }
        
        private void PlcAddCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void S7PLCType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool checkParaOk()
        {
            if (ParentForm1.Pmg.FindPLCByName(plcName.Text) == null) return false;
            return true;
        }
    }
}
