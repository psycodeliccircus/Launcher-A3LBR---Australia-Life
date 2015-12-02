Public Class Inicio

    Public Function IsAdmin() As Boolean
        Dim id As System.Security.Principal.WindowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim p As System.Security.Principal.WindowsPrincipal = New System.Security.Principal.WindowsPrincipal(id)
        Return p.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)
    End Function

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsAdmin() = True Then
        Else
            MsgBox("Programa deve ser aberto em modo administrador", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 5 Then
            Label1.Text = "Carregando AntiCheat.."
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = "Carregando Modulos.."
        End If
        If ProgressBar1.Value = 25 Then
            Label1.Text = "Carregando Sistema.."
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Verificando.."
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = "Sistema 100% configurador."
        End If
        If ProgressBar1.Value = 46 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Realizando Testes..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Teste realizado 100%"
        End If
        If ProgressBar1.Value = 68 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 70 Then
            Label1.Text = "Carregando Battleye."
        End If
        If ProgressBar1.Value = 78 Then
            Label1.Text = "Battleye carregando 100%"
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 78 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = 98 Then
            Label1.Text = "Carregando.."
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Label1.Text = "Abrindo Launcher.."
            Me.Hide()
            Login.Show()

        End If
    End Sub

    Private Sub ITalk_ThemeContainer1_Click(sender As Object, e As EventArgs) Handles ITalk_ThemeContainer1.Click

    End Sub

    Private Sub ITalk_Button_11_Click(sender As Object, e As EventArgs) Handles ITalk_Button_11.Click
        Timer1.Start()
        Label1.Text = "Carregando.."
    End Sub
End Class