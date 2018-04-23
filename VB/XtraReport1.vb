Imports Microsoft.VisualBasic
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace BuildPagesInBackground
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private i As Integer

		Private Sub xrLabel2_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles xrLabel2.BeforePrint
			i += 1
			CType(sender, XRLabel).Text = "Row Number: " & i.ToString()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles MyBase.BeforePrint
			i = 0
			CType(sender, XtraReport).DetailPrintCount = CInt(Fix(TotalRowCount.Value))
		End Sub

	End Class
End Namespace
