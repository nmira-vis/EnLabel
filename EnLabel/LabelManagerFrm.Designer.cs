namespace EnLabel
{
    partial class LabelManagerFrm
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
            this.defaultRadBtn = new System.Windows.Forms.RadioButton();
            this.customRadBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1TxtBox = new System.Windows.Forms.TextBox();
            this.lbl2TxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.binBtn = new System.Windows.Forms.Button();
            this.addLabelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okLbl = new System.Windows.Forms.Label();
            this.NotOkLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defaultRadBtn
            // 
            this.defaultRadBtn.AutoSize = true;
            this.defaultRadBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.defaultRadBtn.Location = new System.Drawing.Point(12, 46);
            this.defaultRadBtn.Name = "defaultRadBtn";
            this.defaultRadBtn.Size = new System.Drawing.Size(156, 23);
            this.defaultRadBtn.TabIndex = 2;
            this.defaultRadBtn.TabStop = true;
            this.defaultRadBtn.Text = "Default (OK/NotOK)";
            this.defaultRadBtn.UseVisualStyleBackColor = true;
            this.defaultRadBtn.CheckedChanged += new System.EventHandler(this.DefaultRadBtn_CheckedChanged);
            // 
            // customRadBtn
            // 
            this.customRadBtn.AutoSize = true;
            this.customRadBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.customRadBtn.Location = new System.Drawing.Point(174, 46);
            this.customRadBtn.Name = "customRadBtn";
            this.customRadBtn.Size = new System.Drawing.Size(109, 23);
            this.customRadBtn.TabIndex = 3;
            this.customRadBtn.TabStop = true;
            this.customRadBtn.Text = "Personalized";
            this.customRadBtn.UseVisualStyleBackColor = true;
            this.customRadBtn.CheckedChanged += new System.EventHandler(this.CustomRadBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Label 1:";
            // 
            // lbl1TxtBox
            // 
            this.lbl1TxtBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl1TxtBox.Location = new System.Drawing.Point(79, 107);
            this.lbl1TxtBox.Name = "lbl1TxtBox";
            this.lbl1TxtBox.Size = new System.Drawing.Size(260, 27);
            this.lbl1TxtBox.TabIndex = 5;
            this.lbl1TxtBox.Visible = false;
            // 
            // lbl2TxtBox
            // 
            this.lbl2TxtBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl2TxtBox.Location = new System.Drawing.Point(79, 150);
            this.lbl2TxtBox.Name = "lbl2TxtBox";
            this.lbl2TxtBox.Size = new System.Drawing.Size(260, 27);
            this.lbl2TxtBox.TabIndex = 7;
            this.lbl2TxtBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Label 2:";
            // 
            // binBtn
            // 
            this.binBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.binBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binBtn.Location = new System.Drawing.Point(345, 152);
            this.binBtn.Name = "binBtn";
            this.binBtn.Size = new System.Drawing.Size(20, 22);
            this.binBtn.TabIndex = 8;
            this.binBtn.UseVisualStyleBackColor = false;
            this.binBtn.Visible = false;
            // 
            // addLabelBtn
            // 
            this.addLabelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addLabelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLabelBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addLabelBtn.ForeColor = System.Drawing.Color.White;
            this.addLabelBtn.Location = new System.Drawing.Point(79, 192);
            this.addLabelBtn.Name = "addLabelBtn";
            this.addLabelBtn.Size = new System.Drawing.Size(98, 30);
            this.addLabelBtn.TabIndex = 9;
            this.addLabelBtn.Text = "+ add label";
            this.addLabelBtn.UseVisualStyleBackColor = false;
            this.addLabelBtn.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(173, 337);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(93, 30);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(272, 337);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 30);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // okLbl
            // 
            this.okLbl.AutoSize = true;
            this.okLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.okLbl.Location = new System.Drawing.Point(79, 111);
            this.okLbl.Name = "okLbl";
            this.okLbl.Size = new System.Drawing.Size(28, 19);
            this.okLbl.TabIndex = 13;
            this.okLbl.Text = "OK";
            // 
            // NotOkLbl
            // 
            this.NotOkLbl.AutoSize = true;
            this.NotOkLbl.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotOkLbl.Location = new System.Drawing.Point(79, 154);
            this.NotOkLbl.Name = "NotOkLbl";
            this.NotOkLbl.Size = new System.Drawing.Size(55, 19);
            this.NotOkLbl.TabIndex = 14;
            this.NotOkLbl.Text = "Not OK";
            // 
            // LabelManagerFrm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(375, 379);
            this.Controls.Add(this.NotOkLbl);
            this.Controls.Add(this.okLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.addLabelBtn);
            this.Controls.Add(this.binBtn);
            this.Controls.Add(this.lbl2TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1TxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customRadBtn);
            this.Controls.Add(this.defaultRadBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LabelManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labels";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabelManagerFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button binBtn;
        private System.Windows.Forms.Button addLabelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.TextBox lbl1TxtBox;
        public System.Windows.Forms.TextBox lbl2TxtBox;
        public System.Windows.Forms.Label okLbl;
        public System.Windows.Forms.Label NotOkLbl;
        public System.Windows.Forms.RadioButton defaultRadBtn;
        public System.Windows.Forms.RadioButton customRadBtn;
    }
}