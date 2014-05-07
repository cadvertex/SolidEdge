Imports System.Runtime.InteropServices
Imports SolidEdgeFramework

Public Class Form1
	Dim oApp As SolidEdgeFramework.Application
	Dim typ As Type

	Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
		Try
            oApp = Marshal.GetActiveObject("SolidEdge.Application")
            'oApp = CreateObject("SolidEdge.Application")
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click
		oApp.Visible = True
	End Sub

	Private Sub cmdHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHide.Click
		oApp.Visible = False
	End Sub

	Private Sub cmdVersion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVersion.Click
		label1.Text = oApp.Name & " - " & oApp.Version
	End Sub

	Private Sub cmdAppend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAppend.Click
		oApp.StatusBar += txtStatus.Text
	End Sub

	Private Sub chkStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStatus.CheckedChanged
		oApp.StatusBarVisible = chkStatus.Checked
	End Sub

	Private Sub chkEdge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEdge.CheckedChanged
		oApp.EdgeBarVisible = chkEdge.Checked
	End Sub

	Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
		oApp.Quit()
	End Sub
End Class
