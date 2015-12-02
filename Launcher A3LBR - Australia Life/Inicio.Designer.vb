<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ITalk_ThemeContainer1 = New Launcher_A3LBR___Australia_Life.iTalk.iTalk_ThemeContainer()
        Me.ITalk_Label6 = New Launcher_A3LBR___Australia_Life.iTalk.iTalk_Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ITalk_Button_11 = New Launcher_A3LBR___Australia_Life.iTalk.iTalk_Button_1()
        Me.ITalk_ThemeContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ITalk_ThemeContainer1
        '
        Me.ITalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Button_11)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ITalk_Label6)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.Label1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.ProgressBar1)
        Me.ITalk_ThemeContainer1.Controls.Add(Me.PictureBox1)
        Me.ITalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ITalk_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ITalk_ThemeContainer1.Name = "ITalk_ThemeContainer1"
        Me.ITalk_ThemeContainer1.Padding = New System.Windows.Forms.Padding(3, 28, 3, 28)
        Me.ITalk_ThemeContainer1.Sizable = True
        Me.ITalk_ThemeContainer1.Size = New System.Drawing.Size(662, 240)
        Me.ITalk_ThemeContainer1.SmartBounds = False
        Me.ITalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ITalk_ThemeContainer1.TabIndex = 0
        '
        'ITalk_Label6
        '
        Me.ITalk_Label6.AutoSize = True
        Me.ITalk_Label6.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ITalk_Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.ITalk_Label6.Location = New System.Drawing.Point(12, 221)
        Me.ITalk_Label6.Name = "ITalk_Label6"
        Me.ITalk_Label6.Size = New System.Drawing.Size(63, 13)
        Me.ITalk_Label6.TabIndex = 15
        Me.ITalk_Label6.Text = "Versão: 1.9"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Carregando.."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 183)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(467, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Launcher_A3LBR___Australia_Life.My.Resources.Resources._11994314_880752415337764_721676349_n
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(638, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ITalk_Button_11
        '
        Me.ITalk_Button_11.BackColor = System.Drawing.Color.Transparent
        Me.ITalk_Button_11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ITalk_Button_11.Image = Nothing
        Me.ITalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ITalk_Button_11.Location = New System.Drawing.Point(484, 167)
        Me.ITalk_Button_11.Name = "ITalk_Button_11"
        Me.ITalk_Button_11.Size = New System.Drawing.Size(166, 40)
        Me.ITalk_Button_11.TabIndex = 16
        Me.ITalk_Button_11.Text = "Clique para entra"
        Me.ITalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 240)
        Me.Controls.Add(Me.ITalk_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ITalk_ThemeContainer1.ResumeLayout(False)
        Me.ITalk_ThemeContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ITalk_ThemeContainer1 As Launcher_A3LBR___Australia_Life.iTalk.iTalk_ThemeContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ITalk_Label6 As Launcher_A3LBR___Australia_Life.iTalk.iTalk_Label
    Friend WithEvents ITalk_Button_11 As Launcher_A3LBR___Australia_Life.iTalk.iTalk_Button_1
End Class
