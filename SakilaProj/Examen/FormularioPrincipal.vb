Public Class FormularioPrincipal


    Private Sub FormularioPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub showNewForm(ByVal frm As Form)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.ControlBox = False
        frm.ShowIcon = False
        frm.ShowInTaskbar = False
        frm.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        showNewForm(Estadisticas)
    End Sub

    Private Sub btnInternet_Click(sender As Object, e As EventArgs) Handles btnInternet.Click

    End Sub
End Class