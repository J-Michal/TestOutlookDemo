using Microsoft.Office.Tools.Ribbon;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TestOutlookDemo
{
    public partial class TestRibbon
    {
        private void TestRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            var ribbon = (OfficeRibbon)sender;
            if (ribbon != null)
            {
                if (!ribbon.RibbonId.EndsWith("Explorer"))
                {
                    CustomEmailOpotionsGroup.Visible = false;
                    CreateNormalButton.Visible = false;
                }
                else
                {
                    AddAttachmentsButton.Visible = false;
                    SaveButton.Visible = false;
                }
            }

        }

        private void CreateCustomEmailButton_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                var mail = (Outlook.MailItem)Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
                mail.MessageClass = "IPM.Note.TestFormRegionClass";
                var inspector = Globals.ThisAddIn.Application.Inspectors.Add(mail);
                inspector.Display();

                CreateCustomPane(inspector);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNormalButton_Click(object sender, RibbonControlEventArgs e)
        {
            var mail = (Outlook.MailItem)Globals.ThisAddIn.Application.CreateItem(Outlook.OlItemType.olMailItem);
            var inspector = Globals.ThisAddIn.Application.Inspectors.Add(mail);
            inspector.Display();
        }
        private void AddAttachmentsButton_Click(object sender, RibbonControlEventArgs e)
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
                        mail.Body = $"{mail.Body}{attFileDialog.FileNames[0]}\r\n";
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
        private void SaveButton_Click(object sender, RibbonControlEventArgs e)
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
                        mail.Save();
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

        #region Helpers

        private void CreateCustomPane(Outlook.Inspector window)
        {
            var pane = Globals.ThisAddIn.CustomTaskPanes.Add(new OutgoingPane(), "Outgoing Pane", window);
            pane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
            pane.Width = 350;
            pane.Visible = true;
        }

        private int _saveTimerSeconds = 0;
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            _saveTimerSeconds++;
            SecondsLabel.Label = $"{_saveTimerSeconds}s";
        }

        private void ClearTimer()
        {
            _saveTimerSeconds = 0;
            SecondsLabel.Label = " ";
        }

        #endregion
    }
}
