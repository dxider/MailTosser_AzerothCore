namespace Mail_Tosser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStyle = new System.Windows.Forms.ComboBox();
            this.lstSearchItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSelectedItems = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.g = new System.Windows.Forms.NumericUpDown();
            this.s = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.c = new System.Windows.Forms.NumericUpDown();
            this.rdbCOD = new System.Windows.Forms.RadioButton();
            this.rdbMoney = new System.Windows.Forms.RadioButton();
            this.lstReceivers = new System.Windows.Forms.ListView();
            this.colNameReceiver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRec = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpExp = new System.Windows.Forms.MonthCalendar();
            this.dtpDel = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ckbInstant = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(389, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.BackColor = System.Drawing.Color.Black;
            this.txtSubject.ForeColor = System.Drawing.Color.White;
            this.txtSubject.Location = new System.Drawing.Point(450, 8);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(416, 22);
            this.txtSubject.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Body:";
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.BackColor = System.Drawing.Color.Black;
            this.txtBody.ForeColor = System.Drawing.Color.White;
            this.txtBody.Location = new System.Drawing.Point(389, 109);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(477, 410);
            this.txtBody.TabIndex = 2;
            this.txtBody.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(389, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Style:";
            // 
            // txtStyle
            // 
            this.txtStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStyle.BackColor = System.Drawing.Color.Black;
            this.txtStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStyle.ForeColor = System.Drawing.Color.White;
            this.txtStyle.FormattingEnabled = true;
            this.txtStyle.Items.AddRange(new object[] {
            "Default",
            "Blizzard",
            "Auction House",
            "Valentine\'s Day",
            "The Orphanage",
            "Magic Scroll"});
            this.txtStyle.Location = new System.Drawing.Point(450, 41);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(416, 24);
            this.txtStyle.TabIndex = 1;
            // 
            // lstSearchItems
            // 
            this.lstSearchItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSearchItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchItems.ForeColor = System.Drawing.Color.White;
            this.lstSearchItems.FullRowSelect = true;
            this.lstSearchItems.GridLines = true;
            this.lstSearchItems.HideSelection = false;
            this.lstSearchItems.Location = new System.Drawing.Point(9, 67);
            this.lstSearchItems.MultiSelect = false;
            this.lstSearchItems.Name = "lstSearchItems";
            this.lstSearchItems.Size = new System.Drawing.Size(251, 241);
            this.lstSearchItems.TabIndex = 5237;
            this.lstSearchItems.UseCompatibleStateImageBehavior = false;
            this.lstSearchItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 160;
            // 
            // lstSelectedItems
            // 
            this.lstSelectedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSelectedItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSelectedItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colCount});
            this.lstSelectedItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelectedItems.ForeColor = System.Drawing.Color.White;
            this.lstSelectedItems.FullRowSelect = true;
            this.lstSelectedItems.GridLines = true;
            this.lstSelectedItems.HideSelection = false;
            this.lstSelectedItems.Location = new System.Drawing.Point(313, 36);
            this.lstSelectedItems.MultiSelect = false;
            this.lstSelectedItems.Name = "lstSelectedItems";
            this.lstSelectedItems.Size = new System.Drawing.Size(292, 272);
            this.lstSelectedItems.TabIndex = 5237;
            this.lstSelectedItems.UseCompatibleStateImageBehavior = false;
            this.lstSelectedItems.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "Id";
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colCount
            // 
            this.colCount.Text = "Count";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(475, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Made by Viggo Lundén (viggo.lunden@gmail.com)  -- UI Updated by Isaac Gomez (dxid" +
    "er@gmail.com)";
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSearch.Image = global::Mail_Tosser.Properties.Resources.magnifier;
            this.picSearch.Location = new System.Drawing.Point(244, 36);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(16, 16);
            this.picSearch.TabIndex = 18;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search items";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(9, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Image = global::Mail_Tosser.Properties.Resources.arrow_left;
            this.btnDel.Location = new System.Drawing.Point(266, 191);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(35, 107);
            this.btnDel.TabIndex = 14;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::Mail_Tosser.Properties.Resources.arrow_right;
            this.btnAdd.Location = new System.Drawing.Point(266, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 118);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddSelected);
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(266, 36);
            this.numCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(35, 20);
            this.numCount.TabIndex = 6;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.ForeColor = System.Drawing.Color.White;
            this.lblCapacity.Location = new System.Drawing.Point(310, 17);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(144, 16);
            this.lblCapacity.TabIndex = 10;
            this.lblCapacity.Text = "Attached items (0 of 12)";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(12, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(37, 12);
            this.lblVersion.TabIndex = 14;
            this.lblVersion.Text = "Version";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Image = global::Mail_Tosser.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHelp.Location = new System.Drawing.Point(14, 580);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(26, 32);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Image = global::Mail_Tosser.Properties.Resources.mail_green;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.Location = new System.Drawing.Point(764, 581);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(136, 31);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 554);
            this.tabControl1.TabIndex = 5238;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.rdbCOD);
            this.tabPage1.Controls.Add(this.rdbMoney);
            this.tabPage1.Controls.Add(this.lstReceivers);
            this.tabPage1.Controls.Add(this.txtSender);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnRec);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBody);
            this.tabPage1.Controls.Add(this.txtStyle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mail";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.g, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.s, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.c, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 490);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 29);
            this.tableLayoutPanel1.TabIndex = 5239;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Mail_Tosser.Properties.Resources.coin_single_gold;
            this.pictureBox2.Location = new System.Drawing.Point(3, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::Mail_Tosser.Properties.Resources.coin_single_silver;
            this.pictureBox4.Location = new System.Drawing.Point(98, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 5235;
            this.pictureBox4.TabStop = false;
            // 
            // g
            // 
            this.g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.g.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g.Location = new System.Drawing.Point(25, 5);
            this.g.Maximum = new decimal(new int[] {
            214748,
            0,
            0,
            0});
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(67, 21);
            this.g.TabIndex = 7;
            // 
            // s
            // 
            this.s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(120, 5);
            this.s.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(65, 21);
            this.s.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::Mail_Tosser.Properties.Resources.coin_single_cooper;
            this.pictureBox3.Location = new System.Drawing.Point(191, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // c
            // 
            this.c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(213, 3);
            this.c.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(86, 21);
            this.c.TabIndex = 8;
            // 
            // rdbCOD
            // 
            this.rdbCOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbCOD.AutoSize = true;
            this.rdbCOD.Enabled = false;
            this.rdbCOD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbCOD.Location = new System.Drawing.Point(182, 467);
            this.rdbCOD.Name = "rdbCOD";
            this.rdbCOD.Size = new System.Drawing.Size(129, 20);
            this.rdbCOD.TabIndex = 5238;
            this.rdbCOD.Text = "Cash On Delivery";
            this.rdbCOD.UseVisualStyleBackColor = true;
            // 
            // rdbMoney
            // 
            this.rdbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbMoney.AutoSize = true;
            this.rdbMoney.Checked = true;
            this.rdbMoney.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rdbMoney.Location = new System.Drawing.Point(77, 467);
            this.rdbMoney.Name = "rdbMoney";
            this.rdbMoney.Size = new System.Drawing.Size(66, 20);
            this.rdbMoney.TabIndex = 5237;
            this.rdbMoney.TabStop = true;
            this.rdbMoney.Text = "Money";
            this.rdbMoney.UseVisualStyleBackColor = true;
            // 
            // lstReceivers
            // 
            this.lstReceivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstReceivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstReceivers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNameReceiver});
            this.lstReceivers.ForeColor = System.Drawing.Color.White;
            this.lstReceivers.FullRowSelect = true;
            this.lstReceivers.GridLines = true;
            this.lstReceivers.HideSelection = false;
            this.lstReceivers.Location = new System.Drawing.Point(10, 109);
            this.lstReceivers.MultiSelect = false;
            this.lstReceivers.Name = "lstReceivers";
            this.lstReceivers.Size = new System.Drawing.Size(373, 352);
            this.lstReceivers.TabIndex = 19;
            this.lstReceivers.UseCompatibleStateImageBehavior = false;
            this.lstReceivers.View = System.Windows.Forms.View.Details;
            // 
            // colNameReceiver
            // 
            this.colNameReceiver.Text = "Receivers";
            this.colNameReceiver.Width = 350;
            // 
            // txtSender
            // 
            this.txtSender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSender.FormattingEnabled = true;
            this.txtSender.Location = new System.Drawing.Point(10, 41);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(373, 24);
            this.txtSender.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "From:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "To:";
            // 
            // btnRec
            // 
            this.btnRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRec.Image = global::Mail_Tosser.Properties.Resources.user_add;
            this.btnRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRec.Location = new System.Drawing.Point(211, 71);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(172, 30);
            this.btnRec.TabIndex = 16;
            this.btnRec.Text = "Select receivers...";
            this.btnRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.dtpExp);
            this.tabPage2.Controls.Add(this.dtpDel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ckbInstant);
            this.tabPage2.Controls.Add(this.lstSelectedItems);
            this.tabPage2.Controls.Add(this.picSearch);
            this.tabPage2.Controls.Add(this.lstSearchItems);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.numCount);
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.lblCapacity);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            // 
            // dtpExp
            // 
            this.dtpExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExp.Location = new System.Drawing.Point(313, 340);
            this.dtpExp.MaxSelectionCount = 1;
            this.dtpExp.Name = "dtpExp";
            this.dtpExp.TabIndex = 5242;
            // 
            // dtpDel
            // 
            this.dtpDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDel.Location = new System.Drawing.Point(12, 344);
            this.dtpDel.MaxSelectionCount = 1;
            this.dtpDel.Name = "dtpDel";
            this.dtpDel.TabIndex = 5243;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(310, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 5238;
            this.label5.Text = "Expire date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(8, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 5239;
            this.label10.Text = "Delivery date:";
            // 
            // ckbInstant
            // 
            this.ckbInstant.AutoSize = true;
            this.ckbInstant.Checked = true;
            this.ckbInstant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbInstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbInstant.ForeColor = System.Drawing.Color.White;
            this.ckbInstant.Location = new System.Drawing.Point(202, 315);
            this.ckbInstant.Name = "ckbInstant";
            this.ckbInstant.Size = new System.Drawing.Size(58, 17);
            this.ckbInstant.TabIndex = 5241;
            this.ckbInstant.Text = "Instant";
            this.ckbInstant.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(919, 631);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSend);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(935, 578);
            this.Name = "frmMain";
            this.Text = "N/A";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtStyle;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstSelectedItems;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ListView lstSearchItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader colCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstReceivers;
        private System.Windows.Forms.ColumnHeader colNameReceiver;
        private System.Windows.Forms.ComboBox txtSender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown g;
        private System.Windows.Forms.NumericUpDown s;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown c;
        private System.Windows.Forms.RadioButton rdbCOD;
        private System.Windows.Forms.RadioButton rdbMoney;
        private System.Windows.Forms.MonthCalendar dtpExp;
        private System.Windows.Forms.MonthCalendar dtpDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckbInstant;
    }
}

