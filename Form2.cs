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
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PlcAddCheck_Click(object sender, EventArgs e)
        {
            int tmp1,tmp2;
            if ((!int.TryParse(plcRack.Text, out tmp1 )) | (!int.TryParse(plcRack.Text, out tmp2)))
            {
                MessageBox.Show("请正确输入数字");
                return;
            }
            MessageBox.Show(S7PLCType.Text);
            CpuType cputype = (CpuType)Enum.Parse(typeof(CpuType), S7PLCType.Text);
            
            s7Plc newplc = new s7Plc(plcName.Text, cputype, plcAddr.Text, (short)tmp1, (short)tmp2);
            this.ParentForm1.Pmg.add(newplc);
            this.DialogResult = DialogResult.OK;

        }
        
        private void PlcAddCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
