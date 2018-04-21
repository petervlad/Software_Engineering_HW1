namespace tema1.Presentation
{
    partial class ManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CashierName = new System.Windows.Forms.TextBox();
            this.CashierPassword = new System.Windows.Forms.TextBox();
            this.ShowDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ShowArtists = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowSeats = new System.Windows.Forms.TextBox();
            this.CreateCashier = new System.Windows.Forms.Button();
            this.UpdateCashier = new System.Windows.Forms.Button();
            this.CreateEvent = new System.Windows.Forms.Button();
            this.UpdateEvent = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CashierId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EventId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // CashierName
            // 
            this.CashierName.Location = new System.Drawing.Point(12, 190);
            this.CashierName.Name = "CashierName";
            this.CashierName.Size = new System.Drawing.Size(233, 20);
            this.CashierName.TabIndex = 4;
            // 
            // CashierPassword
            // 
            this.CashierPassword.Location = new System.Drawing.Point(12, 264);
            this.CashierPassword.Name = "CashierPassword";
            this.CashierPassword.Size = new System.Drawing.Size(233, 20);
            this.CashierPassword.TabIndex = 5;
            // 
            // ShowDate
            // 
            this.ShowDate.Location = new System.Drawing.Point(346, 122);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.Size = new System.Drawing.Size(232, 20);
            this.ShowDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Artists";
            // 
            // ShowArtists
            // 
            this.ShowArtists.Location = new System.Drawing.Point(345, 190);
            this.ShowArtists.Name = "ShowArtists";
            this.ShowArtists.Size = new System.Drawing.Size(233, 20);
            this.ShowArtists.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of seats";
            // 
            // ShowSeats
            // 
            this.ShowSeats.Location = new System.Drawing.Point(344, 264);
            this.ShowSeats.Name = "ShowSeats";
            this.ShowSeats.Size = new System.Drawing.Size(233, 20);
            this.ShowSeats.TabIndex = 11;
            // 
            // CreateCashier
            // 
            this.CreateCashier.Location = new System.Drawing.Point(15, 336);
            this.CreateCashier.Name = "CreateCashier";
            this.CreateCashier.Size = new System.Drawing.Size(79, 51);
            this.CreateCashier.TabIndex = 12;
            this.CreateCashier.Text = "Create";
            this.CreateCashier.UseMnemonic = false;
            this.CreateCashier.UseVisualStyleBackColor = true;
            this.CreateCashier.Click += new System.EventHandler(this.CreateCashier_Click);
            // 
            // UpdateCashier
            // 
            this.UpdateCashier.Location = new System.Drawing.Point(166, 336);
            this.UpdateCashier.Name = "UpdateCashier";
            this.UpdateCashier.Size = new System.Drawing.Size(79, 51);
            this.UpdateCashier.TabIndex = 13;
            this.UpdateCashier.Text = "Update";
            this.UpdateCashier.UseVisualStyleBackColor = true;
            this.UpdateCashier.Click += new System.EventHandler(this.UpdateCashier_Click);
            // 
            // CreateEvent
            // 
            this.CreateEvent.Location = new System.Drawing.Point(344, 336);
            this.CreateEvent.Name = "CreateEvent";
            this.CreateEvent.Size = new System.Drawing.Size(76, 53);
            this.CreateEvent.TabIndex = 14;
            this.CreateEvent.Text = "Create";
            this.CreateEvent.UseVisualStyleBackColor = true;
            this.CreateEvent.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // UpdateEvent
            // 
            this.UpdateEvent.Location = new System.Drawing.Point(502, 338);
            this.UpdateEvent.Name = "UpdateEvent";
            this.UpdateEvent.Size = new System.Drawing.Size(75, 51);
            this.UpdateEvent.TabIndex = 15;
            this.UpdateEvent.Text = "Update";
            this.UpdateEvent.UseVisualStyleBackColor = true;
            this.UpdateEvent.Click += new System.EventHandler(this.UpdateEvent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Id";
            // 
            // CashierId
            // 
            this.CashierId.Location = new System.Drawing.Point(11, 122);
            this.CashierId.Name = "CashierId";
            this.CashierId.Size = new System.Drawing.Size(234, 20);
            this.CashierId.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Id:";
            // 
            // EventId
            // 
            this.EventId.Location = new System.Drawing.Point(373, 67);
            this.EventId.Name = "EventId";
            this.EventId.Size = new System.Drawing.Size(34, 20);
            this.EventId.TabIndex = 19;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 501);
            this.Controls.Add(this.EventId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CashierId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateEvent);
            this.Controls.Add(this.CreateEvent);
            this.Controls.Add(this.UpdateCashier);
            this.Controls.Add(this.CreateCashier);
            this.Controls.Add(this.ShowSeats);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShowArtists);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowDate);
            this.Controls.Add(this.CashierPassword);
            this.Controls.Add(this.CashierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CashierName;
        private System.Windows.Forms.TextBox CashierPassword;
        private System.Windows.Forms.DateTimePicker ShowDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShowArtists;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ShowSeats;
        private System.Windows.Forms.Button CreateCashier;
        private System.Windows.Forms.Button UpdateCashier;
        private System.Windows.Forms.Button CreateEvent;
        private System.Windows.Forms.Button UpdateEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CashierId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EventId;
    }
}