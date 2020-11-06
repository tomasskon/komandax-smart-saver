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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._sortColumn = new System.Windows.Forms.ComboBox();
            this._sortDirection = new System.Windows.Forms.ComboBox();
            this.reloadSavingsButton = new System.Windows.Forms.Button();
            this.savingGoalsList = new System.Windows.Forms.ListView();
            this.goalName = new System.Windows.Forms.ColumnHeader();
            this.descriptionColumn = new System.Windows.Forms.ColumnHeader();
            this.moneyAmount = new System.Windows.Forms.ColumnHeader();
            this.startedDate = new System.Windows.Forms.ColumnHeader();
            this.progressAmount = new System.Windows.Forms.ColumnHeader();
            this.progressPercentage = new System.Windows.Forms.ColumnHeader();
            this.goalEnds = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.editGoalButton = new System.Windows.Forms.Button();
            this.removeGoalButton = new System.Windows.Forms.Button();
            this.createGoalButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
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
            this.panel1.Controls.Add(this._sortColumn);
            this.panel1.Controls.Add(this._sortDirection);
            this.panel1.Controls.Add(this.reloadSavingsButton);
            this.panel1.Controls.Add(this.savingGoalsList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 827);
            this.panel1.TabIndex = 6;
            // 
            // _sortColumn
            // 
            this._sortColumn.DisplayMember = "Value";
            this._sortColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sortColumn.FormattingEnabled = true;
            this._sortColumn.Location = new System.Drawing.Point(916, 169);
            this._sortColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._sortColumn.Name = "_sortColumn";
            this._sortColumn.Size = new System.Drawing.Size(138, 28);
            this._sortColumn.TabIndex = 2;
            this._sortColumn.ValueMember = "Key";
            this._sortColumn.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // _sortDirection
            // 
            this._sortDirection.DisplayMember = "Value";
            this._sortDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sortDirection.FormattingEnabled = true;
            this._sortDirection.Location = new System.Drawing.Point(1070, 169);
            this._sortDirection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._sortDirection.Name = "_sortDirection";
            this._sortDirection.Size = new System.Drawing.Size(132, 28);
            this._sortDirection.TabIndex = 4;
            this._sortDirection.ValueMember = "Key";
            this._sortDirection.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // reloadSavingsButton
            // 
            this.reloadSavingsButton.BackColor = System.Drawing.Color.White;
            this.reloadSavingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadSavingsButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadSavingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reloadSavingsButton.Location = new System.Drawing.Point(672, 151);
            this.reloadSavingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reloadSavingsButton.Name = "reloadSavingsButton";
            this.reloadSavingsButton.Size = new System.Drawing.Size(145, 54);
            this.reloadSavingsButton.TabIndex = 1;
            this.reloadSavingsButton.Text = "Reload";
            this.reloadSavingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reloadSavingsButton.UseVisualStyleBackColor = false;
            this.reloadSavingsButton.Click += new System.EventHandler(this.ReloadSavingsButton_Click);
            // 
            // savingGoalsList
            // 
            this.savingGoalsList.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.savingGoalsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.goalName,
            this.descriptionColumn,
            this.moneyAmount,
            this.startedDate,
            this.progressAmount,
            this.progressPercentage,
            this.goalEnds,
            this.id});
            this.savingGoalsList.FullRowSelect = true;
            this.savingGoalsList.GridLines = true;
            this.savingGoalsList.HideSelection = false;
            this.savingGoalsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.savingGoalsList.Location = new System.Drawing.Point(277, 213);
            this.savingGoalsList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savingGoalsList.Name = "savingGoalsList";
            this.savingGoalsList.Size = new System.Drawing.Size(935, 473);
            this.savingGoalsList.TabIndex = 0;
            this.savingGoalsList.UseCompatibleStateImageBehavior = false;
            this.savingGoalsList.View = System.Windows.Forms.View.Details;
            // 
            // goalName
            // 
            this.goalName.Text = "Goal Name";
            this.goalName.Width = 150;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Text = "Description";
            this.descriptionColumn.Width = 200;
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
            // goalEnds
            // 
            this.goalEnds.Text = "Goal Ends";
            this.goalEnds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.goalEnds.Width = 120;
            // 
            // id
            // 
            this.id.Text = "";
            this.id.Width = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.editGoalButton);
            this.panel3.Controls.Add(this.removeGoalButton);
            this.panel3.Controls.Add(this.createGoalButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 694);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1463, 133);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // editGoalButton
            // 
            this.editGoalButton.BackColor = System.Drawing.Color.White;
            this.editGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editGoalButton.Location = new System.Drawing.Point(609, 19);
            this.editGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editGoalButton.Name = "editGoalButton";
            this.editGoalButton.Size = new System.Drawing.Size(271, 54);
            this.editGoalButton.TabIndex = 1;
            this.editGoalButton.Text = "Add funds";
            this.editGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editGoalButton.UseVisualStyleBackColor = false;
            this.editGoalButton.Click += new System.EventHandler(this.editGoalButton_Click);
            // 
            // removeGoalButton
            // 
            this.removeGoalButton.BackColor = System.Drawing.Color.White;
            this.removeGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeGoalButton.Location = new System.Drawing.Point(941, 19);
            this.removeGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeGoalButton.Name = "removeGoalButton";
            this.removeGoalButton.Size = new System.Drawing.Size(271, 54);
            this.removeGoalButton.TabIndex = 1;
            this.removeGoalButton.Text = "Remove Goal";
            this.removeGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeGoalButton.UseVisualStyleBackColor = false;
            this.removeGoalButton.Click += new System.EventHandler(this.removeGoalButton_Click);
            // 
            // createGoalButton
            // 
            this.createGoalButton.BackColor = System.Drawing.Color.White;
            this.createGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGoalButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createGoalButton.Location = new System.Drawing.Point(277, 19);
            this.createGoalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createGoalButton.Name = "createGoalButton";
            this.createGoalButton.Size = new System.Drawing.Size(271, 54);
            this.createGoalButton.TabIndex = 1;
            this.createGoalButton.Text = "Create a new Goal...";
            this.createGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createGoalButton.UseVisualStyleBackColor = false;
            this.createGoalButton.Click += new System.EventHandler(this.createGoalButton_Click);
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
            this.label5.Size = new System.Drawing.Size(243, 49);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saving Goals";
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
        private System.Windows.Forms.ListView savingGoalsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button reloadSavingsButton;
        private System.Windows.Forms.Button createGoalButton;
        private System.Windows.Forms.ColumnHeader GoalName;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader moneyAmount;
        private System.Windows.Forms.ColumnHeader startedAt;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader progressPercentage;
        private System.Windows.Forms.ColumnHeader endsAt;
        private System.Windows.Forms.ComboBox _sortColumn;
        private System.Windows.Forms.ComboBox _sortDirection;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Button removeGoalButton;
        private System.Windows.Forms.Button v;
        private System.Windows.Forms.Button editGoalButton;
        private System.Windows.Forms.ColumnHeader goalName;
        private System.Windows.Forms.ColumnHeader descriptionColumn;
        private System.Windows.Forms.ColumnHeader startedDate;
        private System.Windows.Forms.ColumnHeader goalEnds;
        private System.Windows.Forms.ColumnHeader progressAmount;
        private System.Windows.Forms.ColumnHeader id;
    }
}
