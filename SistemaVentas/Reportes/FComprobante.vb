Public Class FComprobante
    Public idventa As Integer
    Private Sub FComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datosventas.GenerarComprobante' Puede moverla o quitarla según sea necesario.
        Me.GenerarComprobanteTableAdapter.Fill(Me.datosventas.GenerarComprobante, idventa:=idventa)

        'TODO: esta línea de código carga datos en la tabla 'datosventasDataSet.GenerarComprobante' Puede moverla o quitarla según sea necesario.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class