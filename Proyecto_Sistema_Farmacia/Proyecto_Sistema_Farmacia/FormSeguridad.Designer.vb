<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeguridad
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
        BtnAceptar = New Button()
        BtnCancelar = New Button()
        TxtCargarUsuario = New TextBox()
        TxtCargarContraseña = New TextBox()
        TxtUsuario = New TextBox()
        TxtContraseña = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(251, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 20)
        Label1.TabIndex = 0
        Label1.Text = "VALIDACION DE ACCESO"
        ' 
        ' BtnAceptar
        ' 
        BtnAceptar.Location = New Point(428, 317)
        BtnAceptar.Name = "BtnAceptar"
        BtnAceptar.Size = New Size(94, 29)
        BtnAceptar.TabIndex = 1
        BtnAceptar.Text = "Aceptar"
        BtnAceptar.UseVisualStyleBackColor = True
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.Location = New Point(548, 317)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(94, 29)
        BtnCancelar.TabIndex = 2
        BtnCancelar.Text = "Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' TxtCargarUsuario
        ' 
        TxtCargarUsuario.Location = New Point(416, 73)
        TxtCargarUsuario.Name = "TxtCargarUsuario"
        TxtCargarUsuario.Size = New Size(125, 27)
        TxtCargarUsuario.TabIndex = 3
        ' 
        ' TxtCargarContraseña
        ' 
        TxtCargarContraseña.Location = New Point(416, 123)
        TxtCargarContraseña.Name = "TxtCargarContraseña"
        TxtCargarContraseña.Size = New Size(125, 27)
        TxtCargarContraseña.TabIndex = 4
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(416, 172)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(125, 27)
        TxtUsuario.TabIndex = 5
        ' 
        ' TxtContraseña
        ' 
        TxtContraseña.Location = New Point(416, 223)
        TxtContraseña.Name = "TxtContraseña"
        TxtContraseña.Size = New Size(125, 27)
        TxtContraseña.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(313, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 7
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(313, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 8
        Label3.Text = "Contraseña"
        ' 
        ' FormSeguridad
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 387)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TxtContraseña)
        Controls.Add(TxtUsuario)
        Controls.Add(TxtCargarContraseña)
        Controls.Add(TxtCargarUsuario)
        Controls.Add(BtnCancelar)
        Controls.Add(BtnAceptar)
        Controls.Add(Label1)
        Name = "FormSeguridad"
        Text = "FormSeguridad"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtCargarUsuario As TextBox
    Friend WithEvents TxtCargarContraseña As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
