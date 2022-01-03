Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\dataInizio.txt") Then
            Dim data As Date = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\dataInizio.txt")
            Dim differenza As TimeSpan = Now.Date.Subtract(data)
            Dim giorni As String = FormatNumber(differenza.TotalDays, 0)
            If giorni > 30 Then
                MsgBox("Periodo di prova terminato.", MsgBoxStyle.Information.OkOnly, "Attenzione!")
                End
            Else
                Label1.Text = "Hai iniziato il periodo di prova da " & giorni & " giorni."
            End If
        Else
            System.IO.File.WriteAllText((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\dataInizio.txt"), Now.Date)
        End If
    End Sub
End Class
