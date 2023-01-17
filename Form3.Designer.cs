namespace SuperStoreSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.namemnu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cstmnu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox7 = new System.Windows.Forms.TextBox();
            this.grpbox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnproceed = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtbox8 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnrfresh = new System.Windows.Forms.Button();
            this.txtbox6 = new System.Windows.Forms.TextBox();
            this.Btn_add = new System.Windows.Forms.Button();
            this.xgrid3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgrid3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchmnu,
            this.insertmnu,
            this.cstmnu,
            this.exitToolStripMenuItem1});
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(50, 20);
            this.mnu.Text = "Menu";
            // 
            // searchmnu
            // 
            this.searchmnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namemnu});
            this.searchmnu.Name = "searchmnu";
            this.searchmnu.Size = new System.Drawing.Size(158, 22);
            this.searchmnu.Text = "Search Data";
            // 
            // namemnu
            // 
            this.namemnu.Name = "namemnu";
            this.namemnu.Size = new System.Drawing.Size(125, 22);
            this.namemnu.Text = "By Name ";
            this.namemnu.Click += new System.EventHandler(this.namemnu_Click);
            // 
            // insertmnu
            // 
            this.insertmnu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem});
            this.insertmnu.Name = "insertmnu";
            this.insertmnu.Size = new System.Drawing.Size(158, 22);
            this.insertmnu.Text = "Insert Data";
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.addItemToolStripMenuItem_Click);
            // 
            // cstmnu
            // 
            this.cstmnu.Name = "cstmnu";
            this.cstmnu.Size = new System.Drawing.Size(158, 22);
            this.cstmnu.Text = "Customers Data";
            this.cstmnu.Click += new System.EventHandler(this.cstmnu_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Location = new System.Drawing.Point(22, 91);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(174, 21);
            this.cmbbox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(36, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 309);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox7
            // 
            this.txtbox7.Location = new System.Drawing.Point(318, 62);
            this.txtbox7.Name = "txtbox7";
            this.txtbox7.ReadOnly = true;
            this.txtbox7.Size = new System.Drawing.Size(59, 20);
            this.txtbox7.TabIndex = 5;
            // 
            // grpbox2
            // 
            this.grpbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpbox2.BackgroundImage")));
            this.grpbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpbox2.Controls.Add(this.label5);
            this.grpbox2.Controls.Add(this.label4);
            this.grpbox2.Controls.Add(this.btnproceed);
            this.grpbox2.Controls.Add(this.btnclear);
            this.grpbox2.Controls.Add(this.txtbox8);
            this.grpbox2.Controls.Add(this.lbl3);
            this.grpbox2.Controls.Add(this.btnrfresh);
            this.grpbox2.Controls.Add(this.txtbox6);
            this.grpbox2.Controls.Add(this.Btn_add);
            this.grpbox2.Controls.Add(this.xgrid3);
            this.grpbox2.Controls.Add(this.label2);
            this.grpbox2.Controls.Add(this.label1);
            this.grpbox2.Controls.Add(this.txtbox7);
            this.grpbox2.Controls.Add(this.cmbbox1);
            this.grpbox2.Location = new System.Drawing.Point(623, 27);
            this.grpbox2.Name = "grpbox2";
            this.grpbox2.Size = new System.Drawing.Size(518, 490);
            this.grpbox2.TabIndex = 6;
            this.grpbox2.TabStop = false;
            this.grpbox2.Text = "Ajwa SuperStore";
           
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Item Quantity:";
            // 
            // btnproceed
            // 
            this.btnproceed.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnproceed.Location = new System.Drawing.Point(408, 148);
            this.btnproceed.Name = "btnproceed";
            this.btnproceed.Size = new System.Drawing.Size(75, 23);
            this.btnproceed.TabIndex = 15;
            this.btnproceed.Text = "Proceed";
            this.btnproceed.UseVisualStyleBackColor = false;
            this.btnproceed.Click += new System.EventHandler(this.btnproceed_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnclear.Location = new System.Drawing.Point(318, 148);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtbox8
            // 
            this.txtbox8.Location = new System.Drawing.Point(318, 103);
            this.txtbox8.Name = "txtbox8";
            this.txtbox8.ReadOnly = true;
            this.txtbox8.Size = new System.Drawing.Size(89, 20);
            this.txtbox8.TabIndex = 13;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(249, 107);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 16);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Total:-";
            // 
            // btnrfresh
            // 
            this.btnrfresh.BackColor = System.Drawing.Color.Linen;
            this.btnrfresh.Location = new System.Drawing.Point(22, 32);
            this.btnrfresh.Name = "btnrfresh";
            this.btnrfresh.Size = new System.Drawing.Size(75, 23);
            this.btnrfresh.TabIndex = 11;
            this.btnrfresh.Text = "Refresh";
            this.btnrfresh.UseVisualStyleBackColor = false;
            this.btnrfresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbox6
            // 
            this.txtbox6.Location = new System.Drawing.Point(318, 19);
            this.txtbox6.Multiline = true;
            this.txtbox6.Name = "txtbox6";
            this.txtbox6.ReadOnly = true;
            this.txtbox6.Size = new System.Drawing.Size(118, 21);
            this.txtbox6.TabIndex = 10;
            // 
            // Btn_add
            // 
            this.Btn_add.BackColor = System.Drawing.Color.Linen;
            this.Btn_add.Location = new System.Drawing.Point(59, 129);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(75, 23);
            this.Btn_add.TabIndex = 9;
            this.Btn_add.Text = "Add";
            this.Btn_add.UseVisualStyleBackColor = false;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // xgrid3
            // 
            this.xgrid3.AllowUserToAddRows = false;
            this.xgrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xgrid3.Location = new System.Drawing.Point(6, 215);
            this.xgrid3.Name = "xgrid3";
            this.xgrid3.Size = new System.Drawing.Size(499, 266);
            this.xgrid3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name:- ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(-9, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Super Store Managment System";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1144, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpbox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "SuperStoreManagementSystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbox2.ResumeLayout(false);
            this.grpbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xgrid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu;
        private System.Windows.Forms.ToolStripMenuItem searchmnu;
        private System.Windows.Forms.ToolStripMenuItem namemnu;
        private System.Windows.Forms.ToolStripMenuItem insertmnu;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbox7;
        private System.Windows.Forms.GroupBox grpbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView xgrid3;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.TextBox txtbox6;
        private System.Windows.Forms.Button btnrfresh;
        private System.Windows.Forms.TextBox txtbox8;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ToolStripMenuItem cstmnu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnproceed;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}