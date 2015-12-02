Imports System.IO
Imports System.IO.File
Imports System.Net
Imports System.IO.Compression

Public Class tf_instalador

    Private Sub tf_instalador_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Launcher.startoption = "any" Then
            ITalk_CheckBox1.Checked = False
        Else
            ITalk_CheckBox1.Checked = True
        End If

        'Load Speudo Option
        If Launcher.speudo = "NewUser" Then
            ITalk_TextBox_Big1.Text = ""
        Else
            ITalk_TextBox_Big1.Text = Launcher.speudo
        End If

        If Launcher.speudo = "NewUser" Then
            ITalk_CheckBox2.Checked = False
        Else
            ITalk_CheckBox2.Checked = True
        End If
    End Sub

    Private Sub ITalk_Button_12_Click(sender As Object, e As EventArgs) Handles ITalk_Button_12.Click
        ' Save option start arma 3
        If ITalk_CheckBox1.Checked = True Then
            Launcher.startoption = ITalk_TextBox_Big2.Text
        Else
            Launcher.startoption = "any"
        End If
        My.Computer.FileSystem.WriteAllText(Launcher.appdata & "startoption.a3", Launcher.startoption, False)

        ' Save custom speudo
        If ITalk_CheckBox2.Checked = True Then
            Launcher.speudo = ITalk_TextBox_Big1.Text
        Else
            Launcher.speudo = "NewUser"
        End If
        My.Computer.FileSystem.WriteAllText(Launcher.appdata & "speudo.a3", Launcher.speudo, False)

        Me.Close()
    End Sub


    Private Sub ITalk_Button_21_Click(sender As Object, e As EventArgs) Handles ITalk_Button_21.Click
        Process.Start("http://www.mediafire.com/download/8aff2kteq1b83o2/TeamSpeak_3_Client.zip")
    End Sub

    Private Sub ITalk_CheckBox2_CheckedChanged(sender As Object) Handles ITalk_CheckBox2.CheckedChanged

    End Sub
End Class