namespace gymproject
{
    partial class dataview
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
            this.button1 = new System.Windows.Forms.Button();
            this.trainerdata = new System.Windows.Forms.CheckBox();
            this.memdata = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainercount = new System.Windows.Forms.Label();
            this.memcount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.trainerdata);
            this.groupBox1.Controls.Add(this.memdata);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trainercount);
            this.groupBox1.Controls.Add(this.memcount);
            this.groupBox1.Location = new System.Drawing.Point(69, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(628, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACCESS INFORMATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trainerdata
            // 
            this.trainerdata.AutoSize = true;
            this.trainerdata.Location = new System.Drawing.Point(349, 165);
            this.trainerdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainerdata.Name = "trainerdata";
            this.trainerdata.Size = new System.Drawing.Size(136, 20);
            this.trainerdata.TabIndex = 5;
            this.trainerdata.Text = "View Trainer Data";
            this.trainerdata.UseVisualStyleBackColor = true;
            // 
            // memdata
            // 
            this.memdata.AutoSize = true;
            this.memdata.Location = new System.Drawing.Point(132, 166);
            this.memdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memdata.Name = "memdata";
            this.memdata.Size = new System.Drawing.Size(143, 20);
            this.memdata.TabIndex = 4;
            this.memdata.Text = "View Member Data";
            this.memdata.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL TRAINERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL MEMBERS";
            // 
            // trainercount
            // 
            this.trainercount.AutoSize = true;
            this.trainercount.Location = new System.Drawing.Point(428, 66);
            this.trainercount.Name = "trainercount";
            this.trainercount.Size = new System.Drawing.Size(0, 16);
            this.trainercount.TabIndex = 1;
            // 
            // memcount
            // 
            this.memcount.AutoSize = true;
            this.memcount.Location = new System.Drawing.Point(136, 66);
            this.memcount.Name = "memcount";
            this.memcount.Size = new System.Drawing.Size(0, 16);
            this.memcount.TabIndex = 0;
            // 
            // dataview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::gymproject.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dataview";
            this.Text = "dataview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trainercount;
        private System.Windows.Forms.Label memcount;
        private System.Windows.Forms.CheckBox trainerdata;
        private System.Windows.Forms.CheckBox memdata;
        private System.Windows.Forms.Button button1;
    }
}