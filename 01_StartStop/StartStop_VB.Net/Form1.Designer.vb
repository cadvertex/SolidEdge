<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.cmdAppend = New System.Windows.Forms.Button()
        Me.cmdVersion = New System.Windows.Forms.Button()
        Me.cmdHide = New System.Windows.Forms.Button()
        Me.cmdShow = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.chkEdge = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(12, 215)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(138, 20)
        Me.txtStatus.TabIndex = 30
        Me.txtStatus.Text = " via VB.Net "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.label1.Location = New System.Drawing.Point(12, 186)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(2, 15)
        Me.label1.TabIndex = 29
        '
        'cmdQuit
        '
        Me.cmdQuit.Location = New System.Drawing.Point(12, 353)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(138, 38)
        Me.cmdQuit.TabIndex = 28
        Me.cmdQuit.Text = "Quit Solid Edge"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'cmdAppend
        '
        Me.cmdAppend.Location = New System.Drawing.Point(12, 241)
        Me.cmdAppend.Name = "cmdAppend"
        Me.cmdAppend.Size = New System.Drawing.Size(138, 38)
        Me.cmdAppend.TabIndex = 25
        Me.cmdAppend.Text = "Append to Status bar"
        Me.cmdAppend.UseVisualStyleBackColor = True
        '
        'cmdVersion
        '
        Me.cmdVersion.Location = New System.Drawing.Point(12, 135)
        Me.cmdVersion.Name = "cmdVersion"
        Me.cmdVersion.Size = New System.Drawing.Size(138, 38)
        Me.cmdVersion.TabIndex = 24
        Me.cmdVersion.Text = "Display Version"
        Me.cmdVersion.UseVisualStyleBackColor = True
        '
        'cmdHide
        '
        Me.cmdHide.Location = New System.Drawing.Point(87, 82)
        Me.cmdHide.Name = "cmdHide"
        Me.cmdHide.Size = New System.Drawing.Size(63, 38)
        Me.cmdHide.TabIndex = 27
        Me.cmdHide.Text = "Hide"
        Me.cmdHide.UseVisualStyleBackColor = True
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(12, 82)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(69, 38)
        Me.cmdShow.TabIndex = 26
        Me.cmdShow.Text = "Show"
        Me.cmdShow.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(12, 12)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(138, 50)
        Me.cmdStart.TabIndex = 23
        Me.cmdStart.Text = "Start Solid Edge"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(12, 294)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(112, 17)
        Me.chkStatus.TabIndex = 31
        Me.chkStatus.Text = "Display Status Bar"
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'chkEdge
        '
        Me.chkEdge.AutoSize = True
        Me.chkEdge.Location = New System.Drawing.Point(12, 317)
        Me.chkEdge.Name = "chkEdge"
        Me.chkEdge.Size = New System.Drawing.Size(107, 17)
        Me.chkEdge.TabIndex = 32
        Me.chkEdge.Text = "Display Edge Bar"
        Me.chkEdge.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(164, 403)
        Me.Controls.Add(Me.chkEdge)
        Me.Controls.Add(Me.chkStatus)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.cmdAppend)
        Me.Controls.Add(Me.cmdVersion)
        Me.Controls.Add(Me.cmdHide)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.cmdStart)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Solid Edge: VB.Net"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Private WithEvents txtStatus As System.Windows.Forms.TextBox
	Private WithEvents label1 As System.Windows.Forms.Label
	Private WithEvents cmdQuit As System.Windows.Forms.Button
	Private WithEvents cmdAppend As System.Windows.Forms.Button
	Private WithEvents cmdVersion As System.Windows.Forms.Button
	Private WithEvents cmdHide As System.Windows.Forms.Button
	Private WithEvents cmdShow As System.Windows.Forms.Button
	Private WithEvents cmdStart As System.Windows.Forms.Button
	Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
	Friend WithEvents chkEdge As System.Windows.Forms.CheckBox

End Class
