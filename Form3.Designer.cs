namespace WindowsFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.co_varType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_varBitAddr = new System.Windows.Forms.TextBox();
            this.tx_varLenth = new System.Windows.Forms.TextBox();
            this.tx_varAddr = new System.Windows.Forms.TextBox();
            this.tx_varName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_varAddCancel = new System.Windows.Forms.Button();
            this.bt_varAddCheck = new System.Windows.Forms.Button();
            this.co_plcAreaType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DBNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // co_varType
            // 
            this.co_varType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.co_varType.FormattingEnabled = true;
            this.co_varType.Items.AddRange(new object[] {
            "S71200",
            "S71500",
            "S7200",
            "S7300",
            "S7400"});
            this.co_varType.Location = new System.Drawing.Point(105, 55);
            this.co_varType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.co_varType.Name = "co_varType";
            this.co_varType.Size = new System.Drawing.Size(133, 23);
            this.co_varType.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "变量类型";
            // 
            // tx_varBitAddr
            // 
            this.tx_varBitAddr.Location = new System.Drawing.Point(105, 197);
            this.tx_varBitAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_varBitAddr.Name = "tx_varBitAddr";
            this.tx_varBitAddr.Size = new System.Drawing.Size(133, 25);
            this.tx_varBitAddr.TabIndex = 24;
            // 
            // tx_varLenth
            // 
            this.tx_varLenth.Location = new System.Drawing.Point(105, 169);
            this.tx_varLenth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_varLenth.Name = "tx_varLenth";
            this.tx_varLenth.Size = new System.Drawing.Size(133, 25);
            this.tx_varLenth.TabIndex = 23;
            // 
            // tx_varAddr
            // 
            this.tx_varAddr.Location = new System.Drawing.Point(105, 142);
            this.tx_varAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_varAddr.Name = "tx_varAddr";
            this.tx_varAddr.Size = new System.Drawing.Size(133, 25);
            this.tx_varAddr.TabIndex = 22;
            // 
            // tx_varName
            // 
            this.tx_varName.Location = new System.Drawing.Point(105, 27);
            this.tx_varName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_varName.Name = "tx_varName";
            this.tx_varName.Size = new System.Drawing.Size(133, 25);
            this.tx_varName.TabIndex = 21;
            this.tx_varName.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "变量位址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "变量长度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "变量地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "变量名称";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tx_varAddCancel
            // 
            this.tx_varAddCancel.Location = new System.Drawing.Point(151, 225);
            this.tx_varAddCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_varAddCancel.Name = "tx_varAddCancel";
            this.tx_varAddCancel.Size = new System.Drawing.Size(87, 29);
            this.tx_varAddCancel.TabIndex = 16;
            this.tx_varAddCancel.Text = "取消";
            this.tx_varAddCancel.UseVisualStyleBackColor = true;
            // 
            // bt_varAddCheck
            // 
            this.bt_varAddCheck.Location = new System.Drawing.Point(40, 225);
            this.bt_varAddCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_varAddCheck.Name = "bt_varAddCheck";
            this.bt_varAddCheck.Size = new System.Drawing.Size(87, 29);
            this.bt_varAddCheck.TabIndex = 15;
            this.bt_varAddCheck.Text = "确定";
            this.bt_varAddCheck.UseVisualStyleBackColor = true;
            this.bt_varAddCheck.Click += new System.EventHandler(this.Bt_varAddCheck_Click);
            // 
            // co_plcAreaType
            // 
            this.co_plcAreaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.co_plcAreaType.FormattingEnabled = true;
            this.co_plcAreaType.Items.AddRange(new object[] {
            "S71200",
            "S71500",
            "S7200",
            "S7300",
            "S7400"});
            this.co_plcAreaType.Location = new System.Drawing.Point(105, 83);
            this.co_plcAreaType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.co_plcAreaType.Name = "co_plcAreaType";
            this.co_plcAreaType.Size = new System.Drawing.Size(133, 23);
            this.co_plcAreaType.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "变量区域";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "DB块";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // DBNumber
            // 
            this.DBNumber.Location = new System.Drawing.Point(105, 113);
            this.DBNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBNumber.Name = "DBNumber";
            this.DBNumber.Size = new System.Drawing.Size(133, 25);
            this.DBNumber.TabIndex = 32;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 289);
            this.Controls.Add(this.DBNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.co_plcAreaType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.co_varType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_varBitAddr);
            this.Controls.Add(this.tx_varLenth);
            this.Controls.Add(this.tx_varAddr);
            this.Controls.Add(this.tx_varName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_varAddCancel);
            this.Controls.Add(this.bt_varAddCheck);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox co_varType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_varBitAddr;
        private System.Windows.Forms.TextBox tx_varLenth;
        private System.Windows.Forms.TextBox tx_varAddr;
        private System.Windows.Forms.TextBox tx_varName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tx_varAddCancel;
        private System.Windows.Forms.Button bt_varAddCheck;
        private System.Windows.Forms.ComboBox co_plcAreaType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DBNumber;
    }
}