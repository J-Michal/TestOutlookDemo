using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TestOutlookDemo
{
    public partial class OutgoingPane : UserControl
    {
        public OutgoingPane()
        {
            InitializeComponent();
        }

        private void OutgoingPane_Load(object sender, EventArgs e)
        {
            ClearTimer();
            InitializeAttachments();
        }

        private void InitializeAttachments()
        {
            Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
            Outlook.MailItem mail = inspector.CurrentItem;
            try
            {
                if (mail.Attachments == null || mail.Attachments.Count <= 0)
                {
                    return;
                }

                foreach (Outlook.Attachment attachment in mail.Attachments)
                {
                    AttachmentsTextBox.Text = $"{AttachmentsTextBox.Text}{attachment.FileName}\r\n";
                }

                SaveTimer.Stop();
                ClearTimer();
                SaveTimer.Start();
            }
            finally
            {
                if (inspector != null)
                {
                    Marshal.ReleaseComObject(mail);
                    mail = null;
                }
                if (inspector != null)
                {
                    Marshal.ReleaseComObject(inspector);
                    inspector = null;
                }
            }
        }

        

        private void AddAttachmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
                Outlook.MailItem mail = inspector.CurrentItem;
                try
                {
                    if (attFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        mail.Attachments.Add(attFileDialog.FileNames[0]);
                        AttachmentsTextBox.Text = $"{AttachmentsTextBox.Text}{attFileDialog.FileNames[0]}\r\n";
                    }
                }
                finally
                {
                    if (inspector != null)
                    {
                        Marshal.ReleaseComObject(mail);
                        mail = null;
                    }
                    if (inspector != null)
                    {
                        Marshal.ReleaseComObject(inspector);
                        inspector = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTimer.Stop();
                ClearTimer();

                Outlook.Inspector inspector = Globals.ThisAddIn.Application.ActiveInspector();
                Outlook.MailItem mail = inspector.CurrentItem;

                try
                {
                    if (mail != null)
                    {
                        var syncObject = Globals.ThisAddIn.Application.Session.SyncObjects[1];
                        syncObject.SyncEnd += SyncObject_SyncEnd;
                        syncObject.OnError += SyncObject_OnError;
                        SaveButton.Enabled = false;
                        AddAttachmentButton.Enabled = false;
                        mail.Save();
                        syncObject.Start();
                    }
                }
                finally
                {
                    if (inspector != null)
                    {
                        Marshal.ReleaseComObject(mail);
                        mail = null;
                    }
                    if (inspector != null)
                    {
                        Marshal.ReleaseComObject(inspector);
                        inspector = null;
                    }
                }
                SaveTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void SyncObject_OnError(int Code, string Description)
        {
            var syncObject = Globals.ThisAddIn.Application.Session.SyncObjects[1];
            syncObject.SyncEnd -= SyncObject_SyncEnd;
            syncObject.OnError -= SyncObject_OnError;

            SaveButton.Enabled = true;
            AddAttachmentButton.Enabled = true;
        }

        private void SyncObject_SyncEnd()
        {
            var syncObject = Globals.ThisAddIn.Application.Session.SyncObjects[1];
            syncObject.SyncEnd -= SyncObject_SyncEnd;
            syncObject.OnError -= SyncObject_OnError;

            SaveButton.Enabled = true;
            AddAttachmentButton.Enabled = true;
        }

        private int _saveTimerSeconds = 0;
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            _saveTimerSeconds++;
            SecondsLabel.Text = $"{_saveTimerSeconds}s";
        }

        private void ClearTimer()
        {
            _saveTimerSeconds = 0;
            SecondsLabel.Text = "";
        }
    }
}
