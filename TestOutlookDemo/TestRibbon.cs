using Microsoft.Office.Tools.Ribbon;
using System;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace TestOutlookDemo
{
    public partial class TestRibbon
    {
        private void TestRibbon_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void CreateMailButton_Click(object sender, RibbonControlEventArgs e)
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

        #region Helpers
        
        private void CreateCustomPane(Outlook.Inspector window)
        {
            var pane = Globals.ThisAddIn.CustomTaskPanes.Add(new OutgoingPane(window), "Outgoing Pane", window);
            pane.DockPosition = Microsoft.Office.Core.MsoCTPDockPosition.msoCTPDockPositionRight;
            pane.Width = 350;
            pane.Visible = true;
        }

        #endregion
    }
}
