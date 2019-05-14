namespace TestOutlookDemo
{
    partial class OutgoingPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AddAttachmentButton = new System.Windows.Forms.Button();
            this.attFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.AttachmentsTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AddAttachmentButton
            // 
            this.AddAttachmentButton.Location = new System.Drawing.Point(3, 3);
            this.AddAttachmentButton.Name = "AddAttachmentButton";
            this.AddAttachmentButton.Size = new System.Drawing.Size(117, 23);
            this.AddAttachmentButton.TabIndex = 0;
            this.AddAttachmentButton.Text = "Add Attachment";
            this.AddAttachmentButton.UseVisualStyleBackColor = true;
            this.AddAttachmentButton.Click += new System.EventHandler(this.AddAttachmentButton_Click);
            // 
            // attFileDialog
            // 
            this.attFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attachments";
            // 
            // AttachmentsTextBox
            // 
            this.AttachmentsTextBox.Location = new System.Drawing.Point(3, 69);
            this.AttachmentsTextBox.Multiline = true;
            this.AttachmentsTextBox.Name = "AttachmentsTextBox";
            this.AttachmentsTextBox.Size = new System.Drawing.Size(344, 228);
            this.AttachmentsTextBox.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(126, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(200, 8);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(0, 13);
            this.SecondsLabel.TabIndex = 4;
            // 
            // SaveTimer
            // 
            this.SaveTimer.Interval = 1000;
            this.SaveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // OutgoingPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AttachmentsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAttachmentButton);
            this.Name = "OutgoingPane";
            this.Size = new System.Drawing.Size(350, 300);
            this.Load += new System.EventHandler(this.OutgoingPane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAttachmentButton;
        private System.Windows.Forms.OpenFileDialog attFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AttachmentsTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SecondsLabel;
        private System.Windows.Forms.Timer SaveTimer;
    }
}
