namespace TestOutlookDemo
{
    partial class TestRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TestRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tab1 = this.Factory.CreateRibbonTab();
            this.testGroup = this.Factory.CreateRibbonGroup();
            this.CreateMailButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.testGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.testGroup);
            this.tab1.Label = "Test Add-In";
            this.tab1.Name = "tab1";
            // 
            // testGroup
            // 
            this.testGroup.Items.Add(this.CreateMailButton);
            this.testGroup.Label = "Test Add-in";
            this.testGroup.Name = "testGroup";
            // 
            // CreateMailButton
            // 
            this.CreateMailButton.Label = "CreateMail";
            this.CreateMailButton.Name = "CreateMailButton";
            this.CreateMailButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateMailButton_Click);
            // 
            // TestRibbon
            // 
            this.Name = "TestRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Mail.Compose, Microsoft.Outlook.Mai" +
    "l.Read";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.TestRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.testGroup.ResumeLayout(false);
            this.testGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup testGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateMailButton;
    }

    partial class ThisRibbonCollection
    {
        internal TestRibbon TestRibbon
        {
            get { return this.GetRibbon<TestRibbon>(); }
        }
    }
}
