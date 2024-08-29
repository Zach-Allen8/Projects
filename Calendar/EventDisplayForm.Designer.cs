namespace Calendar
{
    partial class EventDisplayForm
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
            this.dayEvents = new System.Windows.Forms.Button();
            this.monthEvents = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.editEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayEvents
            // 
            this.dayEvents.Location = new System.Drawing.Point(29, 340);
            this.dayEvents.MaximumSize = new System.Drawing.Size(169, 46);
            this.dayEvents.MinimumSize = new System.Drawing.Size(169, 46);
            this.dayEvents.Name = "dayEvents";
            this.dayEvents.Size = new System.Drawing.Size(169, 46);
            this.dayEvents.TabIndex = 1;
            this.dayEvents.Text = "Display Current Day Events";
            this.dayEvents.UseVisualStyleBackColor = true;
            this.dayEvents.Click += new System.EventHandler(this.dayEvents_Click);
            // 
            // monthEvents
            // 
            this.monthEvents.Location = new System.Drawing.Point(29, 273);
            this.monthEvents.Name = "monthEvents";
            this.monthEvents.Size = new System.Drawing.Size(169, 46);
            this.monthEvents.TabIndex = 2;
            this.monthEvents.Text = "Display Current Monthly Events";
            this.monthEvents.UseVisualStyleBackColor = true;
            this.monthEvents.Click += new System.EventHandler(this.monthEvents_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 228);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(503, 340);
            this.deleteEvent.MaximumSize = new System.Drawing.Size(169, 46);
            this.deleteEvent.MinimumSize = new System.Drawing.Size(169, 46);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(169, 46);
            this.deleteEvent.TabIndex = 4;
            this.deleteEvent.Text = "Delete Selected Event";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // editEvent
            // 
            this.editEvent.Location = new System.Drawing.Point(503, 273);
            this.editEvent.MaximumSize = new System.Drawing.Size(169, 46);
            this.editEvent.MinimumSize = new System.Drawing.Size(169, 46);
            this.editEvent.Name = "editEvent";
            this.editEvent.Size = new System.Drawing.Size(169, 46);
            this.editEvent.TabIndex = 5;
            this.editEvent.Text = "Edit Selected Event";
            this.editEvent.UseVisualStyleBackColor = true;
            this.editEvent.Click += new System.EventHandler(this.editEvent_Click);
            // 
            // EventDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 409);
            this.Controls.Add(this.editEvent);
            this.Controls.Add(this.deleteEvent);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthEvents);
            this.Controls.Add(this.dayEvents);
            this.Name = "EventDisplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Manager";
            this.Load += new System.EventHandler(this.EventDisplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dayEvents;
        private System.Windows.Forms.Button monthEvents;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button editEvent;
    }
}