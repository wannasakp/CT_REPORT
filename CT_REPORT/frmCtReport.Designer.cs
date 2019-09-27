namespace CT_REPORT
{
    partial class frmCtReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCtReport));
            this.pnlNavigate = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddMP = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lsvDt = new k.libary.kListView(this.components);
            this.pnlNavigate.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigate
            // 
            this.pnlNavigate.BackColor = System.Drawing.Color.White;
            this.pnlNavigate.Controls.Add(this.btnFirst);
            this.pnlNavigate.Controls.Add(this.btnPrev);
            this.pnlNavigate.Controls.Add(this.btnNext);
            this.pnlNavigate.Controls.Add(this.btnLast);
            this.pnlNavigate.Controls.Add(this.lblInfo);
            this.pnlNavigate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigate.Location = new System.Drawing.Point(0, 447);
            this.pnlNavigate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavigate.Name = "pnlNavigate";
            this.pnlNavigate.Size = new System.Drawing.Size(770, 52);
            this.pnlNavigate.TabIndex = 23;
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::CT_REPORT.Properties.Resources.first;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFirst.Location = new System.Drawing.Point(593, 0);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(48, 52);
            this.btnFirst.TabIndex = 20;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = global::CT_REPORT.Properties.Resources.previous;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrev.Location = new System.Drawing.Point(641, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(43, 52);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::CT_REPORT.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(684, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 52);
            this.btnNext.TabIndex = 22;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = global::CT_REPORT.Properties.Resources.last;
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLast.Location = new System.Drawing.Point(727, 0);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 52);
            this.btnLast.TabIndex = 23;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblInfo.Location = new System.Drawing.Point(11, 11);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(53, 18);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "lblInfo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.lsvDt);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 375);
            this.panel1.TabIndex = 27;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(745, 375);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb.TabIndex = 219;
            this.pb.TabStop = false;
            this.pb.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddMP,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 45);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddMP
            // 
            this.toolStripAddMP.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddMP.Image")));
            this.toolStripAddMP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddMP.Name = "toolStripAddMP";
            this.toolStripAddMP.Size = new System.Drawing.Size(115, 42);
            this.toolStripAddMP.Text = "เงื่อนไข";
            this.toolStripAddMP.Click += new System.EventHandler(this.ToolStripAddMP_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(160, 42);
            this.toolStripExit.Text = "ปิดหน้าต่าง";
            this.toolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // lsvDt
            // 
            this.lsvDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDt.FullRowSelect = true;
            this.lsvDt.GridLines = true;
            this.lsvDt.Location = new System.Drawing.Point(0, 0);
            this.lsvDt.Margin = new System.Windows.Forms.Padding(4);
            this.lsvDt.Name = "lsvDt";
            this.lsvDt.Size = new System.Drawing.Size(745, 375);
            this.lsvDt.TabIndex = 221;
            this.lsvDt.UseCompatibleStateImageBehavior = false;
            this.lsvDt.View = System.Windows.Forms.View.Details;
            this.lsvDt.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LsvDt_ColumnClick);
            // 
            // frmCtReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 499);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlNavigate);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Name = "frmCtReport";
            this.Text = "frmReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCtReport_Load);
            this.pnlNavigate.ResumeLayout(false);
            this.pnlNavigate.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigate;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAddMP;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private k.libary.kListView lsvDt;
    }
}

