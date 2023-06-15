<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604108/22.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4191)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Reporting for WinForms - Apply a Digital Signature When Exporting a Report to PDF


This example shows how to apply a digital signature when a report is exported to PDF using the [XtraReport.ExportOptions.Pdf.SignatureOptions](http://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PdfExportOptions.SignatureOptions) property.

The code uses the [X509Store](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509store) class as a  local storage for digital certificates.

## Files to Review

* [Form1.cs](./CS/pdf-signature-sample/Form1.cs) (VB: [Form1.vb](./VB/pdf-signature-sample/Form1.vb))

## Documentation

- [SignatureOptions Class](http://docs.devexpress.com/CoreLibraries/DevExpress.XtraPrinting.PdfExportOptions.SignatureOptions)
- [Create a Report with a Visual PDF Signature](http://docs.devexpress.com/XtraReports/402208/create-reports/create-a-report-with-visual-pdf-signature) 
- [XRPdfSignature Class](http://docs.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XRPdfSignature)

## More Examples

- [Reporting for ASP.NET Core - Use the Web Document Viewer to Sign an Exported PDF Document](https://github.com/DevExpress-Examples/reporting-asp-net-core-sign-pdf-on-export)
