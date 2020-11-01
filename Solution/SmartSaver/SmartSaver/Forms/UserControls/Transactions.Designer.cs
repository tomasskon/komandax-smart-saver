namespace SmartSaver.Forms.UserControls
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this._transactions = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Category = new System.Windows.Forms.ColumnHeader();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.BalanceType = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.CreatedAt = new System.Windows.Forms.ColumnHeader();
            this._loadData = new System.Windows.Forms.Button();
            this._sortColumn = new System.Windows.Forms.ComboBox();
            this._sortDirection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _transactions
            // 
            this._transactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Category,
            this.Amount,
            this.BalanceType,
            this.Description,
            this.CreatedAt});
            this._transactions.FullRowSelect = true;
            this._transactions.HideSelection = false;
            this._transactions.Location = new System.Drawing.Point(132, 116);
            this._transactions.Name = "_transactions";
            this._transactions.Size = new System.Drawing.Size(1015, 389);
            this._transactions.TabIndex = 0;
            this._transactions.UseCompatibleStateImageBehavior = false;
            this._transactions.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Category
            // 
            this.Category.Text = "Category Name";
            this.Category.Width = 150;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // BalanceType
            // 
            this.BalanceType.Text = "Balance";
            this.BalanceType.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 450;
            // 
            // CreatedAt
            // 
            this.CreatedAt.Text = "Created At";
            this.CreatedAt.Width = 150;
            // 
            // _loadData
            // 
            this._loadData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_loadData.BackgroundImage")));
            this._loadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._loadData.Location = new System.Drawing.Point(611, 20);
            this._loadData.Name = "_loadData";
            this._loadData.Size = new System.Drawing.Size(47, 48);
            this._loadData.TabIndex = 1;
            this._loadData.UseVisualStyleBackColor = true;
            this._loadData.Click += new System.EventHandler(this._loadData_Click);
            // 
            // _sortColumn
            // 
            this._sortColumn.DisplayMember = "Value";
            this._sortColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sortColumn.FormattingEnabled = true;
            this._sortColumn.Location = new System.Drawing.Point(897, 70);
            this._sortColumn.Name = "_sortColumn";
            this._sortColumn.Size = new System.Drawing.Size(121, 23);
            this._sortColumn.TabIndex = 2;
            this._sortColumn.ValueMember = "Key";
            this._sortColumn.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // _sortDirection
            // 
            this._sortDirection.DisplayMember = "Value";
            this._sortDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._sortDirection.FormattingEnabled = true;
            this._sortDirection.Location = new System.Drawing.Point(1025, 70);
            this._sortDirection.Name = "_sortDirection";
            this._sortDirection.Size = new System.Drawing.Size(116, 23);
            this._sortDirection.TabIndex = 4;
            this._sortDirection.ValueMember = "Key";
            this._sortDirection.SelectedIndexChanged += new System.EventHandler(this._sort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transactions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this._sortDirection);
            this.panel1.Controls.Add(this._sortColumn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel2.Controls.Add(this._loadData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 100);
            this.panel2.TabIndex = 0;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this._transactions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1280, 620);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _transactions;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button _loadData;
        private System.Windows.Forms.ComboBox _sortColumn;
        private System.Windows.Forms.ComboBox _sortDirection;
        private System.Windows.Forms.ColumnHeader CreatedAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader BalanceType;
    }
}
