﻿namespace SmartSaver.Forms.UserControls
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.paymentHistoryButton = new System.Windows.Forms.Button();
            this.spendButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transportation_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.food_amount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.food_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.transportation_label);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.createCategoryButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.food_amount);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.food_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 620);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(135)))));
            this.panel3.Controls.Add(this.paymentHistoryButton);
            this.panel3.Controls.Add(this.spendButton);
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
            // 
            // spendButton
            // 
            this.spendButton.BackColor = System.Drawing.Color.White;
            this.spendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spendButton.Image = ((System.Drawing.Image)(resources.GetObject("spendButton.Image")));
            this.spendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spendButton.Location = new System.Drawing.Point(939, 24);
            this.spendButton.Name = "spendButton";
            this.spendButton.Size = new System.Drawing.Size(101, 50);
            this.spendButton.TabIndex = 1;
            this.spendButton.Text = "Spend";
            this.spendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spendButton.UseVisualStyleBackColor = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(377, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entertainment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(724, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // transportation_label
            // 
            this.transportation_label.AutoSize = true;
            this.transportation_label.BackColor = System.Drawing.Color.Transparent;
            this.transportation_label.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transportation_label.Location = new System.Drawing.Point(377, 309);
            this.transportation_label.Name = "transportation_label";
            this.transportation_label.Size = new System.Drawing.Size(152, 27);
            this.transportation_label.TabIndex = 3;
            this.transportation_label.Text = "Transportation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(377, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(724, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.BackColor = System.Drawing.Color.White;
            this.createCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCategoryButton.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createCategoryButton.Image = ((System.Drawing.Image)(resources.GetObject("createCategoryButton.Image")));
            this.createCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createCategoryButton.Location = new System.Drawing.Point(320, 424);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(610, 63);
            this.createCategoryButton.TabIndex = 1;
            this.createCategoryButton.Text = "Add a new category";
            this.createCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createCategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createCategoryButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(834, 367);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 34);
            this.textBox2.TabIndex = 5;
            // 
            // food_amount
            // 
            this.food_amount.AutoSize = true;
            this.food_amount.BackColor = System.Drawing.Color.Transparent;
            this.food_amount.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.food_amount.Location = new System.Drawing.Point(724, 251);
            this.food_amount.Name = "food_amount";
            this.food_amount.Size = new System.Drawing.Size(95, 27);
            this.food_amount.TabIndex = 4;
            this.food_amount.Text = "Amount:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(834, 309);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 34);
            this.textBox1.TabIndex = 5;
            // 
            // food_input
            // 
            this.food_input.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.food_input.Location = new System.Drawing.Point(834, 248);
            this.food_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.food_input.Name = "food_input";
            this.food_input.Size = new System.Drawing.Size(96, 34);
            this.food_input.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(320, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(320, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(320, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
