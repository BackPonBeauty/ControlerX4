<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.stb1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.jumpbox1 = New System.Windows.Forms.PictureBox()
        Me.beatbox1 = New System.Windows.Forms.PictureBox()
        Me.chargebox1 = New System.Windows.Forms.PictureBox()
        Me.shiftbox1 = New System.Windows.Forms.PictureBox()
        Me.joybox1 = New System.Windows.Forms.PictureBox()
        Me.Surround = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tt1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pict_S = New System.Windows.Forms.PictureBox()
        Me.Pict_B = New System.Windows.Forms.PictureBox()
        Me.Pict_C = New System.Windows.Forms.PictureBox()
        Me.Pict_J = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.stb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jumpbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beatbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chargebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.joybox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_S, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pict_J, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Meiryo UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(140, 954)
        Me.RichTextBox1.TabIndex = 58
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.stb1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.jumpbox1)
        Me.Panel1.Controls.Add(Me.beatbox1)
        Me.Panel1.Controls.Add(Me.chargebox1)
        Me.Panel1.Controls.Add(Me.shiftbox1)
        Me.Panel1.Location = New System.Drawing.Point(98, 985)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 65)
        Me.Panel1.TabIndex = 57
        '
        'stb1
        '
        Me.stb1.BackgroundImage = CType(resources.GetObject("stb1.BackgroundImage"), System.Drawing.Image)
        Me.stb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stb1.ErrorImage = CType(resources.GetObject("stb1.ErrorImage"), System.Drawing.Image)
        Me.stb1.InitialImage = Nothing
        Me.stb1.Location = New System.Drawing.Point(120, 47)
        Me.stb1.Name = "stb1"
        Me.stb1.Size = New System.Drawing.Size(10, 10)
        Me.stb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stb1.TabIndex = 55
        Me.stb1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(5, -45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'jumpbox1
        '
        Me.jumpbox1.BackgroundImage = CType(resources.GetObject("jumpbox1.BackgroundImage"), System.Drawing.Image)
        Me.jumpbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.jumpbox1.ErrorImage = CType(resources.GetObject("jumpbox1.ErrorImage"), System.Drawing.Image)
        Me.jumpbox1.InitialImage = Nothing
        Me.jumpbox1.Location = New System.Drawing.Point(89, 21)
        Me.jumpbox1.Name = "jumpbox1"
        Me.jumpbox1.Size = New System.Drawing.Size(16, 16)
        Me.jumpbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jumpbox1.TabIndex = 35
        Me.jumpbox1.TabStop = False
        '
        'beatbox1
        '
        Me.beatbox1.BackgroundImage = CType(resources.GetObject("beatbox1.BackgroundImage"), System.Drawing.Image)
        Me.beatbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.beatbox1.InitialImage = Nothing
        Me.beatbox1.Location = New System.Drawing.Point(54, 24)
        Me.beatbox1.Name = "beatbox1"
        Me.beatbox1.Size = New System.Drawing.Size(16, 16)
        Me.beatbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.beatbox1.TabIndex = 33
        Me.beatbox1.TabStop = False
        '
        'chargebox1
        '
        Me.chargebox1.BackgroundImage = CType(resources.GetObject("chargebox1.BackgroundImage"), System.Drawing.Image)
        Me.chargebox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.chargebox1.InitialImage = Nothing
        Me.chargebox1.Location = New System.Drawing.Point(71, 16)
        Me.chargebox1.Name = "chargebox1"
        Me.chargebox1.Size = New System.Drawing.Size(16, 16)
        Me.chargebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.chargebox1.TabIndex = 34
        Me.chargebox1.TabStop = False
        '
        'shiftbox1
        '
        Me.shiftbox1.BackgroundImage = CType(resources.GetObject("shiftbox1.BackgroundImage"), System.Drawing.Image)
        Me.shiftbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.shiftbox1.InitialImage = Nothing
        Me.shiftbox1.Location = New System.Drawing.Point(49, 41)
        Me.shiftbox1.Name = "shiftbox1"
        Me.shiftbox1.Size = New System.Drawing.Size(16, 16)
        Me.shiftbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shiftbox1.TabIndex = 32
        Me.shiftbox1.TabStop = False
        '
        'joybox1
        '
        Me.joybox1.BackColor = System.Drawing.Color.Transparent
        Me.joybox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.joybox1.Location = New System.Drawing.Point(12, 951)
        Me.joybox1.Name = "joybox1"
        Me.joybox1.Size = New System.Drawing.Size(96, 96)
        Me.joybox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.joybox1.TabIndex = 31
        Me.joybox1.TabStop = False
        '
        'Surround
        '
        Me.Surround.Enabled = True
        Me.Surround.Interval = 1
        '
        'tt1
        '
        Me.tt1.Interval = 1000
        '
        'Pict_S
        '
        Me.Pict_S.Location = New System.Drawing.Point(144, 500)
        Me.Pict_S.Name = "Pict_S"
        Me.Pict_S.Size = New System.Drawing.Size(6, 500)
        Me.Pict_S.TabIndex = 75
        Me.Pict_S.TabStop = False
        '
        'Pict_B
        '
        Me.Pict_B.Location = New System.Drawing.Point(160, 500)
        Me.Pict_B.Name = "Pict_B"
        Me.Pict_B.Size = New System.Drawing.Size(6, 500)
        Me.Pict_B.TabIndex = 74
        Me.Pict_B.TabStop = False
        '
        'Pict_C
        '
        Me.Pict_C.Location = New System.Drawing.Point(176, 500)
        Me.Pict_C.Name = "Pict_C"
        Me.Pict_C.Size = New System.Drawing.Size(6, 500)
        Me.Pict_C.TabIndex = 73
        Me.Pict_C.TabStop = False
        '
        'Pict_J
        '
        Me.Pict_J.Location = New System.Drawing.Point(192, 500)
        Me.Pict_J.Name = "Pict_J"
        Me.Pict_J.Size = New System.Drawing.Size(6, 500)
        Me.Pict_J.TabIndex = 72
        Me.Pict_J.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(216, 1050)
        Me.Controls.Add(Me.Pict_S)
        Me.Controls.Add(Me.Pict_B)
        Me.Controls.Add(Me.Pict_C)
        Me.Controls.Add(Me.Pict_J)
        Me.Controls.Add(Me.joybox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ControlerX4"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.Panel1.ResumeLayout(False)
        CType(Me.stb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jumpbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beatbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chargebox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.joybox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_S, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pict_J, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents stb1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents joybox1 As PictureBox
    Friend WithEvents jumpbox1 As PictureBox
    Friend WithEvents beatbox1 As PictureBox
    Friend WithEvents chargebox1 As PictureBox
    Friend WithEvents shiftbox1 As PictureBox
    Friend WithEvents Surround As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tt1 As Timer
    Friend WithEvents Pict_S As PictureBox
    Friend WithEvents Pict_B As PictureBox
    Friend WithEvents Pict_C As PictureBox
    Friend WithEvents Pict_J As PictureBox
End Class
