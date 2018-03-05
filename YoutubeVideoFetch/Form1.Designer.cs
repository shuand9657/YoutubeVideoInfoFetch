namespace YoutubeVideoFetch
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_FetchVideo = new System.Windows.Forms.Button();
            this.tb_VideoID = new System.Windows.Forms.TextBox();
            this.tb_videoInfo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_xmlItems = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_XmlUpdate = new System.Windows.Forms.Button();
            this.dt_PubDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_pubDate = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tb_XmlTitle = new System.Windows.Forms.TextBox();
            this.lbl_Cross = new System.Windows.Forms.Label();
            this.lbl_uTubeLink = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_XmlContent = new System.Windows.Forms.TextBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_removeList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_FetchVideo
            // 
            this.btn_FetchVideo.Location = new System.Drawing.Point(787, 6);
            this.btn_FetchVideo.Name = "btn_FetchVideo";
            this.btn_FetchVideo.Size = new System.Drawing.Size(75, 23);
            this.btn_FetchVideo.TabIndex = 0;
            this.btn_FetchVideo.Text = "Fetch";
            this.btn_FetchVideo.UseVisualStyleBackColor = true;
            this.btn_FetchVideo.Click += new System.EventHandler(this.btn_FetchVideo_Click);
            // 
            // tb_VideoID
            // 
            this.tb_VideoID.Location = new System.Drawing.Point(405, 6);
            this.tb_VideoID.Name = "tb_VideoID";
            this.tb_VideoID.Size = new System.Drawing.Size(376, 22);
            this.tb_VideoID.TabIndex = 1;
            // 
            // tb_videoInfo
            // 
            this.tb_videoInfo.Location = new System.Drawing.Point(275, 92);
            this.tb_videoInfo.Multiline = true;
            this.tb_videoInfo.Name = "tb_videoInfo";
            this.tb_videoInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_videoInfo.Size = new System.Drawing.Size(589, 414);
            this.tb_videoInfo.TabIndex = 2;
            this.tb_videoInfo.TextChanged += new System.EventHandler(this.tb_videoInfo_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            this.開啟檔案ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.開啟檔案ToolStripMenuItem.Text = "開啟檔案";
            this.開啟檔案ToolStripMenuItem.Click += new System.EventHandler(this.開啟檔案ToolStripMenuItem_Click);
            // 
            // lb_xmlItems
            // 
            this.lb_xmlItems.FormattingEnabled = true;
            this.lb_xmlItems.ItemHeight = 12;
            this.lb_xmlItems.Location = new System.Drawing.Point(6, 42);
            this.lb_xmlItems.Name = "lb_xmlItems";
            this.lb_xmlItems.ScrollAlwaysVisible = true;
            this.lb_xmlItems.Size = new System.Drawing.Size(249, 496);
            this.lb_xmlItems.TabIndex = 4;
            this.lb_xmlItems.SelectedIndexChanged += new System.EventHandler(this.lb_xmlItems_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 618);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_removeList);
            this.tabPage1.Controls.Add(this.btn_addItem);
            this.tabPage1.Controls.Add(this.btn_XmlUpdate);
            this.tabPage1.Controls.Add(this.dt_PubDate);
            this.tabPage1.Controls.Add(this.lbl_pubDate);
            this.tabPage1.Controls.Add(this.lbl_Description);
            this.tabPage1.Controls.Add(this.lbl_Title);
            this.tabPage1.Controls.Add(this.tb_XmlTitle);
            this.tabPage1.Controls.Add(this.lbl_Cross);
            this.tabPage1.Controls.Add(this.lbl_uTubeLink);
            this.tabPage1.Controls.Add(this.tb_videoInfo);
            this.tabPage1.Controls.Add(this.tb_VideoID);
            this.tabPage1.Controls.Add(this.btn_FetchVideo);
            this.tabPage1.Controls.Add(this.lb_xmlItems);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_XmlUpdate
            // 
            this.btn_XmlUpdate.Location = new System.Drawing.Point(787, 45);
            this.btn_XmlUpdate.Name = "btn_XmlUpdate";
            this.btn_XmlUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_XmlUpdate.TabIndex = 13;
            this.btn_XmlUpdate.Text = "更新";
            this.btn_XmlUpdate.UseVisualStyleBackColor = true;
            this.btn_XmlUpdate.Click += new System.EventHandler(this.btn_XmlUpdate_Click);
            // 
            // dt_PubDate
            // 
            this.dt_PubDate.Location = new System.Drawing.Point(405, 512);
            this.dt_PubDate.Name = "dt_PubDate";
            this.dt_PubDate.Size = new System.Drawing.Size(200, 22);
            this.dt_PubDate.TabIndex = 12;
            // 
            // lbl_pubDate
            // 
            this.lbl_pubDate.AutoSize = true;
            this.lbl_pubDate.Location = new System.Drawing.Point(273, 519);
            this.lbl_pubDate.Name = "lbl_pubDate";
            this.lbl_pubDate.Size = new System.Drawing.Size(38, 12);
            this.lbl_pubDate.TabIndex = 11;
            this.lbl_pubDate.Text = "日期 : ";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(273, 77);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(38, 12);
            this.lbl_Description.TabIndex = 9;
            this.lbl_Description.Text = "內容 : ";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(273, 52);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(38, 12);
            this.lbl_Title.TabIndex = 8;
            this.lbl_Title.Text = "標題 : ";
            // 
            // tb_XmlTitle
            // 
            this.tb_XmlTitle.Location = new System.Drawing.Point(405, 47);
            this.tb_XmlTitle.Name = "tb_XmlTitle";
            this.tb_XmlTitle.Size = new System.Drawing.Size(376, 22);
            this.tb_XmlTitle.TabIndex = 7;
            // 
            // lbl_Cross
            // 
            this.lbl_Cross.AutoSize = true;
            this.lbl_Cross.Location = new System.Drawing.Point(285, 32);
            this.lbl_Cross.Name = "lbl_Cross";
            this.lbl_Cross.Size = new System.Drawing.Size(561, 12);
            this.lbl_Cross.TabIndex = 6;
            this.lbl_Cross.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------";
            // 
            // lbl_uTubeLink
            // 
            this.lbl_uTubeLink.AutoSize = true;
            this.lbl_uTubeLink.Location = new System.Drawing.Point(273, 11);
            this.lbl_uTubeLink.Name = "lbl_uTubeLink";
            this.lbl_uTubeLink.Size = new System.Drawing.Size(78, 12);
            this.lbl_uTubeLink.TabIndex = 5;
            this.lbl_uTubeLink.Text = "Youtube網址 : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_XmlContent);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 592);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_XmlContent
            // 
            this.tb_XmlContent.Location = new System.Drawing.Point(6, 6);
            this.tb_XmlContent.Multiline = true;
            this.tb_XmlContent.Name = "tb_XmlContent";
            this.tb_XmlContent.Size = new System.Drawing.Size(674, 353);
            this.tb_XmlContent.TabIndex = 0;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(193, 6);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(29, 21);
            this.btn_addItem.TabIndex = 14;
            this.btn_addItem.Text = "+";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // btn_removeList
            // 
            this.btn_removeList.Location = new System.Drawing.Point(229, 6);
            this.btn_removeList.Name = "btn_removeList";
            this.btn_removeList.Size = new System.Drawing.Size(26, 21);
            this.btn_removeList.TabIndex = 15;
            this.btn_removeList.Text = "-";
            this.btn_removeList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 651);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HINET RSS 更新";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_FetchVideo;
        private System.Windows.Forms.TextBox tb_VideoID;
        private System.Windows.Forms.TextBox tb_videoInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.ListBox lb_xmlItems;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_XmlContent;
        private System.Windows.Forms.Label lbl_pubDate;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox tb_XmlTitle;
        private System.Windows.Forms.Label lbl_Cross;
        private System.Windows.Forms.Label lbl_uTubeLink;
        private System.Windows.Forms.DateTimePicker dt_PubDate;
        private System.Windows.Forms.Button btn_XmlUpdate;
        private System.Windows.Forms.Button btn_removeList;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Label label1;
    }
}

