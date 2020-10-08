namespace SmartSaver
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.moreButton = new System.Windows.Forms.Button();
            this.balanceButton = new System.Windows.Forms.Button();
            this.spendingsButton = new System.Windows.Forms.Button();
            this.savingsButton = new System.Windows.Forms.Button();
            this.transactionsButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(81)))));
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Controls.Add(this.moreButton);
            this.navigationPanel.Controls.Add(this.balanceButton);
            this.navigationPanel.Controls.Add(this.spendingsButton);
            this.navigationPanel.Controls.Add(this.savingsButton);
            this.navigationPanel.Controls.Add(this.transactionsButton);
            this.navigationPanel.Controls.Add(this.titleLabel);
            this.navigationPanel.Location = new System.Drawing.Point(-8, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1280, 70);
            this.navigationPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.homeButton.Location = new System.Drawing.Point(341, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(150, 70);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // moreButton
            // 
            this.moreButton.FlatAppearance.BorderSize = 0;
            this.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.moreButton.Location = new System.Drawing.Point(1121, 0);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(150, 70);
            this.moreButton.TabIndex = 2;
            this.moreButton.Text = "More";
            this.moreButton.UseVisualStyleBackColor = true;
            this.moreButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // balanceButton
            // 
            this.balanceButton.FlatAppearance.BorderSize = 0;
            this.balanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.balanceButton.Location = new System.Drawing.Point(965, 0);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(150, 70);
            this.balanceButton.TabIndex = 2;
            this.balanceButton.Text = "Balance";
            this.balanceButton.UseVisualStyleBackColor = true;
            this.balanceButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // spendingsButton
            // 
            this.spendingsButton.FlatAppearance.BorderSize = 0;
            this.spendingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spendingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.spendingsButton.Location = new System.Drawing.Point(809, 0);
            this.spendingsButton.Name = "spendingsButton";
            this.spendingsButton.Size = new System.Drawing.Size(150, 70);
            this.spendingsButton.TabIndex = 2;
            this.spendingsButton.Text = "Spendings";
            this.spendingsButton.UseVisualStyleBackColor = true;
            this.spendingsButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // savingsButton
            // 
            this.savingsButton.FlatAppearance.BorderSize = 0;
            this.savingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.savingsButton.Location = new System.Drawing.Point(653, 0);
            this.savingsButton.Name = "savingsButton";
            this.savingsButton.Size = new System.Drawing.Size(150, 70);
            this.savingsButton.TabIndex = 2;
            this.savingsButton.Text = "Savings";
            this.savingsButton.UseVisualStyleBackColor = true;
            this.savingsButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // transactionsButton
            // 
            this.transactionsButton.FlatAppearance.BorderSize = 0;
            this.transactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.transactionsButton.Location = new System.Drawing.Point(497, 0);
            this.transactionsButton.Name = "transactionsButton";
            this.transactionsButton.Size = new System.Drawing.Size(150, 70);
            this.transactionsButton.TabIndex = 2;
            this.transactionsButton.Text = "Transactions";
            this.transactionsButton.UseVisualStyleBackColor = true;
            this.transactionsButton.Click += new System.EventHandler(this.NavigationButtonClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(246, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Komanda X Smart Saver";
            // 
            // pagePanel
            // 
            this.pagePanel.Location = new System.Drawing.Point(-7, 70);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(1280, 620);
            this.pagePanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Smart Saver";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel navigationPanel;
		private System.Windows.Forms.Button transactionsButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Button moreButton;
		private System.Windows.Forms.Button balanceButton;
		private System.Windows.Forms.Button spendingsButton;
		private System.Windows.Forms.Button savingsButton;
		private System.Windows.Forms.Button homeButton;
		private System.Windows.Forms.Panel pagePanel;
	}
}

