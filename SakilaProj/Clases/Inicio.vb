Module Inicio
    Public misclientes As Clientes
    Public micoleccionclientes As ColeccionClientes
    Public misfunciones As Funciones

    Public misdatos As Datos
    Public micolecciondatos As ColeccionDatos

    Public Sub main()
        micoleccionclientes = New ColeccionClientes
        misfunciones = New Funciones
        Try
            Application.Run(New Graficas)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
