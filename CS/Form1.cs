#region Usings
using System;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting.Native;
#endregion


namespace BuildPagesInBackground {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        XtraReport1 report;

        private void Form1_Load(object sender, EventArgs e) {
            report = new XtraReport1();
            report.TotalRowCount.Value = 100000;

            report.BeforePrint += new PrintEventHandler(report_BeforePrint);
            report.AfterPrint += new EventHandler(report_AfterPrint);

            printControl1.PrintingSystem = report.PrintingSystem;

            UpdateButtons(false);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            report.CreateDocument(true);
        }

        private void btnStop_Click(object sender, EventArgs e) {
            report.StopPageBuilding();
        }

        #region Updating the progress bar and buttons
        void report_BeforePrint(object sender, PrintEventArgs e) {
            report.PrintingSystem.ProgressReflector = 
                new ReflectorBar(progressBarControl1);

            UpdateButtons(true);
        }

        void report_AfterPrint(object sender, EventArgs e) {
            report.PrintingSystem.ResetProgressReflector();
            UpdateButtons(false);
        }

        private void UpdateButtons(bool isBuilding) {
            this.btnStart.Enabled = !isBuilding;
            this.btnStop.Enabled = isBuilding;
        }
        #endregion
    }
}