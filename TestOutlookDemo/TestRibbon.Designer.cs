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
            this.components = new System.ComponentModel.Container();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.CustomEmailOpotionsGroup = this.Factory.CreateRibbonGroup();
            this.CreateCustomEmailButton = this.Factory.CreateRibbonButton();
            this.CreateNormalButton = this.Factory.CreateRibbonButton();
            this.AddAttachmentsButton = this.Factory.CreateRibbonButton();
            this.SaveButton = this.Factory.CreateRibbonButton();
            this.NotCustomEmailOpotionsGroup = this.Factory.CreateRibbonGroup();
            this.attFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveTimer = new System.Windows.Forms.Timer(this.components);
            this.SecondsLabel = this.Factory.CreateRibbonLabel();
            this.tab1.SuspendLayout();
            this.CustomEmailOpotionsGroup.SuspendLayout();
            this.NotCustomEmailOpotionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.NotCustomEmailOpotionsGroup);
            this.tab1.Groups.Add(this.CustomEmailOpotionsGroup);
            this.tab1.Label = "Test Add-In";
            this.tab1.Name = "tab1";
            // 
            // CustomEmailOpotionsGroup
            // 
            this.CustomEmailOpotionsGroup.Items.Add(this.CreateCustomEmailButton);
            this.CustomEmailOpotionsGroup.Label = "Custom email";
            this.CustomEmailOpotionsGroup.Name = "CustomEmailOpotionsGroup";
            // 
            // CreateCustomEmailButton
            // 
            this.CreateCustomEmailButton.Label = "Create custom email";
            this.CreateCustomEmailButton.Name = "CreateCustomEmailButton";
            this.CreateCustomEmailButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateCustomEmailButton_Click);
            // 
            // CreateNormalButton
            // 
            this.CreateNormalButton.Label = "Create non custom email";
            this.CreateNormalButton.Name = "CreateNormalButton";
            this.CreateNormalButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateNormalButton_Click);
            // 
            // AddAttachmentsButton
            // 
            this.AddAttachmentsButton.Label = "Add attachments";
            this.AddAttachmentsButton.Name = "AddAttachmentsButton";
            this.AddAttachmentsButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddAttachmentsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Label = "Save";
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SaveButton_Click);
            // 
            // NotCustomEmailOpotionsGroup
            // 
            this.NotCustomEmailOpotionsGroup.Items.Add(this.CreateNormalButton);
            this.NotCustomEmailOpotionsGroup.Items.Add(this.AddAttachmentsButton);
            this.NotCustomEmailOpotionsGroup.Items.Add(this.SaveButton);
            this.NotCustomEmailOpotionsGroup.Items.Add(this.SecondsLabel);
            this.NotCustomEmailOpotionsGroup.Label = "Not custom email";
            this.NotCustomEmailOpotionsGroup.Name = "NotCustomEmailOpotionsGroup";
            // 
            // attFileDialog
            // 
            this.attFileDialog.FileName = "attFileDialog";
            // 
            // SaveTimer
            // 
            this.SaveTimer.Interval = 1000;
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.Label = " ";
            this.SecondsLabel.Name = "SecondsLabel";
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
            this.CustomEmailOpotionsGroup.ResumeLayout(false);
            this.CustomEmailOpotionsGroup.PerformLayout();
            this.NotCustomEmailOpotionsGroup.ResumeLayout(false);
            this.NotCustomEmailOpotionsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CustomEmailOpotionsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateCustomEmailButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateNormalButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup NotCustomEmailOpotionsGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AddAttachmentsButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SaveButton;
        private System.Windows.Forms.OpenFileDialog attFileDialog;
        private System.Windows.Forms.Timer SaveTimer;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel SecondsLabel;
    }

    partial class ThisRibbonCollection
    {
        internal TestRibbon TestRibbon
        {
            get { return this.GetRibbon<TestRibbon>(); }
        }
    }
}
