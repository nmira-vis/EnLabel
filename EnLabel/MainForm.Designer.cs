namespace EnLabel
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.folderBtn = new System.Windows.Forms.Button();
            this.fileLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateDSbtn = new System.Windows.Forms.Button();
            this.imgLblLstView = new System.Windows.Forms.ListView();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageNameHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelHead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVisor
            // 
            this.pnlVisor.BackColor = System.Drawing.Color.Black;
            this.pnlVisor.Location = new System.Drawing.Point(12, 12);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(536, 402);
            this.pnlVisor.TabIndex = 0;
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.prevBtn.Enabled = false;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prevBtn.Location = new System.Drawing.Point(459, 3);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(34, 30);
            this.prevBtn.TabIndex = 1;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.nextBtn.Enabled = false;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextBtn.Location = new System.Drawing.Point(499, 3);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(34, 30);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // folderBtn
            // 
            this.folderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.folderBtn.FlatAppearance.BorderSize = 0;
            this.folderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.folderBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.folderBtn.Location = new System.Drawing.Point(571, 43);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(148, 39);
            this.folderBtn.TabIndex = 3;
            this.folderBtn.Text = "Select folder";
            this.folderBtn.UseVisualStyleBackColor = false;
            this.folderBtn.Click += new System.EventHandler(this.FolderBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileLbl.Location = new System.Drawing.Point(195, 3);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(71, 18);
            this.fileLbl.TabIndex = 4;
            this.fileLbl.Text = "File Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Label";
            // 
            // labelBtn
            // 
            this.labelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.labelBtn.Enabled = false;
            this.labelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBtn.Location = new System.Drawing.Point(198, 37);
            this.labelBtn.Name = "labelBtn";
            this.labelBtn.Size = new System.Drawing.Size(93, 30);
            this.labelBtn.TabIndex = 7;
            this.labelBtn.Text = "Label";
            this.labelBtn.UseVisualStyleBackColor = false;
            this.labelBtn.Click += new System.EventHandler(this.LabelBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Enabled = false;
            this.removeBtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.removeBtn.Location = new System.Drawing.Point(297, 37);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(93, 30);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFolder.Location = new System.Drawing.Point(725, 43);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(208, 26);
            this.lblFolder.TabIndex = 9;
            this.lblFolder.Text = "No folder delected";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCount.Location = new System.Drawing.Point(725, 69);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(27, 17);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "0/0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCmbBox);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.prevBtn);
            this.panel1.Controls.Add(this.labelBtn);
            this.panel1.Controls.Add(this.fileLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Location = new System.Drawing.Point(13, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 70);
            this.panel1.TabIndex = 12;
            // 
            // labelCmbBox
            // 
            this.labelCmbBox.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCmbBox.FormattingEnabled = true;
            this.labelCmbBox.Location = new System.Drawing.Point(7, 37);
            this.labelCmbBox.Name = "labelCmbBox";
            this.labelCmbBox.Size = new System.Drawing.Size(185, 27);
            this.labelCmbBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(571, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Images";
            // 
            // generateDSbtn
            // 
            this.generateDSbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
            this.generateDSbtn.Enabled = false;
            this.generateDSbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateDSbtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.generateDSbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generateDSbtn.Location = new System.Drawing.Point(571, 458);
            this.generateDSbtn.Name = "generateDSbtn";
            this.generateDSbtn.Size = new System.Drawing.Size(320, 30);
            this.generateDSbtn.TabIndex = 9;
            this.generateDSbtn.Text = "Generate Dataset";
            this.generateDSbtn.UseVisualStyleBackColor = false;
            this.generateDSbtn.Click += new System.EventHandler(this.GenerateDSbtn_Click);
            // 
            // imgLblLstView
            // 
            this.imgLblLstView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.imgLblLstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.imageNameHead,
            this.labelHead});
            this.imgLblLstView.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.imgLblLstView.FullRowSelect = true;
            this.imgLblLstView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.imgLblLstView.HideSelection = false;
            this.imgLblLstView.Location = new System.Drawing.Point(571, 89);
            this.imgLblLstView.MultiSelect = false;
            this.imgLblLstView.Name = "imgLblLstView";
            this.imgLblLstView.ShowItemToolTips = true;
            this.imgLblLstView.Size = new System.Drawing.Size(320, 352);
            this.imgLblLstView.TabIndex = 14;
            this.imgLblLstView.UseCompatibleStateImageBehavior = false;
            this.imgLblLstView.View = System.Windows.Forms.View.Details;
            this.imgLblLstView.SelectedIndexChanged += new System.EventHandler(this.ImgLblLstView_SelectedIndexChanged);
            // 
            // indexHeader
            // 
            this.indexHeader.Text = "Index";
            this.indexHeader.Width = 54;
            // 
            // imageNameHead
            // 
            this.imageNameHead.Text = "Image";
            this.imageNameHead.Width = 194;
            // 
            // labelHead
            // 
            this.labelHead.Text = "Label";
            this.labelHead.Width = 63;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 604);
            this.Controls.Add(this.imgLblLstView);
            this.Controls.Add(this.generateDSbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.folderBtn);
            this.Controls.Add(this.pnlVisor);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EnLabel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button folderBtn;
        public System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labelBtn;
        private System.Windows.Forms.Button removeBtn;
        public System.Windows.Forms.Label fileLbl;
        public System.Windows.Forms.Label lblFolder;
        public System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox labelCmbBox;
        private System.Windows.Forms.ColumnHeader imageNameHead;
        private System.Windows.Forms.ColumnHeader labelHead;
        public System.Windows.Forms.ListView imgLblLstView;
        public System.Windows.Forms.Button generateDSbtn;
        private System.Windows.Forms.ColumnHeader indexHeader;
    }
}

