Imports System.Net, System.IO
Public Class Registro

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox4.Text = Hwid.GetID
    End Sub

    Private Sub ITalk_Button_11_Click(sender As Object, e As EventArgs) Handles ITalk_Button_11.Click
        If TextBox1.Text <> String.Empty And TextBox2.Text <> String.Empty And TextBox3.Text <> String.Empty Then
            Hwid.RegisterUser(TextBox2.Text, TextBox3.Text, TextBox1.Text)
        Else
            MsgBox("Você deve preencher todos os campos", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub ITalk_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ITalk_LinkLabel1.LinkClicked
        Process.Start("http://arma3lifebrasil.com.br/foruns/profile/1-renildomarcio/")
    End Sub

    Private Sub ITalk_Button_21_Click(sender As Object, e As EventArgs) Handles ITalk_Button_21.Click
        Codigo_Launcher.Show()
    End Sub
End Class