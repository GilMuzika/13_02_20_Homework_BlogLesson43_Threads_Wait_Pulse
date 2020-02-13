namespace _13_02_20_Homework_BlogLesson43_Threads_Wait_Pulse
{
    partial class MainForm
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.lblDisplayMessage = new System.Windows.Forms.Label();
            this.btnOvercomeTheLimit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(23, 59);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(150, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.Location = new System.Drawing.Point(23, 86);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(82, 23);
            this.btnAddMessage.TabIndex = 1;
            this.btnAddMessage.Text = "Add message";
            this.btnAddMessage.UseVisualStyleBackColor = true;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // lblDisplayMessage
            // 
            this.lblDisplayMessage.Location = new System.Drawing.Point(240, 13);
            this.lblDisplayMessage.Name = "lblDisplayMessage";
            this.lblDisplayMessage.Size = new System.Drawing.Size(274, 66);
            this.lblDisplayMessage.TabIndex = 2;
            this.lblDisplayMessage.Text = "label1";
            // 
            // btnOvercomeTheLimit
            // 
            this.btnOvercomeTheLimit.AutoSize = true;
            this.btnOvercomeTheLimit.Location = new System.Drawing.Point(243, 86);
            this.btnOvercomeTheLimit.Name = "btnOvercomeTheLimit";
            this.btnOvercomeTheLimit.Size = new System.Drawing.Size(104, 23);
            this.btnOvercomeTheLimit.TabIndex = 3;
            this.btnOvercomeTheLimit.Text = "Overcome the limit";
            this.btnOvercomeTheLimit.UseVisualStyleBackColor = true;
            this.btnOvercomeTheLimit.Click += new System.EventHandler(this.btnOvercomeTheLimit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 137);
            this.Controls.Add(this.btnOvercomeTheLimit);
            this.Controls.Add(this.lblDisplayMessage);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "13_02_20_Homework_BlogLesson43_Threads_Wait_Pulse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Label lblDisplayMessage;
        private System.Windows.Forms.Button btnOvercomeTheLimit;
    }
}

