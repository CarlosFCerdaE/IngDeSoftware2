Public Class MDI_Factura
    Private Sub FacturasToolStripMenuItem_Click_1(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click

        FrmFactura.ShowDialog()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click

        FrmProductos.ShowDialog()
    End Sub
9
Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e
As System.EventArgs) Handles SalirToolStripMenuItem.Click
If MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensaje
del sistema", MessageBoxButtons.YesNo,
MessageBoxIcon.Question,
MessageBoxDefaultButton.Button2) =
Windows.Forms.DialogResult.Yes Then
            End
        End If

    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem1.Click

        Frm_Consulta_Facturas.ShowDialog()

    End Sub

End Class