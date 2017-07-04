namespace GVConverter.Froms
{
    partial class messageWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBox = new System.Windows.Forms.Button();
            this.textBoxSystemMessages = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 51);
            this.panel1.TabIndex = 1;
            // 
            // clearBox
            // 
            this.clearBox.Location = new System.Drawing.Point(12, 7);
            this.clearBox.Name = "clearBox";
            this.clearBox.Size = new System.Drawing.Size(73, 32);
            this.clearBox.TabIndex = 0;
            this.clearBox.Text = "Clear";
            this.clearBox.UseVisualStyleBackColor = true;
            this.clearBox.Click += new System.EventHandler(this.clearBox_Click);
            // 
            // textBoxSystemMessages
            // 
            this.textBoxSystemMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSystemMessages.Location = new System.Drawing.Point(0, 51);
            this.textBoxSystemMessages.Multiline = true;
            this.textBoxSystemMessages.Name = "textBoxSystemMessages";
            this.textBoxSystemMessages.ReadOnly = true;
            this.textBoxSystemMessages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSystemMessages.Size = new System.Drawing.Size(583, 359);
            this.textBoxSystemMessages.TabIndex = 3;
            this.textBoxSystemMessages.Text = "Message Window....\r\n============================";
            // 
            // messageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 410);
            this.Controls.Add(this.textBoxSystemMessages);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "messageWindow";
            this.Text = "System Messages";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearBox;
        public System.Windows.Forms.TextBox textBoxSystemMessages;
    }
}