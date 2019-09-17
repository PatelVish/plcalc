namespace plcalc
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTradesToolStripMenuItem,
            this.makeTradeToolStripMenuItem,
            this.pLReportToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // viewTradesToolStripMenuItem
            // 
            this.viewTradesToolStripMenuItem.Name = "viewTradesToolStripMenuItem";
            this.viewTradesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewTradesToolStripMenuItem.Tag = "vt";
            this.viewTradesToolStripMenuItem.Text = "View Trades";
            this.viewTradesToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // makeTradeToolStripMenuItem
            // 
            this.makeTradeToolStripMenuItem.Name = "makeTradeToolStripMenuItem";
            this.makeTradeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.makeTradeToolStripMenuItem.Tag = "mt";
            this.makeTradeToolStripMenuItem.Text = "Make Trade";
            this.makeTradeToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // pLReportToolStripMenuItem
            // 
            this.pLReportToolStripMenuItem.Name = "pLReportToolStripMenuItem";
            this.pLReportToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pLReportToolStripMenuItem.Tag = "pl";
            this.pLReportToolStripMenuItem.Text = "P && L Report";
            this.pLReportToolStripMenuItem.Click += new System.EventHandler(this.menu_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLReportToolStripMenuItem;
    }
}