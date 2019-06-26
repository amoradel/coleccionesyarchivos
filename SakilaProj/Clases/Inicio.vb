Module Inicio
    Public misclientes As Clientes
    Public micoleccionclientes As ColeccionClientes

    Public Sub main()
        micoleccionclientes = New ColeccionClientes
        Try
            Application.Run(New ArchivoClientes)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
