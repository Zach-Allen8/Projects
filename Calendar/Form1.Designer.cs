namespace Calendar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.CalendarLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addMode = new System.Windows.Forms.Button();
            this.viewMode = new System.Windows.Forms.Button();
            this.UpdateModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalendarLayout
            // 
            this.CalendarLayout.Location = new System.Drawing.Point(12, 175);
            this.CalendarLayout.Name = "CalendarLayout";
            this.CalendarLayout.Size = new System.Drawing.Size(1579, 734);
            this.CalendarLayout.TabIndex = 0;
            this.CalendarLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1460, 929);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 39);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1334, 929);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 39);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunday";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monday";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(506, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tuesday";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(717, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(967, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thursday";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1198, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1414, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 34);
            this.label7.TabIndex = 4;
            this.label7.Text = "Saturday";
            // 
            // LbDate
            // 
            this.LbDate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.Location = new System.Drawing.Point(269, 26);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(1036, 57);
            this.LbDate.TabIndex = 6;
            this.LbDate.Text = "MONTH YEAR";
            this.LbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbDate.Click += new System.EventHandler(this.label8_Click);
            // 
            // addMode
            // 
            this.addMode.Location = new System.Drawing.Point(296, 925);
            this.addMode.Name = "addMode";
            this.addMode.Size = new System.Drawing.Size(169, 46);
            this.addMode.TabIndex = 7;
            this.addMode.Text = "Click for Add Mode";
            this.addMode.UseVisualStyleBackColor = true;
            this.addMode.Click += new System.EventHandler(this.addMode_Click);
            // 
            // viewMode
            // 
            this.viewMode.Location = new System.Drawing.Point(511, 925);
            this.viewMode.Name = "viewMode";
            this.viewMode.Size = new System.Drawing.Size(169, 46);
            this.viewMode.TabIndex = 8;
            this.viewMode.Text = "Click for View/Delete Mode";
            this.viewMode.UseVisualStyleBackColor = true;
            this.viewMode.Click += new System.EventHandler(this.viewMode_Click);
            // 
            // UpdateModeLabel
            // 
            this.UpdateModeLabel.AutoSize = true;
            this.UpdateModeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateModeLabel.Location = new System.Drawing.Point(12, 932);
            this.UpdateModeLabel.Name = "UpdateModeLabel";
            this.UpdateModeLabel.Size = new System.Drawing.Size(85, 34);
            this.UpdateModeLabel.TabIndex = 9;
            this.UpdateModeLabel.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 997);
            this.Controls.Add(this.UpdateModeLabel);
            this.Controls.Add(this.viewMode);
            this.Controls.Add(this.addMode);
            this.Controls.Add(this.LbDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.CalendarLayout);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CalendarLayout;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addMode;
        private System.Windows.Forms.Button viewMode;
        private System.Windows.Forms.Label UpdateModeLabel;
    }
}

