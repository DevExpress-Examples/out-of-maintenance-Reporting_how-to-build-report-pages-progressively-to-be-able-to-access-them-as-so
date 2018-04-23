Imports Microsoft.VisualBasic
Imports System
Namespace BuildPagesInBackground
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TotalRowCount = New DevExpress.XtraReports.Parameters.Parameter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2})
			Me.Detail.Height = 32
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New System.Drawing.Font("Arial", 12F)
			Me.xrLabel2.Location = New System.Drawing.Point(0, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(650, 25)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "Row number"
'			Me.xrLabel2.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrLabel2_BeforePrint);
			' 
			' TotalRowCount
			' 
			Me.TotalRowCount.Name = "TotalRowCount"
			Me.TotalRowCount.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
			Me.TotalRowCount.Value = 0
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.ReportHeader.Height = 71
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "", "A very large report with {0} rows")})
			Me.xrLabel1.Font = New System.Drawing.Font("Arial", 20F)
			Me.xrLabel1.ForeColor = System.Drawing.Color.Navy
			Me.xrLabel1.Location = New System.Drawing.Point(0, 17)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.Size = New System.Drawing.Size(650, 42)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.StylePriority.UseTextAlignment = False
			Me.xrLabel1.Text = "xrLabel1"
			Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader})
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.TotalRowCount})
			Me.RequestParameters = False
			Me.Version = "8.3"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Public TotalRowCount As DevExpress.XtraReports.Parameters.Parameter
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
