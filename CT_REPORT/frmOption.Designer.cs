namespace CT_REPORT
{
    partial class frmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOption));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.month_S = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month_E = new System.Windows.Forms.NumericUpDown();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioFullname = new System.Windows.Forms.RadioButton();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.radioMobile = new System.Windows.Forms.RadioButton();
            this.radioCtAll = new System.Windows.Forms.RadioButton();
            this.cbWhcode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chkwh2 = new System.Windows.Forms.RadioButton();
            this.Chkwh3 = new System.Windows.Forms.RadioButton();
            this.checkWh = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.month_S)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_E)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 41);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 38);
            this.toolStripButton1.Text = "ตกลง";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(169, 38);
            this.toolStripButton2.Text = "ปิดหน้าต่าง";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // month_S
            // 
            this.month_S.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_S.Location = new System.Drawing.Point(276, 171);
            this.month_S.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month_S.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_S.Name = "month_S";
            this.month_S.Size = new System.Drawing.Size(112, 32);
            this.month_S.TabIndex = 2;
            this.month_S.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_S.ValueChanged += new System.EventHandler(this.Month_S_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "เริ่มเดือน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ถึงเดือน";
            // 
            // month_E
            // 
            this.month_E.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_E.Location = new System.Drawing.Point(488, 171);
            this.month_E.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.month_E.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_E.Name = "month_E";
            this.month_E.Size = new System.Drawing.Size(112, 32);
            this.month_E.TabIndex = 4;
            this.month_E.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.month_E.ValueChanged += new System.EventHandler(this.Month_E_ValueChanged);
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMonth.Location = new System.Drawing.Point(41, 171);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(105, 28);
            this.radioMonth.TabIndex = 6;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "เดือนเกิด";
            this.radioMonth.UseVisualStyleBackColor = true;
            this.radioMonth.CheckedChanged += new System.EventHandler(this.RadioMonth_CheckedChanged);
            // 
            // radioFullname
            // 
            this.radioFullname.AutoSize = true;
            this.radioFullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFullname.Location = new System.Drawing.Point(41, 71);
            this.radioFullname.Name = "radioFullname";
            this.radioFullname.Size = new System.Drawing.Size(102, 28);
            this.radioFullname.TabIndex = 7;
            this.radioFullname.TabStop = true;
            this.radioFullname.Text = "ชื่อลูกค้า";
            this.radioFullname.UseVisualStyleBackColor = true;
            this.radioFullname.CheckedChanged += new System.EventHandler(this.RadioFullname_CheckedChanged);
            // 
            // txtFullname
            // 
            this.txtFullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.Location = new System.Drawing.Point(247, 70);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(221, 36);
            this.txtFullname.TabIndex = 8;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(247, 120);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(221, 36);
            this.txtMobile.TabIndex = 10;
            this.txtMobile.TextChanged += new System.EventHandler(this.TxtMobile_TextChanged);
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMobile_KeyPress);
            // 
            // radioMobile
            // 
            this.radioMobile.AutoSize = true;
            this.radioMobile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMobile.Location = new System.Drawing.Point(41, 121);
            this.radioMobile.Name = "radioMobile";
            this.radioMobile.Size = new System.Drawing.Size(182, 28);
            this.radioMobile.TabIndex = 9;
            this.radioMobile.TabStop = true;
            this.radioMobile.Text = "หมายเลขโทรศัพท์";
            this.radioMobile.UseVisualStyleBackColor = true;
            this.radioMobile.CheckedChanged += new System.EventHandler(this.RadioMobile_CheckedChanged);
            // 
            // radioCtAll
            // 
            this.radioCtAll.AutoSize = true;
            this.radioCtAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCtAll.Location = new System.Drawing.Point(41, 21);
            this.radioCtAll.Name = "radioCtAll";
            this.radioCtAll.Size = new System.Drawing.Size(138, 28);
            this.radioCtAll.TabIndex = 11;
            this.radioCtAll.TabStop = true;
            this.radioCtAll.Text = "ลูกค้าทั้งหมด";
            this.radioCtAll.UseVisualStyleBackColor = true;
            this.radioCtAll.CheckedChanged += new System.EventHandler(this.RadioCtAll_CheckedChanged);
            // 
            // cbWhcode
            // 
            this.cbWhcode.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbWhcode.FormattingEnabled = true;
            this.cbWhcode.Location = new System.Drawing.Point(230, 66);
            this.cbWhcode.Name = "cbWhcode";
            this.cbWhcode.Size = new System.Drawing.Size(221, 32);
            this.cbWhcode.TabIndex = 13;
            this.cbWhcode.Visible = false;
            this.cbWhcode.SelectedIndexChanged += new System.EventHandler(this.CbWhcode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chkwh2);
            this.groupBox1.Controls.Add(this.Chkwh3);
            this.groupBox1.Controls.Add(this.checkWh);
            this.groupBox1.Controls.Add(this.cbWhcode);
            this.groupBox1.Location = new System.Drawing.Point(30, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 163);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกสาขา";
            // 
            // Chkwh2
            // 
            this.Chkwh2.AutoSize = true;
            this.Chkwh2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkwh2.Location = new System.Drawing.Point(42, 67);
            this.Chkwh2.Name = "Chkwh2";
            this.Chkwh2.Size = new System.Drawing.Size(106, 28);
            this.Chkwh2.TabIndex = 16;
            this.Chkwh2.TabStop = true;
            this.Chkwh2.Text = "ระบุสาขา";
            this.Chkwh2.UseVisualStyleBackColor = true;
            this.Chkwh2.CheckedChanged += new System.EventHandler(this.Chkwh2_CheckedChanged);
            // 
            // Chkwh3
            // 
            this.Chkwh3.AutoSize = true;
            this.Chkwh3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chkwh3.Location = new System.Drawing.Point(42, 112);
            this.Chkwh3.Name = "Chkwh3";
            this.Chkwh3.Size = new System.Drawing.Size(136, 28);
            this.Chkwh3.TabIndex = 15;
            this.Chkwh3.TabStop = true;
            this.Chkwh3.Text = "สาขาทั้งหมด";
            this.Chkwh3.UseVisualStyleBackColor = true;
            this.Chkwh3.CheckedChanged += new System.EventHandler(this.Chkwh3_CheckedChanged);
            // 
            // checkWh
            // 
            this.checkWh.AutoSize = true;
            this.checkWh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWh.Location = new System.Drawing.Point(42, 22);
            this.checkWh.Name = "checkWh";
            this.checkWh.Size = new System.Drawing.Size(178, 28);
            this.checkWh.TabIndex = 14;
            this.checkWh.TabStop = true;
            this.checkWh.Text = "เฉพาะสาขาตัวเอง";
            this.checkWh.UseVisualStyleBackColor = true;
            this.checkWh.CheckedChanged += new System.EventHandler(this.CheckWh_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCtAll);
            this.groupBox2.Controls.Add(this.month_S);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.month_E);
            this.groupBox2.Controls.Add(this.radioMobile);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFullname);
            this.groupBox2.Controls.Add(this.radioMonth);
            this.groupBox2.Controls.Add(this.radioFullname);
            this.groupBox2.Location = new System.Drawing.Point(30, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 248);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายละเอียดลูกค้า";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เงื่อนไข";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.month_S)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month_E)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.NumericUpDown month_S;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown month_E;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioFullname;
        public System.Windows.Forms.TextBox txtFullname;
        public System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.RadioButton radioMobile;
        private System.Windows.Forms.RadioButton radioCtAll;
        private System.Windows.Forms.ComboBox cbWhcode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Chkwh3;
        private System.Windows.Forms.RadioButton checkWh;
        private System.Windows.Forms.RadioButton Chkwh2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}