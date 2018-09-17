namespace VideoRentingSystem
{
    partial class IssueMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieId = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Id";
            // 
            // textBox1
            // 
            this.MovieId.Enabled = false;
            this.MovieId.Location = new System.Drawing.Point(170, 44);
            this.MovieId.Name = "textBox1";
            this.MovieId.Size = new System.Drawing.Size(141, 20);
            this.MovieId.TabIndex = 2;
            // 
            // textBox2
            // 
            this.CustomerId.Location = new System.Drawing.Point(170, 88);
            this.CustomerId.Name = "textBox2";
            this.CustomerId.Size = new System.Drawing.Size(141, 20);
            this.CustomerId.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Issue Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerId);
            this.Controls.Add(this.MovieId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IssueMovie";
            this.Text = "IssueMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieId;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.Button button1;
    }
}