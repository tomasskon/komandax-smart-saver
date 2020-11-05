using System.Drawing;
using System.Media;

namespace SmartSaver.Forms.UserControls
{
        partial class Balance
        {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
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
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Balance));
            this.BtEnter = new System.Windows.Forms.Button();
            this.CashBox = new System.Windows.Forms.TextBox();
            this.BankBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InputComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtEnter
            // 
            this.BtEnter.Location = new System.Drawing.Point(708, 422);
            this.BtEnter.Name = "BtEnter";
            this.BtEnter.Size = new System.Drawing.Size(75, 22);
            this.BtEnter.TabIndex = 2;
            this.BtEnter.Text = "Enter";
            this.BtEnter.UseVisualStyleBackColor = true;
            this.BtEnter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // CashBox
            // 
            this.CashBox.Location = new System.Drawing.Point(295, 212);
            this.CashBox.Multiline = true;
            this.CashBox.Name = "CashBox";
            this.CashBox.Size = new System.Drawing.Size(102, 31);
            this.CashBox.TabIndex = 3;
            this.CashBox.Text = "0,00 €";
            // 
            // BankBox
            // 
            this.BankBox.Location = new System.Drawing.Point(295, 255);
            this.BankBox.Multiline = true;
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(102, 31);
            this.BankBox.TabIndex = 4;
            this.BankBox.Text = "0,00 €";
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.SystemColors.Window;
            this.InputBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputBox.Location = new System.Drawing.Point(581, 423);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(121, 23);
            this.InputBox.TabIndex = 5;
            // 
            // InputComboBox
            // 
            this.InputComboBox.FormattingEnabled = true;
            this.InputComboBox.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.InputComboBox.Location = new System.Drawing.Point(581, 452);
            this.InputComboBox.Name = "InputComboBox";
            this.InputComboBox.Size = new System.Drawing.Size(121, 23);
            this.InputComboBox.TabIndex = 6;
            this.InputComboBox.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Card Balance";
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(295, 293);
            this.TotalBox.Multiline = true;
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(102, 31);
            this.TotalBox.TabIndex = 4;
            this.TotalBox.Text = "0,00 €";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(581, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter your balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtRefresh
            // 
            this.BtRefresh.Location = new System.Drawing.Point(708, 452);
            this.BtRefresh.Name = "BtRefresh";
            this.BtRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtRefresh.TabIndex = 11;
            this.BtRefresh.Text = "Refresh";
            this.BtRefresh.UseVisualStyleBackColor = true;
            this.BtRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputComboBox);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.CashBox);
            this.Controls.Add(this.BtEnter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Balance";
            this.Size = new System.Drawing.Size(1266, 703);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Button BtEnter;
            public System.Windows.Forms.TextBox CashBox;
            private System.Windows.Forms.TextBox BankBox;
            private System.Windows.Forms.TextBox InputBox;
            private System.Windows.Forms.ComboBox InputComboBox;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox TotalBox;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtRefresh;
    }
}
