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
            this._transactions = new System.Windows.Forms.ListView();
            this.Amount = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this._loadData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _transactions
            // 
            this._transactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Description});
            this._transactions.HideSelection = false;
            this._transactions.Location = new System.Drawing.Point(84, 93);
            this._transactions.Name = "_transactions";
            this._transactions.Size = new System.Drawing.Size(1007, 464);
            this._transactions.TabIndex = 0;
            this._transactions.UseCompatibleStateImageBehavior = false;
            this._transactions.View = System.Windows.Forms.View.Details;
            this._transactions.SelectedIndexChanged += new System.EventHandler(this._transactions_SelectedIndexChanged);
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 150;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 150;
            // 
            // _loadData
            // 
            this._loadData.Location = new System.Drawing.Point(84, 56);
            this._loadData.Name = "_loadData";
            this._loadData.Size = new System.Drawing.Size(75, 23);
            this._loadData.TabIndex = 1;
            this._loadData.Text = "Load Data";
            this._loadData.UseVisualStyleBackColor = true;
            this._loadData.Click += new System.EventHandler(this._loadData_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._loadData);
            this.Controls.Add(this._transactions);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1280, 620);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _transactions;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button _loadData;
    }
}
