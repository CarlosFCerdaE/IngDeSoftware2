Imports Microsoft.Data.SqlClient

Module ConexionBD

    Public CONEXION As New SqlConnection

    Public Sub Abrir_BaseDato()
        CONEXION.ConnectionString = "Data Source=DESKTOP-BI8ULFO;Initial
Catalog=Facturacion_Farmacia;Integrated Security=True"
        CONEXION.Open()
    End Sub

    Public Sub Cerrar_BaseDato()
        CONEXION.Close()
    End Sub
End Module
