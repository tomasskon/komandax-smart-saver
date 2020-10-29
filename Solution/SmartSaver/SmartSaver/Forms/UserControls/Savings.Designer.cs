namespace SmartSaver.Forms.UserControls
{
    partial class Savings
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


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Savings));
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.financialPlanLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.savingsList = new System.Windows.Forms.ListView();
            this.goalName = new System.Windows.Forms.ColumnHeader();
            this.moneyAmount = new System.Windows.Forms.ColumnHeader();
            this.startedDate = new System.Windows.Forms.ColumnHeader();
            this.progressAmount = new System.Windows.Forms.ColumnHeader();
            this.progressPercentage = new System.Windows.Forms.ColumnHeader();
            this.finishDate = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generatePlanButton = new System.Windows.Forms.Button();
            this.createGoalButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.descriptionColumn = new System.Windows.Forms.ColumnHeader();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1463, 827);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.financialPlanLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.savingsList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 827);
            this.panel1.TabIndex = 6;
            // 
            // financialPlanLabel
            // 
            this.financialPlanLabel.AutoSize = true;
            this.financialPlanLabel.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.financialPlanLabel.Location = new System.Drawing.Point(1162, 364);
            this.financialPlanLabel.Name = "financialPlanLabel";
            this.financialPlanLabel.Size = new System.Drawing.Size(267, 35);
            this.financialPlanLabel.TabIndex = 7;
            this.financialPlanLabel.Text = "<financialPlanResult>";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(535, 151);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Reload";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // savingsList
            // 
            this.savingsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.goalName,
            this.descriptionColumn,
            this.moneyAmount,
            this.startedDate,
            this.progressAmount,
            this.progressPercentage,
            this.finishDate});
            this.savingsList.FullRowSelect = true;
            this.savingsList.HideSelection = false;
            this.savingsList.Location = new System.Drawing.Point(140, 213);
            this.savingsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savingsList.Name = "savingsList";
            this.savingsList.Size = new System.Drawing.Size(935, 473);
            this.savingsList.TabIndex = 0;
            this.savingsList.UseCompatibleStateImageBehavior = false;
            this.savingsList.View = System.Windows.Forms.View.Details;
            // 
            // goalName
            // 
            this.goalName.Text = "Goal Name";
            this.goalName.Width = 150;
            // 
            // moneyAmount
            // 
            this.moneyAmount.Text = "Amount";
            this.moneyAmount.Width = 100;
            // 
            // startedDate
            // 
            this.startedDate.Text = "Started";
            this.startedDate.Width = 120;
            // 
            // progressAmount
            // 
            this.progressAmount.Text = "Progress";
            this.progressAmount.Width = 120;
            // 
            // progressPercentage
            // 
            this.progressPercentage.Text = "Progress (%)";
            this.progressPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.progressPercentage.Width = 120;
            // 
            // finishDate
            // 
            this.finishDate.Text = "Goal Ends";
            this.finishDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishDate.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.generatePlanButton);
            this.panel3.Controls.Add(this.createGoalButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 694);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 133);
            this.panel3.TabIndex = 0;
            // 
            // generatePlanButton
            // 
            this.generatePlanButton.BackColor = System.Drawing.Color.White;
            this.generatePlanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePlanButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generatePlanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generatePlanButton.Location = new System.Drawing.Point(1158, 16);
            this.generatePlanButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generatePlanButton.Name = "generatePlanButton";
            this.generatePlanButton.Size = new System.Drawing.Size(271, 92);
            this.generatePlanButton.TabIndex = 1;
            this.generatePlanButton.Text = "Generate Financial Plan";
            this.generatePlanButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.generatePlanButton.UseVisualStyleBackColor = false;
            // 
            // createGoalButton
            // 
            this.createGoalButton.BackColor = System.Drawing.Color.White;
            this.createGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createGoalButton.Location = new System.Drawing.Point(463, 25);
            this.createGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createGoalButton.Name = "createGoalButton";
            this.createGoalButton.Size = new System.Drawing.Size(271, 54);
            this.createGoalButton.TabIndex = 1;
            this.createGoalButton.Text = "Create a new Goal...";
            this.createGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createGoalButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1463, 133);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 49);
            this.label5.TabIndex = 3;
            this.label5.Text = "Savings Goals";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "columnHeader1";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "columnHeader2";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Created At";
            this.columnHeader3.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(933, 169);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Key";
            //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "Value";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(779, 169);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Key";
            //this.comboBox2.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.Width = 200;
            // 
            // Savings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Savings";
            this.Size = new System.Drawing.Size(1463, 827);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView savingsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button createGoalButton;
        private System.Windows.Forms.ColumnHeader goalName;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader moneyAmount;
        private System.Windows.Forms.ColumnHeader startedDate;
        private System.Windows.Forms.ColumnHeader progressAmount;
        private System.Windows.Forms.ColumnHeader progressPercentage;
        private System.Windows.Forms.ColumnHeader finishDate;
        private System.Windows.Forms.Label financialPlanLabel;
        private System.Windows.Forms.Button generatePlanButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
    }
}
