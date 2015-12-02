Imports System.Net, System.IO, System.Management, System, System.Security.Cryptography, System.Text
'------------------------------------
'Criado dia 11/9/2015 as 00:20
'Creditos AugmentedSkillsBR
'WebSite www.developerscheatsbr.com
'E-mail: krsolucoesweb@gmail.com
'-----------------------------------
Public Class Login
    Public PVerison As String = "1.9" 'Modificar versão do sistema
    Public URL As String = "http://launcher-a3lbr.890m.com/HwidSystem/" 'Local onde esta o sistema.

    Dim a3 As String = "http://pastebin.com/raw.php?i=b3AGyKYJ"
    Dim t3 As String = "http://pastebin.com/raw.php?i=7TzVz2Pe"
    Dim a3Str As System.IO.Stream
    Dim a3srRead As System.IO.StreamReader
    Dim tsStr2 As System.IO.Stream
    Dim tssrRead2 As System.IO.StreamReader

    Private Sub ITalk_Button_21_Click(sender As Object, e As EventArgs) Handles ITalk_Button_21.Click
        Select Case Hwid.CheckLogin(TextBox1.Text, TextBox2.Text)
            Case "True"
                Me.Hide()
                Launcher.Show()
                'Não Mude esta area!
            Case "Banned"
                MsgBox("Sua conta foi Banida!" + vbCrLf + "Entre em contato com os administradores." + vbCrLf + "Para saber mais sobre o Banimento." + vbCrLf + "Maiores informações: www.arma3lifebrasil.com.br", MsgBoxStyle.Critical, "Banido!")
                'Não Mude esta area!
            Case "Invalid"
                MsgBox("Nome de usuário ou senha inválida", MsgBoxStyle.Critical, "Error")
            Case Else
                MsgBox("Um erro ocorreu. Por favor tente de novo mais tarde", MsgBoxStyle.Exclamation, "Error")
        End Select
    End Sub

    Private Sub ITalk_Button_11_Click(sender As Object, e As EventArgs) Handles ITalk_Button_11.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub ITalk_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ITalk_LinkLabel1.LinkClicked
        Process.Start("http://arma3lifebrasil.com.br/foruns/profile/1-renildomarcio/")
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        ITalk_Label6.Text = "Versão:" & PVerison & ""
        Dim tsreq2 As System.Net.WebRequest = System.Net.WebRequest.Create(t3)
        Dim tsresp2 As System.Net.WebResponse = tsreq2.GetResponse
        tsStr2 = tsresp2.GetResponseStream
        tssrRead2 = New System.IO.StreamReader(tsStr2)

        TextBox4.Text = tssrRead2.ReadToEnd

        Dim a3req As System.Net.WebRequest = System.Net.WebRequest.Create(a3)
        Dim a3resp As System.Net.WebResponse = a3req.GetResponse
        a3Str = a3resp.GetResponseStream
        a3srRead = New System.IO.StreamReader(a3Str)

        TextBox3.Text = a3srRead.ReadToEnd

        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(TextBox3.Text)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        PictureBox3.Image = New System.Drawing.Bitmap(ImageStream)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(TextBox3.Text)))

        Dim ImageInBytes1() As Byte = MyWebClient.DownloadData(TextBox4.Text)
        Dim ImageStream1 As New IO.MemoryStream(ImageInBytes1)
        PictureBox2.Image = New System.Drawing.Bitmap(ImageStream1)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(TextBox4.Text)))

        Timer1.Enabled = True
        TextBox1.Text = My.Settings.User
        TextBox2.Text = My.Settings.Senha
        If TextBox1.Text = "" Then
        Else
            ITalk_CheckBox1.Checked = True
        End If
    End Sub

    Private Sub ITalk_ThemeContainer1_Click(sender As Object, e As EventArgs) Handles ITalk_ThemeContainer1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ITalk_CheckBox1.Checked = True Then
            My.Settings.User = TextBox1.Text
            My.Settings.Senha = TextBox2.Text
            My.Settings.Save()
        End If
        If ITalk_CheckBox1.Checked = False Then
            My.Settings.User = ""
            My.Settings.Senha = ""
            My.Settings.Save()
        End If
    End Sub

    Private Sub ITalk_CheckBox1_CheckedChanged(sender As Object) Handles ITalk_CheckBox1.CheckedChanged

    End Sub
End Class
