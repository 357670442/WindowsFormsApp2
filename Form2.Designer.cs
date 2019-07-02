namespace WindowsFormsApp2
{
    partial class Form2
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
            this.plcAddCheck = new System.Windows.Forms.Button();
            this.plcAddCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plcName = new System.Windows.Forms.TextBox();
            this.plcAddr = new System.Windows.Forms.TextBox();
            this.plcRack = new System.Windows.Forms.TextBox();
            this.plcSlot = new System.Windows.Forms.TextBox();
            this.pingPlcAddr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.S7PLCType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // plcAddCheck
            // 
            this.plcAddCheck.Location = new System.Drawing.Point(21, 241);
            this.plcAddCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcAddCheck.Name = "plcAddCheck";
            this.plcAddCheck.Size = new System.Drawing.Size(87, 29);
            this.plcAddCheck.TabIndex = 0;
            this.plcAddCheck.Text = "确定";
            this.plcAddCheck.UseVisualStyleBackColor = true;
            this.plcAddCheck.Click += new System.EventHandler(this.PlcAddCheck_Click);
            // 
            // plcAddCancel
            // 
            this.plcAddCancel.Location = new System.Drawing.Point(132, 241);
            this.plcAddCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcAddCancel.Name = "plcAddCancel";
            this.plcAddCancel.Size = new System.Drawing.Size(87, 29);
            this.plcAddCancel.TabIndex = 1;
            this.plcAddCancel.Text = "取消";
            this.plcAddCancel.UseVisualStyleBackColor = true;
            this.plcAddCancel.Click += new System.EventHandler(this.PlcAddCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLC名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLC地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLC机架";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "PLC插槽";
            // 
            // plcName
            // 
            this.plcName.Location = new System.Drawing.Point(87, 38);
            this.plcName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcName.Name = "plcName";
            this.plcName.Size = new System.Drawing.Size(133, 25);
            this.plcName.TabIndex = 6;
            this.plcName.Tag = "";
            this.plcName.Text = "PLC1";
            // 
            // plcAddr
            // 
            this.plcAddr.Location = new System.Drawing.Point(87, 93);
            this.plcAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcAddr.Name = "plcAddr";
            this.plcAddr.Size = new System.Drawing.Size(133, 25);
            this.plcAddr.TabIndex = 7;
            this.plcAddr.Text = "192.168.0.1";
            // 
            // plcRack
            // 
            this.plcRack.Location = new System.Drawing.Point(87, 121);
            this.plcRack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcRack.Name = "plcRack";
            this.plcRack.Size = new System.Drawing.Size(133, 25);
            this.plcRack.TabIndex = 8;
            this.plcRack.Text = "0";
            // 
            // plcSlot
            // 
            this.plcSlot.Location = new System.Drawing.Point(87, 148);
            this.plcSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plcSlot.Name = "plcSlot";
            this.plcSlot.Size = new System.Drawing.Size(133, 25);
            this.plcSlot.TabIndex = 9;
            this.plcSlot.Text = "1";
            // 
            // pingPlcAddr
            // 
            this.pingPlcAddr.Location = new System.Drawing.Point(21, 186);
            this.pingPlcAddr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pingPlcAddr.Name = "pingPlcAddr";
            this.pingPlcAddr.Size = new System.Drawing.Size(87, 29);
            this.pingPlcAddr.TabIndex = 10;
            this.pingPlcAddr.Text = "ping";
            this.pingPlcAddr.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Plc类型";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "连接测试";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // S7PLCType
            // 
            this.S7PLCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.S7PLCType.FormattingEnabled = true;
            this.S7PLCType.Location = new System.Drawing.Point(87, 67);
            this.S7PLCType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S7PLCType.Name = "S7PLCType";
            this.S7PLCType.Size = new System.Drawing.Size(133, 23);
            this.S7PLCType.TabIndex = 14;
            this.S7PLCType.SelectedIndexChanged += new System.EventHandler(this.S7PLCType_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 280);
            this.Controls.Add(this.S7PLCType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pingPlcAddr);
            this.Controls.Add(this.plcSlot);
            this.Controls.Add(this.plcRack);
            this.Controls.Add(this.plcAddr);
            this.Controls.Add(this.plcName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plcAddCancel);
            this.Controls.Add(this.plcAddCheck);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plcAddCheck;
        private System.Windows.Forms.Button plcAddCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plcName;
        private System.Windows.Forms.TextBox plcAddr;
        private System.Windows.Forms.TextBox plcRack;
        private System.Windows.Forms.TextBox plcSlot;
        private System.Windows.Forms.Button pingPlcAddr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox S7PLCType;
    }
}