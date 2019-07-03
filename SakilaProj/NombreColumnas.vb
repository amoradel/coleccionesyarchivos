Public Class NombreColumnas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(txtVar1.Text) = "" Or Trim(txtVar2.Text) = "" Then
            MessageBox.Show("Las variables deben tener un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            misfunciones.Col1 = txtVar1.Text
            misfunciones.Col2 = txtVar2.Text
            Me.Dispose()
        End If
    End Sub
End Class