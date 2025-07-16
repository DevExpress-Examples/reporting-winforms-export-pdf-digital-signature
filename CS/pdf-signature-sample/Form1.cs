using DevExpress.XtraPrinting.Drawing;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace pdf_signature_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Export()
        {
            XtraReport1 report = new XtraReport1();

            // Create a new X509Certificate2 object.
            X509Certificate2 certificate = new X509Certificate2();

            // Initialize and configure a local certificate storage.
            X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            // Initialize a certificate collection.
            X509Certificate2Collection collection = (X509Certificate2Collection)store.Certificates;
            X509Certificate2Collection fcollection =
                (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            X509Certificate2Collection scollection =
                X509Certificate2UI.SelectFromCollection(fcollection, "Select a Certificate",
                    "Select a certificate to view its details.",
                    X509SelectionFlag.SingleSelection);
            if (scollection.Count > 0)
                certificate = scollection[0];

            // Specify PDF signature options.
            report.ExportOptions.Pdf.SignatureOptions.Reason = "Approved";
            report.ExportOptions.Pdf.SignatureOptions.Location = "USA";
            // svgImageCollection stores SVG images.
            // In this example, it was created and populated at design time.
            report.ExportOptions.Pdf.SignatureOptions.ImageSource = new ImageSource(
                svgImageCollection1["approved"]
             );
            report.ExportOptions.Pdf.SignatureOptions.Certificate = certificate;

            // Export the report to PDF.
            report.ExportToPdf("test.pdf");

            System.Diagnostics.Process.Start("test.pdf");
        }

        void button1_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
