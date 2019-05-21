using System;

namespace TestOutlookDemo
{
    partial class TestFormRegion
    {
        #region Form Region Factory 

        [Microsoft.Office.Tools.Outlook.FormRegionMessageClass("IPM.Note.TestFormRegionClass")]
        [Microsoft.Office.Tools.Outlook.FormRegionName("TestOutlookDemo.TestFormRegion")]
        public partial class TestFormRegionFactory
        {
            // Occurs before the form region is initialized.
            // To prevent the form region from appearing, set e.Cancel to true.
            // Use e.OutlookItem to get a reference to the current Outlook item.
            private void TestFormRegionFactory_FormRegionInitializing(object sender, Microsoft.Office.Tools.Outlook.FormRegionInitializingEventArgs e)
            {
            }
        }

        #endregion

        private void TestFormRegion_Load(object sender, EventArgs e)
        {

        }
        private void TestFormRegion_FormRegionShowing(object sender, EventArgs e)
        {

        }
        // Occurs when the form region is closed.
        // Use this.OutlookItem to get a reference to the current Outlook item.
        // Use this.OutlookFormRegion to get a reference to the form region.
        private void TestFormRegion_FormRegionClosed(object sender, System.EventArgs e)
        {
        }
    }
}
