Imports System.IO
Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmUnrar
    Private Sub btnRar_Click(sender As Object, e As EventArgs) Handles btnRar.Click
        If rarFolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtRar.Text = rarFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnTarget_Click(sender As Object, e As EventArgs) Handles btnTarget.Click
        If rarOpenFileDialog.ShowDialog = DialogResult.OK Then
            txtTarget.Text = rarOpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnDestination_Click(sender As Object, e As EventArgs) Handles btnDestination.Click
        If rarFolderBrowserDialog.ShowDialog = DialogResult.OK Then
            txtDestination.Text = rarFolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If Not System.IO.File.Exists(txtRar.Text + "\WinRAR.exe") Then
            MsgBox("Winrar path incorrect!", vbCritical, "tsf Unrar")
            If rarFolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txtRar.Text = rarFolderBrowserDialog.SelectedPath
            End If
        ElseIf Not System.IO.File.Exists(txtTarget.Text) Then
            MsgBox("Archive file not found!", vbInformation, "tsf Unrar")
            If rarOpenFileDialog.ShowDialog = DialogResult.OK Then
                txtTarget.Text = rarOpenFileDialog.FileName
            End If
        ElseIf Not System.IO.Directory.Exists(txtDestination.Text) Then
            MsgBox("Destination folder not found!", vbExclamation, "tsf Unrar")
            If rarFolderBrowserDialog.ShowDialog = DialogResult.OK Then
                txtDestination.Text = rarFolderBrowserDialog.SelectedPath
            End If
        Else
            If MsgBox("Extract " + txtTarget.Text + " to " + txtDestination.Text, vbOKCancel + vbQuestion, "tsf Unrar") = MsgBoxResult.Ok Then
                Dim inside As String = ""
                If Not txtInside.Text = "" Then
                    inside = "-ap" + txtInside.Text + " "
                End If
                Process.Start("cmd", "/c C: & set path=" + txtRar.Text + ";%path% & echo tsfUnrar: " + txtTarget.Text + " to be extract to " + txtDestination.Text + " & WinRAR x " + txtTarget.Text + " " + inside + "-ibck -o- " + txtDestination.Text)
                'System.Console.WriteLine(System.IO.Directory.GetDirectories(txtTarget.Text))
                System.Console.WriteLine("Extract " + txtTarget.Text + " to " + txtDestination.Text)
            End If
            End If
    End Sub
End Class
