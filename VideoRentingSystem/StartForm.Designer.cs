namespace VideoRentingSystem
{
    partial class StartForm
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
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSellingMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.issueReturnToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.showAllCustomersToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMovieToolStripMenuItem,
            this.showAllMoviesToolStripMenuItem});
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.moviesToolStripMenuItem.Text = "Movies";
            // 
            // issueReturnToolStripMenuItem
            // 
            this.issueReturnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueMovieToolStripMenuItem,
            this.returnMovieToolStripMenuItem});
            this.issueReturnToolStripMenuItem.Name = "issueReturnToolStripMenuItem";
            this.issueReturnToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.issueReturnToolStripMenuItem.Text = "Issue/Return";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestCustomersToolStripMenuItem,
            this.bestSellingMoviesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // newMovieToolStripMenuItem
            // 
            this.newMovieToolStripMenuItem.Name = "newMovieToolStripMenuItem";
            this.newMovieToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newMovieToolStripMenuItem.Text = "New Movie";
            this.newMovieToolStripMenuItem.Click += new System.EventHandler(this.newMovieToolStripMenuItem_Click);
            // 
            // showAllMoviesToolStripMenuItem
            // 
            this.showAllMoviesToolStripMenuItem.Name = "showAllMoviesToolStripMenuItem";
            this.showAllMoviesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showAllMoviesToolStripMenuItem.Text = "Show All Movies";
            this.showAllMoviesToolStripMenuItem.Click += new System.EventHandler(this.showAllMoviesToolStripMenuItem_Click);
            // 
            // showAllCustomersToolStripMenuItem
            // 
            this.showAllCustomersToolStripMenuItem.Name = "showAllCustomersToolStripMenuItem";
            this.showAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllCustomersToolStripMenuItem.Text = "Show All Customers";
            this.showAllCustomersToolStripMenuItem.Click += new System.EventHandler(this.showAllCustomersToolStripMenuItem_Click);
            // 
            // issueMovieToolStripMenuItem
            // 
            this.issueMovieToolStripMenuItem.Name = "issueMovieToolStripMenuItem";
            this.issueMovieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.issueMovieToolStripMenuItem.Text = "Issue Movie";
            this.issueMovieToolStripMenuItem.Click += new System.EventHandler(this.issueMovieToolStripMenuItem_Click);
            // 
            // returnMovieToolStripMenuItem
            // 
            this.returnMovieToolStripMenuItem.Name = "returnMovieToolStripMenuItem";
            this.returnMovieToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.returnMovieToolStripMenuItem.Text = "Return Movie";
            this.returnMovieToolStripMenuItem.Click += new System.EventHandler(this.returnMovieToolStripMenuItem_Click);
            // 
            // bestCustomersToolStripMenuItem
            // 
            this.bestCustomersToolStripMenuItem.Name = "bestCustomersToolStripMenuItem";
            this.bestCustomersToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bestCustomersToolStripMenuItem.Text = "Best Customers";
            this.bestCustomersToolStripMenuItem.Click += new System.EventHandler(this.bestCustomersToolStripMenuItem_Click);
            // 
            // bestSellingMoviesToolStripMenuItem
            // 
            this.bestSellingMoviesToolStripMenuItem.Name = "bestSellingMoviesToolStripMenuItem";
            this.bestSellingMoviesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.bestSellingMoviesToolStripMenuItem.Text = "Best Selling Movies";
            this.bestSellingMoviesToolStripMenuItem.Click += new System.EventHandler(this.bestSellingMoviesToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 294);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSellingMoviesToolStripMenuItem;
    }
}