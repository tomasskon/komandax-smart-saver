namespace SmartSaver.Forms.Savings
{
    partial class GoalEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalEditForm));
            this.backButton = new System.Windows.Forms.Button();
            this.addAmountTextBox = new System.Windows.Forms.TextBox();
            this.addAmount = new System.Windows.Forms.Label();
            this.goalNameLabel = new System.Windows.Forms.Label();
            this.addToGoalButton = new System.Windows.Forms.Button();
            this.goalRemainingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(643, 181);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(145, 54);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addAmountTextBox
            // 
            this.addAmountTextBox.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.addAmountTextBox.Location = new System.Drawing.Point(356, 118);
            this.addAmountTextBox.Name = "addAmountTextBox";
            this.addAmountTextBox.PlaceholderText = "               €";
            this.addAmountTextBox.Size = new System.Drawing.Size(111, 40);
            this.addAmountTextBox.TabIndex = 5;
            // 
            // addAmount
            // 
            this.addAmount.AutoSize = true;
            this.addAmount.BackColor = System.Drawing.Color.Transparent;
            this.addAmount.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAmount.Location = new System.Drawing.Point(187, 118);
            this.addAmount.Name = "addAmount";
            this.addAmount.Size = new System.Drawing.Size(163, 35);
            this.addAmount.TabIndex = 3;
            this.addAmount.Text = "Add money:";
            // 
            // goalNameLabel
            // 
            this.goalNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalNameLabel.AutoSize = true;
            this.goalNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalNameLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalNameLabel.Location = new System.Drawing.Point(288, 9);
            this.goalNameLabel.Name = "goalNameLabel";
            this.goalNameLabel.Size = new System.Drawing.Size(179, 35);
            this.goalNameLabel.TabIndex = 3;
            this.goalNameLabel.Text = "<Goal Name>";
            this.goalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addToGoalButton
            // 
            this.addToGoalButton.BackColor = System.Drawing.Color.White;
            this.addToGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToGoalButton.Location = new System.Drawing.Point(288, 181);
            this.addToGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToGoalButton.Name = "addToGoalButton";
            this.addToGoalButton.Size = new System.Drawing.Size(245, 54);
            this.addToGoalButton.TabIndex = 1;
            this.addToGoalButton.Text = "Add to Goal";
            this.addToGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addToGoalButton.UseVisualStyleBackColor = false;
            this.addToGoalButton.Click += new System.EventHandler(this.addToGoalButton_Click);
            // 
            // goalRemainingLabel
            // 
            this.goalRemainingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalRemainingLabel.AutoSize = true;
            this.goalRemainingLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalRemainingLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalRemainingLabel.Location = new System.Drawing.Point(288, 56);
            this.goalRemainingLabel.Name = "goalRemainingLabel";
            this.goalRemainingLabel.Size = new System.Drawing.Size(342, 35);
            this.goalRemainingLabel.TabIndex = 3;
            this.goalRemainingLabel.Text = "<Goal Remaining Amount>";
            this.goalRemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoalEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 248);
            this.Controls.Add(this.goalRemainingLabel);
            this.Controls.Add(this.addToGoalButton);
            this.Controls.Add(this.goalNameLabel);
            this.Controls.Add(this.addAmount);
            this.Controls.Add(this.addAmountTextBox);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Name = "GoalEditForm";
            this.Text = "Goal Information";
            this.Load += new System.EventHandler(this.GoalEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox addAmountTextBox;
        private System.Windows.Forms.Label addAmount;
        private System.Windows.Forms.Label goalNameLabel;
        private System.Windows.Forms.Button addToGoalButton;
        private System.Windows.Forms.Label goalRemainingLabel;
    }
}