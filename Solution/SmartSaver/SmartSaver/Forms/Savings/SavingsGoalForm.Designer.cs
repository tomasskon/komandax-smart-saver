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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goalLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(713, 75);
            this.panel1.TabIndex = 0;
            // 
            // addGoalButton
            // 
            this.addGoalButton.BackColor = System.Drawing.Color.White;
            this.addGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGoalButton.Location = new System.Drawing.Point(297, 8);
            this.addGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addGoalButton.Name = "addGoalButton";
            this.addGoalButton.Size = new System.Drawing.Size(145, 54);
            this.addGoalButton.TabIndex = 1;
            this.addGoalButton.Text = "Add Goal";
            this.addGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addGoalButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.addGoalButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 75);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(142, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "                  $";
            this.textBox1.Size = new System.Drawing.Size(133, 40);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.BackColor = System.Drawing.Color.Transparent;
            this.goalLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.goalLabel.Location = new System.Drawing.Point(57, 179);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(79, 35);
            this.goalLabel.TabIndex = 3;
            this.goalLabel.Text = "Goal:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(412, 122);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set Date:";
            // 
            // SavingsGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SavingsGoalForm";
            this.Text = "Enter your savings goal...";
            this.Load += new System.EventHandler(this.SavingsGoalForm_Load);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
    }
}