# Reporting for WinForms - Apply a Digital Signature When Exporting a Report to PDF


This example shows how to apply a digital signature when a report is exported to PDF using the [XtraReport.ExportOptions.Pdf.SignatureOptions](http://docs.devexpress.devx/CoreLibraries/DevExpress.XtraPrinting.PdfExportOptions.SignatureOptions) property.

The code uses the [X509Store](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509store) class as a  local storage for digital certificates.

## Files to Review

* [Form1.cs](./CS/pdf-signature-sample/Form1.cs) (VB: [Form1.vb](./VB/pdf-signature-sample/Form1.vb))

## Documentation

- [SignatureOptions Class](http://docs.devexpress.devx/CoreLibraries/DevExpress.XtraPrinting.PdfExportOptions.SignatureOptions)
- [Create a Report with a Visual PDF Signature](http://docs.devexpress.devx/XtraReports/402208/create-reports/create-a-report-with-visual-pdf-signature) 
- [XRPdfSignature Class](http://docs.devexpress.devx/XtraReports/DevExpress.XtraReports.UI.XRPdfSignature)

## More Examples

- [Reporting for ASP.NET Core - Use the Web Document Viewer to Sign an Exported PDF Document](https://github.com/DevExpress-Examples/reporting-asp-net-core-sign-pdf-on-export)