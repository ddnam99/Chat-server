namespace ClientGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Connect = new System.Windows.Forms.Button();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_Sent = new System.Windows.Forms.Button();
            this.TB_MessageSent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Messages = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 410);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RTB_Messages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 317);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BT_Connect);
            this.panel2.Controls.Add(this.TB_IP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 32);
            this.panel2.TabIndex = 0;
            // 
            // BT_Connect
            // 
            this.BT_Connect.Location = new System.Drawing.Point(236, 4);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(75, 23);
            this.BT_Connect.TabIndex = 1;
            this.BT_Connect.Text = "Connect";
            this.BT_Connect.UseVisualStyleBackColor = true;
            this.BT_Connect.Click += new System.EventHandler(this.BT_Connect_Click);
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(60, 6);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(170, 20);
            this.TB_IP.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BT_Sent);
            this.panel3.Controls.Add(this.TB_MessageSent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 43);
            this.panel3.TabIndex = 0;
            // 
            // BT_Sent
            // 
            this.BT_Sent.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_Sent.Enabled = false;
            this.BT_Sent.Location = new System.Drawing.Point(449, 0);
            this.BT_Sent.Name = "BT_Sent";
            this.BT_Sent.Size = new System.Drawing.Size(75, 43);
            this.BT_Sent.TabIndex = 3;
            this.BT_Sent.Text = "Sent";
            this.BT_Sent.UseVisualStyleBackColor = true;
            this.BT_Sent.Click += new System.EventHandler(this.BT_Sent_Click);
            // 
            // TB_MessageSent
            // 
            this.TB_MessageSent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_MessageSent.Enabled = false;
            this.TB_MessageSent.Location = new System.Drawing.Point(3, 3);
            this.TB_MessageSent.Multiline = true;
            this.TB_MessageSent.Name = "TB_MessageSent";
            this.TB_MessageSent.Size = new System.Drawing.Size(443, 37);
            this.TB_MessageSent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Server";
            // 
            // RTB_Messages
            // 
            this.RTB_Messages.CausesValidation = false;
            this.RTB_Messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Messages.EnableAutoDragDrop = true;
            this.RTB_Messages.Location = new System.Drawing.Point(0, 0);
            this.RTB_Messages.Name = "RTB_Messages";
            this.RTB_Messages.ReadOnly = true;
            this.RTB_Messages.Size = new System.Drawing.Size(524, 317);
            this.RTB_Messages.TabIndex = 0;
            this.RTB_Messages.TabStop = false;
            this.RTB_Messages.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Client </> Double D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_Connect;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Button BT_Sent;
        private System.Windows.Forms.TextBox TB_MessageSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_Messages;
    }
}

