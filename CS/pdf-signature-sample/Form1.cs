#region #usings
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
// ...
#endregion #usings

namespace pdf_signature_sample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #export
        private void Export() {
            XtraReport1 report = new XtraReport1();

            // Create a new X509Certificate2 object.
            X509Certificate2 certificate = new X509Certificate2();

            // Initialize a local certificate storage and define its options.
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            // Initialize a certificate collection and adjust its work.
            X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
            X509Certificate2Collection fcollection =
                (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            X509Certificate2Collection scollection =
                X509Certificate2UI.SelectFromCollection(fcollection, "Test Certificate Select",
                    "Select a certificate from the following list to get information on that certificate",
                    X509SelectionFlag.SingleSelection);
            if(scollection.Count > 0)
                certificate = scollection[0];

            // Define the remaining PDF signature options.
            report.ExportOptions.Pdf.SignatureOptions.ContactInfo = "contact info";
            report.ExportOptions.Pdf.SignatureOptions.Location = "location";
            report.ExportOptions.Pdf.SignatureOptions.Reason = "reason";

            // Assign the created certificate to the signature options of the PDF export options.
            report.ExportOptions.Pdf.SignatureOptions.Certificate = certificate;

            // Export the report to a PDF file
            // created in the same folder where the application's .exe file is located.
            report.ExportToPdf("test.pdf");
            System.Diagnostics.Process.Start("test.pdf");
        }
        #endregion #export

        private void button1_Click(object sender, EventArgs e) {
            Export();
        }
    }
}
