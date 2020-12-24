namespace MDIDemo
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用黑洞吸掉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑洞龜頭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.severToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.socketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.檔案ToolStripMenuItem.Text = "檔案&F";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用黑洞吸掉ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            this.編輯ToolStripMenuItem.Click += new System.EventHandler(this.編輯ToolStripMenuItem_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.黑洞龜頭ToolStripMenuItem});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啟ToolStripMenuItem.Text = "開啟";
            // 
            // 用黑洞吸掉ToolStripMenuItem
            // 
            this.用黑洞吸掉ToolStripMenuItem.Name = "用黑洞吸掉ToolStripMenuItem";
            this.用黑洞吸掉ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.用黑洞吸掉ToolStripMenuItem.Text = "用黑洞吸掉";
            this.用黑洞吸掉ToolStripMenuItem.Click += new System.EventHandler(this.用黑洞吸掉ToolStripMenuItem_Click);
            // 
            // 黑洞龜頭ToolStripMenuItem
            // 
            this.黑洞龜頭ToolStripMenuItem.Name = "黑洞龜頭ToolStripMenuItem";
            this.黑洞龜頭ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.黑洞龜頭ToolStripMenuItem.Text = "黑洞龜頭";
            // 
            // socketToolStripMenuItem
            // 
            this.socketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.severToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.socketToolStripMenuItem.Name = "socketToolStripMenuItem";
            this.socketToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.socketToolStripMenuItem.Text = "socket";
            // 
            // severToolStripMenuItem
            // 
            this.severToolStripMenuItem.Name = "severToolStripMenuItem";
            this.severToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.severToolStripMenuItem.Text = "sever";
            this.severToolStripMenuItem.Click += new System.EventHandler(this.SeverToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用黑洞吸掉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑洞龜頭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem socketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem severToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
    }
}

