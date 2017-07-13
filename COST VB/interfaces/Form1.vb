Public Class Form1
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim cr1 As New CachedCrystalReport1
        CrystalReportViewer1.ReportSource = cr1

    End Sub
End Class