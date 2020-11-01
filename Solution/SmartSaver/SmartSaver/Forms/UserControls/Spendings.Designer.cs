namespace SmartSaver.Forms.UserControls
{
    partial class Spendings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spendings));
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.spendBalance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spendMoneyInput = new System.Windows.Forms.TextBox();
            this.createTransaction = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.createCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newCategoryInput = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentHistoryButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1280, 620);
            this.mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.spendBalance);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.spendMoneyInput);
            this.panel1.Controls.Add(this.createTransaction);
            this.panel1.Controls.Add(this.warningLabel);
            this.panel1.Controls.Add(this.createCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newCategoryInput);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.categoriesList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 620);
            this.panel1.TabIndex = 6;
            // 
            // spendBalance
            // 
            this.spendBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spendBalance.FormattingEnabled = true;
            this.spendBalance.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.spendBalance.Location = new System.Drawing.Point(901, 379);
            this.spendBalance.Name = "spendBalance";
            this.spendBalance.Size = new System.Drawing.Size(243, 23);
            this.spendBalance.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1156, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(901, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spend";
            // 
            // spendMoneyInput
            // 
            this.spendMoneyInput.Location = new System.Drawing.Point(901, 408);
            this.spendMoneyInput.Multiline = true;
            this.spendMoneyInput.Name = "spendMoneyInput";
            this.spendMoneyInput.Size = new System.Drawing.Size(243, 29);
            this.spendMoneyInput.TabIndex = 7;
            // 
            // createTransaction
            // 
            this.createTransaction.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.createTransaction.ForeColor = System.Drawing.Color.Snow;
            this.createTransaction.Location = new System.Drawing.Point(1043, 448);
            this.createTransaction.Name = "createTransaction";
            this.createTransaction.Size = new System.Drawing.Size(101, 30);
            this.createTransaction.TabIndex = 8;
            this.createTransaction.Text = "Enter";
            this.createTransaction.UseVisualStyleBackColor = false;
            this.createTransaction.Click += new System.EventHandler(this.createTransaction_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(0, 127);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(1280, 14);
            this.warningLabel.TabIndex = 3;
            this.warningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createCategory
            // 
            this.createCategory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.createCategory.ForeColor = System.Drawing.Color.Snow;
            this.createCategory.Location = new System.Drawing.Point(1043, 289);
            this.createCategory.Name = "createCategory";
            this.createCategory.Size = new System.Drawing.Size(101, 30);
            this.createCategory.TabIndex = 8;
            this.createCategory.Text = "Enter";
            this.createCategory.UseVisualStyleBackColor = false;
            this.createCategory.Click += new System.EventHandler(this.createCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(901, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add new";
            // 
            // newCategoryInput
            // 
            this.newCategoryInput.Location = new System.Drawing.Point(901, 253);
            this.newCategoryInput.Multiline = true;
            this.newCategoryInput.Name = "newCategoryInput";
            this.newCategoryInput.Size = new System.Drawing.Size(243, 29);
            this.newCategoryInput.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLabel.ForeColor = System.Drawing.Color.Black;
            this.categoryLabel.Location = new System.Drawing.Point(104, 157);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(165, 39);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Categories";
            // 
            // categoriesList
            // 
            this.categoriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Category});
            this.categoriesList.FullRowSelect = true;
            this.categoriesList.HideSelection = false;
            this.categoriesList.Location = new System.Drawing.Point(104, 211);
            this.categoriesList.MultiSelect = false;
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(772, 267);
            this.categoriesList.TabIndex = 4;
            this.categoriesList.UseCompatibleStateImageBehavior = false;
            this.categoriesList.View = System.Windows.Forms.View.Details;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.categoriesList_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 750;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.paymentHistoryButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 100);
            this.panel3.TabIndex = 0;
            // 
            // paymentHistoryButton
            // 
            this.paymentHistoryButton.BackColor = System.Drawing.Color.White;
            this.paymentHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentHistoryButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentHistoryButton.Image")));
            this.paymentHistoryButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.paymentHistoryButton.Location = new System.Drawing.Point(1069, 24);
            this.paymentHistoryButton.Name = "paymentHistoryButton";
            this.paymentHistoryButton.Size = new System.Drawing.Size(200, 50);
            this.paymentHistoryButton.TabIndex = 1;
            this.paymentHistoryButton.Text = "Payment History";
            this.paymentHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentHistoryButton.UseVisualStyleBackColor = false;
            this.paymentHistoryButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 100);
            this.panel2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Spendings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // Spendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.mainPanel);
            this.Name = "Spendings";
            this.Size = new System.Drawing.Size(1280, 620);
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
        private System.Windows.Forms.Button paymentHistoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView categoriesList;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.TextBox newCategoryInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createCategory;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spendMoneyInput;
        private System.Windows.Forms.Button createTransaction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ComboBox spendBalance;
    }
}
