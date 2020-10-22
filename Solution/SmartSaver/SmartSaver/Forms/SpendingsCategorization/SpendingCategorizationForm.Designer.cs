namespace SmartSaver.Forms.SpendingsCategorization
{
    partial class SpendingCategorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpendingCategorizationForm));
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transportation_label = new System.Windows.Forms.Label();
            this.food_amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.paymentHistoryButton = new System.Windows.Forms.Button();
            this.spendButton = new System.Windows.Forms.Button();
            this.food_input = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(14, 147);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(131, 63);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.transportation_label);
            this.mainPanel.Controls.Add(this.food_amount);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.createCategoryButton);
            this.mainPanel.Controls.Add(this.textBox2);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.paymentHistoryButton);
            this.mainPanel.Controls.Add(this.spendButton);
            this.mainPanel.Controls.Add(this.food_input);
            this.mainPanel.Controls.Add(this.backButton);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1006, 653);
            this.mainPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(587, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(587, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entertainment";
            this.label2.Click += new System.EventHandler(this.transportation_label_Click);
            // 
            // transportation_label
            // 
            this.transportation_label.AutoSize = true;
            this.transportation_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.transportation_label.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transportation_label.Location = new System.Drawing.Point(188, 330);
            this.transportation_label.Name = "transportation_label";
            this.transportation_label.Size = new System.Drawing.Size(197, 35);
            this.transportation_label.TabIndex = 3;
            this.transportation_label.Text = "Transportation";
            this.transportation_label.Click += new System.EventHandler(this.transportation_label_Click);
            // 
            // food_amount
            // 
            this.food_amount.AutoSize = true;
            this.food_amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.food_amount.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.food_amount.Location = new System.Drawing.Point(587, 270);
            this.food_amount.Name = "food_amount";
            this.food_amount.Size = new System.Drawing.Size(123, 35);
            this.food_amount.TabIndex = 4;
            this.food_amount.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.BackColor = System.Drawing.Color.White;
            this.createCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCategoryButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("createCategoryButton.Image")));
            this.createCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createCategoryButton.Location = new System.Drawing.Point(188, 442);
            this.createCategoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(632, 62);
            this.createCategoryButton.TabIndex = 1;
            this.createCategoryButton.Text = "Add a new category";
            this.createCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createCategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createCategoryButton.UseVisualStyleBackColor = false;
            this.createCategoryButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(711, 386);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 40);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(711, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 40);
            this.textBox1.TabIndex = 5;
            // 
            // paymentHistoryButton
            // 
            this.paymentHistoryButton.BackColor = System.Drawing.Color.White;
            this.paymentHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentHistoryButton.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentHistoryButton.Image")));
            this.paymentHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paymentHistoryButton.Location = new System.Drawing.Point(768, 598);
            this.paymentHistoryButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentHistoryButton.Name = "paymentHistoryButton";
            this.paymentHistoryButton.Size = new System.Drawing.Size(226, 42);
            this.paymentHistoryButton.TabIndex = 1;
            this.paymentHistoryButton.Text = "Payment History";
            this.paymentHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentHistoryButton.UseVisualStyleBackColor = false;
            this.paymentHistoryButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // spendButton
            // 
            this.spendButton.BackColor = System.Drawing.Color.White;
            this.spendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendButton.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spendButton.Image = ((System.Drawing.Image)(resources.GetObject("spendButton.Image")));
            this.spendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spendButton.Location = new System.Drawing.Point(654, 598);
            this.spendButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spendButton.Name = "spendButton";
            this.spendButton.Size = new System.Drawing.Size(94, 42);
            this.spendButton.TabIndex = 1;
            this.spendButton.Text = "Spend";
            this.spendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spendButton.UseVisualStyleBackColor = false;
            this.spendButton.Click += new System.EventHandler(this.paymentHistoryButton_Click);
            // 
            // food_input
            // 
            this.food_input.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.food_input.Location = new System.Drawing.Point(711, 270);
            this.food_input.Name = "food_input";
            this.food_input.Size = new System.Drawing.Size(109, 40);
            this.food_input.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 520);
            this.panel1.TabIndex = 6;
            // 
            // SpendingCategorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1006, 653);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SpendingCategorizationForm";
            this.Text = "Smart Saver";
            this.Load += new System.EventHandler(this.SpendingCategorization_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paymentHistoryButton;
        private System.Windows.Forms.Button spendButton;
        private System.Windows.Forms.TextBox food_input;
        private System.Windows.Forms.Label food_amount;
        private System.Windows.Forms.Label transportation_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createCategoryButton;
        private System.Windows.Forms.Panel panel1;
    }
}