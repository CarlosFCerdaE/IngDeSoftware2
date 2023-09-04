<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPresentacion
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
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(302, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 20)
        Label1.TabIndex = 0
        Label1.Text = "SISTEMA DE FARMACIA"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(12, 421)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 29)
        ProgressBar1.TabIndex = 1
        ' 
        ' FormPresentacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Name = "FormPresentacion"
        Text = "FormPresentacion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
