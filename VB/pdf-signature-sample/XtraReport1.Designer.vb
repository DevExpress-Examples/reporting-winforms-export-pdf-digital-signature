Imports Microsoft.VisualBasic
Imports System
Namespace pdf_signature_sample
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrWatermark1 As New DevExpress.XtraReports.UI.XRWatermark()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New nwindDataSet()
			Me.productsTableAdapter = New nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrPdfSignature1 = New DevExpress.XtraReports.UI.XRPdfSignature()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			'
			'Detail
			'
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
			Me.Detail.HeightF = 23.0!
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0!, 0!, 0!, 0!, 100.0!)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			'
			'xrLabel1
			'
			Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2.0!, 2.0!, 0!, 0!, 100.0!)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(537.5!, 23.0!)
			Me.xrLabel1.Text = "xrLabel1"
			'
			'TopMargin
			'
			Me.TopMargin.HeightF = 48.95833!
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0!, 0!, 0!, 0!, 100.0!)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			'
			'BottomMargin
			'
			Me.BottomMargin.HeightF = 47.91667!
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0!, 0!, 0!, 0!, 100.0!)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			'
			'nwindDataSet1
			'
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			'
			'productsTableAdapter
			'
			Me.productsTableAdapter.ClearBeforeFill = True
			'
			'ReportFooter
			'
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPdfSignature1})
			Me.ReportFooter.HeightF = 128.6666!
			Me.ReportFooter.Name = "ReportFooter"
			'
			'xrPdfSignature1
			'
			Me.xrPdfSignature1.LocationFloat = New DevExpress.Utils.PointFloat(311.4583!, 28.66664!)
			Me.xrPdfSignature1.Name = "xrPdfSignature1"
			Me.xrPdfSignature1.Padding = New DevExpress.XtraPrinting.PaddingInfo(8, 8, 8, 8, 96.0!)
			Me.xrPdfSignature1.SizeF = New System.Drawing.SizeF(314.5833!, 100.0!)
			'
			'XtraReport1
			'
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Margins = New DevExpress.Drawing.DXMargins(100.0!, 100.0!, 48.95833!, 15.54165!)
			Me.Version = "26.1"
			xrWatermark1.Id = "Watermark1"
			Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {xrWatermark1})
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrPdfSignature1 As DevExpress.XtraReports.UI.XRPdfSignature
	End Class
End Namespace
