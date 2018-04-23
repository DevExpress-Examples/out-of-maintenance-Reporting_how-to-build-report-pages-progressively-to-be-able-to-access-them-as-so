Imports Microsoft.VisualBasic
#Region "Usings"
Imports System
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.Native
#End Region


Namespace BuildPagesInBackground
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private report As XtraReport1

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			report = New XtraReport1()
			report.TotalRowCount.Value = 100000

			AddHandler report.BeforePrint, AddressOf report_BeforePrint
			AddHandler report.AfterPrint, AddressOf report_AfterPrint

			printControl1.PrintingSystem = report.PrintingSystem

			UpdateButtons(False)
		End Sub

		Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
			report.CreateDocument(True)
		End Sub

		Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStop.Click
			report.StopPageBuilding()
		End Sub

		#Region "Updating the progress bar and buttons"
		Private Sub report_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			report.PrintingSystem.ProgressReflector = New ReflectorBar(progressBarControl1)

			UpdateButtons(True)
		End Sub

		Private Sub report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			report.PrintingSystem.ResetProgressReflector()
			UpdateButtons(False)
		End Sub

		Private Sub UpdateButtons(ByVal isBuilding As Boolean)
			Me.btnStart.Enabled = Not isBuilding
			Me.btnStop.Enabled = isBuilding
		End Sub
		#End Region
	End Class
End Namespace