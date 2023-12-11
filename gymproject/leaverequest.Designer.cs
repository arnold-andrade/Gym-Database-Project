namespace gymproject
{
    partial class leaverequest
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
            this.startcalendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endcalendar = new System.Windows.Forms.MonthCalendar();
            this.Reason = new System.Windows.Forms.Label();
            this.leave_reason = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startcalendar
            // 
            this.startcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startcalendar.Location = new System.Drawing.Point(73, 91);
            this.startcalendar.Name = "startcalendar";
            this.startcalendar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "START DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "END DATE";
            // 
            // endcalendar
            // 
            this.endcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endcalendar.Location = new System.Drawing.Point(422, 91);
            this.endcalendar.Name = "endcalendar";
            this.endcalendar.TabIndex = 3;
            // 
            // Reason
            // 
            this.Reason.AutoSize = true;
            this.Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reason.Location = new System.Drawing.Point(131, 358);
            this.Reason.Name = "Reason";
            this.Reason.Size = new System.Drawing.Size(63, 17);
            this.Reason.TabIndex = 4;
            this.Reason.Text = "Reason";
            // 
            // leave_reason
            // 
            this.leave_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave_reason.Location = new System.Drawing.Point(212, 344);
            this.leave_reason.Multiline = true;
            this.leave_reason.Name = "leave_reason";
            this.leave_reason.Size = new System.Drawing.Size(423, 49);
            this.leave_reason.TabIndex = 5;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(414, 416);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 45);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(238, 416);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(96, 45);
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Controls.Add(this.leave_reason);
            this.groupBox1.Controls.Add(this.Reason);
            this.groupBox1.Controls.Add(this.endcalendar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startcalendar);
            this.groupBox1.Location = new System.Drawing.Point(80, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 486);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // leaverequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::gymproject.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(932, 542);
            this.Controls.Add(this.groupBox1);
            this.Name = "leaverequest";
            this.Text = "leaverequest";
            this.Load += new System.EventHandler(this.leaverequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar startcalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar endcalendar;
        private System.Windows.Forms.Label Reason;
        private System.Windows.Forms.TextBox leave_reason;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}