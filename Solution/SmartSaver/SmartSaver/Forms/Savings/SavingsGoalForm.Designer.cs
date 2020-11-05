namespace SmartSaver.Forms.Savings
{
    partial class SavingsGoalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsGoalForm));
            this.enterSavingsGoalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addGoalButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.goalAmountTextBox = new System.Windows.Forms.TextBox();
            this.goalLabel = new System.Windows.Forms.Label();
            this.endDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goalNameTextBox = new System.Windows.Forms.TextBox();
            this.goalDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterSavingsGoalLabel
            // 
            this.enterSavingsGoalLabel.AutoSize = true;
            this.enterSavingsGoalLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterSavingsGoalLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterSavingsGoalLabel.ForeColor = System.Drawing.Color.White;
            this.enterSavingsGoalLabel.Location = new System.Drawing.Point(12, 18);
            this.enterSavingsGoalLabel.Name = "enterSavingsGoalLabel";
            this.enterSavingsGoalLabel.Size = new System.Drawing.Size(311, 35);
            this.enterSavingsGoalLabel.TabIndex = 3;
            this.enterSavingsGoalLabel.Text = "Enter you savings goal...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.enterSavingsGoalLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 75);
            this.panel1.TabIndex = 0;
            // 
            // addGoalButton
            // 
            this.addGoalButton.BackColor = System.Drawing.Color.White;
            this.addGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGoalButton.Location = new System.Drawing.Point(353, 8);
            this.addGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addGoalButton.Name = "addGoalButton";
            this.addGoalButton.Size = new System.Drawing.Size(145, 54);
            this.addGoalButton.TabIndex = 1;
            this.addGoalButton.Text = "Add Goal";
            this.addGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addGoalButton.UseVisualStyleBackColor = false;
            this.addGoalButton.Click += new System.EventHandler(this.addGoalButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.addGoalButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 75);
            this.panel2.TabIndex = 0;
            // 
            // goalAmountTextBox
            // 
            this.goalAmountTextBox.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.goalAmountTextBox.Location = new System.Drawing.Point(172, 298);
            this.goalAmountTextBox.Name = "goalAmountTextBox";
            this.goalAmountTextBox.PlaceholderText = "                  $";
            this.goalAmountTextBox.Size = new System.Drawing.Size(133, 40);
            this.goalAmountTextBox.TabIndex = 5;
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalLabel.Location = new System.Drawing.Point(83, 301);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(79, 35);
            this.goalLabel.TabIndex = 3;
            this.goalLabel.Text = "Goal:";
            // 
            // endDateCalendar
            // 
            this.endDateCalendar.Location = new System.Drawing.Point(535, 163);
            this.endDateCalendar.MaxSelectionCount = 1;
            this.endDateCalendar.Name = "endDateCalendar";
            this.endDateCalendar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(583, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set Goal Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // goalNameTextBox
            // 
            this.goalNameTextBox.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.goalNameTextBox.Location = new System.Drawing.Point(172, 119);
            this.goalNameTextBox.Name = "goalNameTextBox";
            this.goalNameTextBox.PlaceholderText = "Enter goal name...";
            this.goalNameTextBox.Size = new System.Drawing.Size(228, 40);
            this.goalNameTextBox.TabIndex = 5;
            // 
            // goalDescriptionTextBox
            // 
            this.goalDescriptionTextBox.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.goalDescriptionTextBox.Location = new System.Drawing.Point(172, 190);
            this.goalDescriptionTextBox.Multiline = true;
            this.goalDescriptionTextBox.Name = "goalDescriptionTextBox";
            this.goalDescriptionTextBox.PlaceholderText = "Enter a description...";
            this.goalDescriptionTextBox.Size = new System.Drawing.Size(262, 85);
            this.goalDescriptionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // SavingsGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goalDescriptionTextBox);
            this.Controls.Add(this.goalNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDateCalendar);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.goalAmountTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SavingsGoalForm";
            this.Text = "Enter your savings goal...";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSavingsGoalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addGoalButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox goalAmountTextBox;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.MonthCalendar endDateCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox goalNameTextBox;
        private System.Windows.Forms.TextBox goalDescriptionTextBox;
        private System.Windows.Forms.Label label3;
    }
}