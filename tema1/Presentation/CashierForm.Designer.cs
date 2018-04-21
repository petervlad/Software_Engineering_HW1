namespace tema1
{
    partial class CashierForm
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
            this.Sell = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.concretId = new System.Windows.Forms.TextBox();
            this.concertSeat = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.ticketId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(201, 282);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(98, 52);
            this.Sell.TabIndex = 0;
            this.Sell.Text = "Sell Ticket";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(33, 282);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(98, 52);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update Ticket";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concert ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seat";
            // 
            // concretId
            // 
            this.concretId.Location = new System.Drawing.Point(47, 136);
            this.concretId.Name = "concretId";
            this.concretId.Size = new System.Drawing.Size(139, 20);
            this.concretId.TabIndex = 4;
            // 
            // concertSeat
            // 
            this.concertSeat.Location = new System.Drawing.Point(47, 194);
            this.concertSeat.Name = "concertSeat";
            this.concertSeat.Size = new System.Drawing.Size(138, 20);
            this.concertSeat.TabIndex = 5;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(253, 118);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(49, 13);
            this.text.TabIndex = 6;
            this.text.Text = "Ticket Id";
            // 
            // ticketId
            // 
            this.ticketId.Location = new System.Drawing.Point(252, 136);
            this.ticketId.Name = "ticketId";
            this.ticketId.Size = new System.Drawing.Size(121, 20);
            this.ticketId.TabIndex = 7;
            this.ticketId.TextChanged += new System.EventHandler(this.ticketId_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 139);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "SHow tickets for concert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ticketId);
            this.Controls.Add(this.text);
            this.Controls.Add(this.concertSeat);
            this.Controls.Add(this.concretId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Sell);
            this.Name = "CashierForm";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox concretId;
        private System.Windows.Forms.TextBox concertSeat;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox ticketId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}