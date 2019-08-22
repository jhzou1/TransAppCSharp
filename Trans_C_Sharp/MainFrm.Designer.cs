namespace Trans_C_Sharp
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.txtSourceStr = new System.Windows.Forms.RichTextBox();
            this.richTargetStr = new System.Windows.Forms.RichTextBox();
            this.lblNowTranc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTrans = new System.Windows.Forms.Button();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnImgTrans = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnOpenWeb = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckForUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckForUpdate.Image")));
            this.btnCheckForUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckForUpdate.Location = new System.Drawing.Point(821, 620);
            this.btnCheckForUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(109, 38);
            this.btnCheckForUpdate.TabIndex = 0;
            this.btnCheckForUpdate.Text = "检查更新";
            this.btnCheckForUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // txtSourceStr
            // 
            this.txtSourceStr.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSourceStr.Location = new System.Drawing.Point(16, 62);
            this.txtSourceStr.Margin = new System.Windows.Forms.Padding(4);
            this.txtSourceStr.Name = "txtSourceStr";
            this.txtSourceStr.Size = new System.Drawing.Size(1023, 275);
            this.txtSourceStr.TabIndex = 1;
            this.txtSourceStr.Text = "";
            this.txtSourceStr.TextChanged += new System.EventHandler(this.txtSourceStr_TextChanged);
            this.txtSourceStr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSourceStr_KeyPress);
            // 
            // richTargetStr
            // 
            this.richTargetStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTargetStr.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTargetStr.Location = new System.Drawing.Point(16, 384);
            this.richTargetStr.Margin = new System.Windows.Forms.Padding(4);
            this.richTargetStr.Name = "richTargetStr";
            this.richTargetStr.Size = new System.Drawing.Size(1022, 223);
            this.richTargetStr.TabIndex = 1;
            this.richTargetStr.Text = "";
            this.richTargetStr.TextChanged += new System.EventHandler(this.richTargetStr_TextChanged);
            // 
            // lblNowTranc
            // 
            this.lblNowTranc.AutoSize = true;
            this.lblNowTranc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowTranc.Location = new System.Drawing.Point(18, 349);
            this.lblNowTranc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNowTranc.Name = "lblNowTranc";
            this.lblNowTranc.Size = new System.Drawing.Size(98, 18);
            this.lblNowTranc.TabIndex = 4;
            this.lblNowTranc.Text = "语言自动检测";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTrans
            // 
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrans.Location = new System.Drawing.Point(939, 23);
            this.btnTrans.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(100, 31);
            this.btnTrans.TabIndex = 5;
            this.btnTrans.Text = "翻译";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // cbTransType
            // 
            this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Location = new System.Drawing.Point(214, 347);
            this.cbTransType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(121, 24);
            this.cbTransType.TabIndex = 6;
            this.cbTransType.SelectedValueChanged += new System.EventHandler(this.cbTransType_SelectedValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "叔叔翻译APP";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示界面ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 76);
            // 
            // 显示界面ToolStripMenuItem
            // 
            this.显示界面ToolStripMenuItem.Name = "显示界面ToolStripMenuItem";
            this.显示界面ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.显示界面ToolStripMenuItem.Text = "显示界面";
            this.显示界面ToolStripMenuItem.Click += new System.EventHandler(this.显示界面ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(937, 620);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(102, 38);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "关于";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(611, 627);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(27, 25);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "   ";
            // 
            // btnImgTrans
            // 
            this.btnImgTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnImgTrans.Image")));
            this.btnImgTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImgTrans.Location = new System.Drawing.Point(821, 23);
            this.btnImgTrans.Margin = new System.Windows.Forms.Padding(4);
            this.btnImgTrans.Name = "btnImgTrans";
            this.btnImgTrans.Size = new System.Drawing.Size(109, 31);
            this.btnImgTrans.TabIndex = 9;
            this.btnImgTrans.Text = "图片翻译";
            this.btnImgTrans.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImgTrans.UseVisualStyleBackColor = true;
            this.btnImgTrans.Click += new System.EventHandler(this.btnImgTrans_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(940, 344);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(99, 29);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "复制翻译";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnOpenWeb
            // 
            this.btnOpenWeb.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenWeb.Image")));
            this.btnOpenWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenWeb.Location = new System.Drawing.Point(705, 23);
            this.btnOpenWeb.Name = "btnOpenWeb";
            this.btnOpenWeb.Size = new System.Drawing.Size(109, 31);
            this.btnOpenWeb.TabIndex = 11;
            this.btnOpenWeb.Text = "百度翻译";
            this.btnOpenWeb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenWeb.UseVisualStyleBackColor = true;
            this.btnOpenWeb.Click += new System.EventHandler(this.btnOpenWeb_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1056, 669);
            this.Controls.Add(this.btnOpenWeb);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnImgTrans);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.cbTransType);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.lblNowTranc);
            this.Controls.Add(this.richTargetStr);
            this.Controls.Add(this.txtSourceStr);
            this.Controls.Add(this.btnCheckForUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UncleTrans App 叔叔翻译 beta ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainFrm_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckForUpdate;
        private System.Windows.Forms.RichTextBox txtSourceStr;
        private System.Windows.Forms.RichTextBox richTargetStr;
        private System.Windows.Forms.Label lblNowTranc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.Button btnImgTrans;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnOpenWeb;
    }
}

