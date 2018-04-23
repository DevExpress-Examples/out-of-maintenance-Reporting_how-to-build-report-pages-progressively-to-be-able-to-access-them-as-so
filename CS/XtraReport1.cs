using System.Drawing.Printing;
using DevExpress.XtraReports.UI;
// ...

namespace BuildPagesInBackground {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        int i;

        private void xrLabel2_BeforePrint(object sender, PrintEventArgs e) {
            i++;
            ((XRLabel)sender).Text = "Row Number: " + i.ToString();
        }

        private void XtraReport1_BeforePrint(object sender, PrintEventArgs e) {
            i = 0;
            ((XtraReport)sender).DetailPrintCount = (int)TotalRowCount.Value;
        }

    }
}
