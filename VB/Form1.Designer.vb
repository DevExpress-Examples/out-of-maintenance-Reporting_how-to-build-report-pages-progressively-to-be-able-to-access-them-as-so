Imports Microsoft.VisualBasic
Imports System
Namespace BuildPagesInBackground
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnStart = New DevExpress.XtraEditors.SimpleButton()
			Me.btnStop = New DevExpress.XtraEditors.SimpleButton()
			Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnStart
			' 
			Me.btnStart.Location = New System.Drawing.Point(17, 12)
			Me.btnStart.Name = "btnStart"
			Me.btnStart.Size = New System.Drawing.Size(152, 29)
			Me.btnStart.TabIndex = 0
			Me.btnStart.Text = "Start Generating Pages"
'			Me.btnStart.Click += New System.EventHandler(Me.btnStart_Click);
			' 
			' btnStop
			' 
			Me.btnStop.Location = New System.Drawing.Point(189, 12)
			Me.btnStop.Name = "btnStop"
			Me.btnStop.Size = New System.Drawing.Size(152, 29)
			Me.btnStop.TabIndex = 1
			Me.btnStop.Text = "Stop!"
'			Me.btnStop.Click += New System.EventHandler(Me.btnStop_Click);
			' 
			' progressBarControl1
			' 
			Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.progressBarControl1.Location = New System.Drawing.Point(2, 2)
			Me.progressBarControl1.Name = "progressBarControl1"
			Me.progressBarControl1.Size = New System.Drawing.Size(641, 24)
			Me.progressBarControl1.TabIndex = 3
			' 
			' printControl1
			' 
			Me.printControl1.BackColor = System.Drawing.Color.Empty
			Me.printControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.printControl1.ForeColor = System.Drawing.Color.Empty
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(0, 59)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.Size = New System.Drawing.Size(645, 333)
			Me.printControl1.TabIndex = 4
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnStart)
			Me.panelControl1.Controls.Add(Me.btnStop)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(645, 59)
			Me.panelControl1.TabIndex = 5
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.progressBarControl1)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl2.Location = New System.Drawing.Point(0, 392)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(645, 28)
			Me.panelControl2.TabIndex = 6
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(645, 420)
			Me.Controls.Add(Me.printControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnStart As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnStop As DevExpress.XtraEditors.SimpleButton
		Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
		Private printControl1 As DevExpress.XtraPrinting.Control.PrintControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace