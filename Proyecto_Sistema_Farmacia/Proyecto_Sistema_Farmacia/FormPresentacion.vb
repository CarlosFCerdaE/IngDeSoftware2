Public Class FormPresentacion
    Private Sub cerrar()
        FormSeguridad.Hide()
    End Sub
    Private Sub FormPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load()
        Dim CONTAR As Integer
        Me.Show()
        cerrar()
        Me.Refresh()
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Maximum = 100000
        Me.ProgressBar1.Value = 0
        CONTAR = 0
        Do While CONTAR < 100000
            CONTAR = CONTAR + 1
            Me.ProgressBar1.Value = CONTAR
            Me.ProgressBar1.Refresh()
        Loop
        Me.Close()
        MDI_Factura.Show()
    End Sub

End Class