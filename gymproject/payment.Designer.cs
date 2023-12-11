namespace gymproject
{
    partial class payment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.upi = new System.Windows.Forms.RadioButton();
            this.card = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.upiid = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.Label();
            this.cardholdername = new System.Windows.Forms.Label();
            this.expiry = new System.Windows.Forms.Label();
            this.cardno = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upi);
            this.groupBox1.Controls.Add(this.card);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.upiid);
            this.groupBox1.Controls.Add(this.cvv);
            this.groupBox1.Controls.Add(this.cardholdername);
            this.groupBox1.Controls.Add(this.expiry);
            this.groupBox1.Controls.Add(this.cardno);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(164, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(449, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // upi
            // 
            this.upi.AutoSize = true;
            this.upi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upi.Location = new System.Drawing.Point(76, 229);
            this.upi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upi.Name = "upi";
            this.upi.Size = new System.Drawing.Size(56, 22);
            this.upi.TabIndex = 15;
            this.upi.TabStop = true;
            this.upi.Text = "UPI";
            this.upi.UseVisualStyleBackColor = true;
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card.Location = new System.Drawing.Point(76, 74);
            this.card.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(65, 22);
            this.card.TabIndex = 14;
            this.card.TabStop = true;
            this.card.Text = "Card";
            this.card.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(261, 333);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Pay";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(99, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // upiid
            // 
            this.upiid.AutoSize = true;
            this.upiid.Location = new System.Drawing.Point(76, 261);
            this.upiid.Name = "upiid";
            this.upiid.Size = new System.Drawing.Size(144, 16);
            this.upiid.TabIndex = 11;
            this.upiid.Text = "UPI ID/ Mobile Number";
            // 
            // cvv
            // 
            this.cvv.AutoSize = true;
            this.cvv.Location = new System.Drawing.Point(258, 110);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(34, 16);
            this.cvv.TabIndex = 9;
            this.cvv.Text = "CVV";
            // 
            // cardholdername
            // 
            this.cardholdername.AutoSize = true;
            this.cardholdername.Location = new System.Drawing.Point(76, 166);
            this.cardholdername.Name = "cardholdername";
            this.cardholdername.Size = new System.Drawing.Size(130, 16);
            this.cardholdername.TabIndex = 8;
            this.cardholdername.Text = "Card Holder\'s Name";
            // 
            // expiry
            // 
            this.expiry.AutoSize = true;
            this.expiry.Location = new System.Drawing.Point(258, 166);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(44, 16);
            this.expiry.TabIndex = 7;
            this.expiry.Text = "Expiry";
            // 
            // cardno
            // 
            this.cardno.AutoSize = true;
            this.cardno.Location = new System.Drawing.Point(76, 110);
            this.cardno.Name = "cardno";
            this.cardno.Size = new System.Drawing.Size(87, 16);
            this.cardno.TabIndex = 6;
            this.cardno.Text = "Card Number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(80, 279);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(89, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 130);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(261, 130);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 22);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 190);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 190);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Payment Portal";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::gymproject.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(771, 508);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label upiid;
        private System.Windows.Forms.Label cvv;
        private System.Windows.Forms.Label cardholdername;
        private System.Windows.Forms.Label expiry;
        private System.Windows.Forms.Label cardno;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton upi;
        private System.Windows.Forms.RadioButton card;
    }
}