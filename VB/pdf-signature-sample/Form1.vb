'#Region "#usings"
Imports System
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms

' ...
'#End Region  ' #usings
Namespace pdf_signature_sample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

'#Region "#export"
        Private Sub Export()
            Dim report As XtraReport1 = New XtraReport1()
            ' Create a new X509Certificate2 object.
            Dim certificate As X509Certificate2 = New X509Certificate2()
            ' Initialize a local certificate storage and define its options.
            Dim store As X509Store = New X509Store(StoreName.My, StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly Or OpenFlags.OpenExistingOnly)
            ' Initialize a certificate collection and adjust its work.
            Dim collection As X509Certificate2Collection = CType(store.Certificates, X509Certificate2Collection)
            Dim fcollection As X509Certificate2Collection = CType(collection.Find(X509FindType.FindByTimeValid, Date.Now, True), X509Certificate2Collection)
            Dim scollection As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(fcollection, "Test Certificate Select", "Select a certificate from the following list to get information on that certificate", X509SelectionFlag.SingleSelection)
            If scollection.Count > 0 Then certificate = scollection(0)
            ' Define the remaining PDF signature options.
            report.ExportOptions.Pdf.SignatureOptions.ContactInfo = "contact info"
            report.ExportOptions.Pdf.SignatureOptions.Location = "location"
            report.ExportOptions.Pdf.SignatureOptions.Reason = "reason"
            ' Assign the created certificate to the signature options of the PDF export options.
            report.ExportOptions.Pdf.SignatureOptions.Certificate = certificate
            ' Export the report to a PDF file
            ' created in the same folder where the application's .exe file is located.
            report.ExportToPdf("test.pdf")
        End Sub

'#End Region  ' #export
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Export()
        End Sub
    End Class
End Namespace
