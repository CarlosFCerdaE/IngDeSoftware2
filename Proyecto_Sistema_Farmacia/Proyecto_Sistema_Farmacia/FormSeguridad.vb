Imports Microsoft.Data.SqlClient

Public Class FormSeguridad
    Inherits System.Windows.Forms.Form
    Dim dv As DataView
    Private posicion As Integer
    Dim odataset As New DataSet
    Private oconn As SqlConnection
    Private odataadapter As New SqlDataAdapter
    Private Sub SeguridadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oconn = New SqlConnection(oConexion)
        Me.odataadapter = New SqlDataAdapter("Select * from USUARIOS",
oconn)
        Dim ocommandbuilder As SqlCommandBuilder = New SqlCommandBuilder(odataadapter)
        Me.odataset = New DataSet
        oconn.Open()
        Me.odataadapter.Fill(odataset, "USUARIOS")
        oconn.Close()
        posicion = 0
        Me.cargadatos()
    End Sub

    Private Sub cargadatos()
        Dim odatarow As DataRow
        odatarow = Me.odataset.Tables("USUARIOS").Rows(posicion)
        Me.TxtCargarUsuario.Text = odatarow("Nombre")
        Me.TxtCargarContraseña.Text = odatarow("Contraseña")
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        comparar()
    End Sub

    Private Sub comparar()
        If Me.TxtCargarUsuario.Text = Me.TxtUsuario.Text And Me.TxtCargarContraseña.Text = Me.TxtContraseña.Text Then
            abrir()
        Else
            buscar()
        End If
    End Sub

    Private Sub abrir()
        Dim open As New FormPresentacion
        open.Show()
        Me.Hide()
    End Sub
    Private Sub buscar()
        If Me.posicion = (Me.odataset.Tables("Usuarios").Rows.Count - 1) Then

            MessageBox.Show("Usuario no registrado")
        Else
            posicion += 1
            cargadatos()
            comparar()
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.TxtContraseña.Focus()
        End If
    End Sub

    Private Sub TxtContraseña_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.BtnAceptar.Focus()
        End If
    End Sub
End Class