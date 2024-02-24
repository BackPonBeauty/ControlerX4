Imports SharpDX.XInput


Public Class Form1

    Dim Panb(100) As Panel
    Dim Panc(100) As Panel
    Dim Panj(100) As Panel
    Dim Pans(100) As Panel

    Dim Panb_i As Integer = 0
    Dim Panc_i As Integer = 0
    Dim Panj_i As Integer = 0
    Dim Pans_i As Integer = 0
    Dim Panb_f As Boolean = False
    Dim Panc_f As Boolean = False
    Dim Panj_f As Boolean = False
    Dim Pans_f As Boolean = False

    Dim target_b As Control = Nothing
    Dim target_c As Control = Nothing
    Dim target_j As Control = Nothing
    Dim target_s As Control = Nothing

    Dim ww As Integer = 6
    Dim nn As Integer = 2
    Dim endn As Integer = 490

    Dim lastLine_bin As String = ""
    'Dim tfmax = 180
    'Dim tfi = 5000
    'Dim em2len = 3000
    Dim Center_i As Integer = 0
    Dim siz As Integer = 16
    Dim etime1 As Integer = 0
    Dim Lvr_bin As String = "0000"
    Dim butt_bin As String = "9999"
    Dim buttOn As Boolean = False
    Dim comnd1 As Boolean = True
    Dim comnd2 As Boolean = True
    Dim mode = 3

    Private mousePoint As Point

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jumpbox1.MouseDown
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            mousePoint = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles jumpbox1.MouseMove
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            Me.Left += e.X - mousePoint.X
            Me.Top += e.Y - mousePoint.Y
        End If
    End Sub
    Private Sub SurroundingSub1()

        Dim controller = New SharpDX.XInput.Controller(SharpDX.XInput.UserIndex.One)
        If controller.IsConnected Then
            Dim state = controller.GetState()
            Dim a = state.Gamepad.Buttons

            Dim n As String = TentoTwo(a).PadLeft(16, "0")
            'TextBox1.Text = n
            Dim lever As String = Strings.Right(n, 4)
            Dim n1 = "0"
            Dim n2 = "0"
            Dim n3 = "0"
            Dim n4 = "0"
            Dim x = state.Gamepad.LeftThumbX
            Dim y = state.Gamepad.LeftThumbY

            If (y <> Center_i Or x <> Center_i) And lever = "0000" Then
                If y > Center_i Then
                    n1 = "1"
                End If
                If y < Center_i Then
                    n2 = "1"
                End If
                If x < Center_i Then
                    n3 = "1"
                End If
                If x > Center_i Then
                    n4 = "1"
                End If
                lever = n4 & n3 & n2 & n1
            End If

            joybox1.Image = My.Resources.ResourceManager.GetObject("_" & lever.ToString)

            'Shift
            Dim ss As String = n.Substring(3, 1)
            If ss = "0" Then
                shiftbox1.Image = Nothing
                If comnd2 = True Then
                    target_s = Nothing
                    Pans_f = False
                End If
            Else
                shiftbox1.Image = My.Resources.sd
                If comnd2 = True Then
                    If Pans_f = False Then
                        Pans_f = True
                        Pans(0) = New Panel With {
                                   .Width = ww,
                                   .Height = nn,
                                   .Name = Pans_i.ToString,
                                   .Location = New System.Drawing.Point(0, endn),
                                   .BackColor = Color.FromArgb(192, 40, 247)
                               }
                        Me.Pict_S.Controls.Add(Pans(0))
                    End If
                End If
            End If
            For Each cs As Control In Me.Pict_S.Controls
                If Pans_f = True And cs.Name = "0".ToString Then
                    target_s = cs
                    target_s.Height += nn
                Else
                    cs.Name = "1"
                End If
                If cs.Top <= 0 - cs.Height Then
                    Me.Pict_S.Controls.Remove(cs)
                Else
                    cs.Top -= nn
                End If
            Next

            'Beat
            Dim bb As String = n.Substring(1, 1)
            If bb = "0" Then
                beatbox1.Image = Nothing
                If comnd2 = True Then
                    target_b = Nothing
                    Panb_f = False
                End If
            Else
                beatbox1.Image = My.Resources.bd
                If comnd2 = True Then
                    If Panb_f = False Then
                        Panb_f = True
                        Panb(0) = New Panel With {
                                       .Width = ww,
                                       .Height = nn,
                                       .Name = Panb_i.ToString,
                                       .Location = New System.Drawing.Point(0, endn),
                                       .BackColor = Color.FromArgb(255, 128, 0)
                                   }
                        Me.Pict_B.Controls.Add(Panb(0))
                    End If
                End If
            End If
            For Each cb As Control In Me.Pict_B.Controls
                If Panb_f = True And cb.Name = "0".ToString Then
                    target_b = cb
                    target_b.Height += nn
                Else
                    cb.Name = "1"
                End If
                If cb.Top <= 0 - cb.Height Then
                    Me.Pict_B.Controls.Remove(cb)
                Else
                    cb.Top -= nn
                End If
            Next

            'Charge
            Dim cc As String = n.Substring(0, 1)
            If cc = "0" Then
                chargebox1.Image = Nothing
                If comnd2 = True Then
                    target_c = Nothing
                    Panc_f = False
                End If
            Else
                chargebox1.Image = My.Resources.cd
                If comnd2 = True Then
                    If Panc_f = False Then
                        Panc_f = True
                        Panc(0) = New Panel With {
                                       .Width = ww,
                                       .Height = nn,
                                       .Name = Panc_i.ToString,
                                       .Location = New System.Drawing.Point(0, endn),
                                       .BackColor = Color.Red
                                   }
                        Me.Pict_C.Controls.Add(Panc(0))
                    End If
                End If
            End If
            For Each cch As Control In Me.Pict_C.Controls
                If Panc_f = True And cch.Name = "0".ToString Then
                    target_c = cch
                    target_c.Height += nn
                Else
                    cch.Name = "1"
                End If
                If cch.Top <= 0 - cch.Height Then
                    Me.Pict_C.Controls.Remove(cch)
                Else
                    cch.Top -= nn
                End If
            Next

            'Jump
            Dim jj As String = n.Substring(6, 1)
            If jj = "0" Then
                jumpbox1.Image = Nothing
                If comnd2 = True Then
                    target_j = Nothing
                    Panj_f = False
                End If
            Else
                jumpbox1.Image = My.Resources.jd
                If comnd2 = True Then
                    If Panj_f = False Then
                        Panj_f = True
                        Panj(0) = New Panel With {
                                       .Width = ww,
                                       .Height = nn,
                                       .Name = Panj_i.ToString,
                                       .Location = New System.Drawing.Point(0, endn),
                                       .BackColor = Color.Yellow
                                   }
                        Me.Pict_J.Controls.Add(Panj(0))
                    End If
                End If
            End If

            For Each cj As Control In Me.Pict_J.Controls
                    If Panj_f = True And cj.Name = "0".ToString Then
                        target_j = cj
                        target_j.Height += nn
                    Else
                        cj.Name = "1"
                    End If
                    If cj.Top <= 0 - cj.Height Then
                        Me.Pict_J.Controls.Remove(cj)
                    Else
                        cj.Top -= nn
                    End If
                Next


                'Dim sl As String = n.Substring(10, 1)
                'If sl = "1" And slf1 = 0 Then
                '    slf1 = 1
                'ElseIf sl = 0 Then
                '    slf1 = 0
                'End If

                If comnd1 = True Then
                etime1 += 1
                Dim buttons As String = "b" & ss & bb & cc & jj
                If (buttons <> "0000" And buttons <> butt_bin.ToString) Then
                    If etime1 > 99 Then
                        etime1 = 0
                        RichTextBox1.Text = ""
                    End If
                    Dim etime0 As String = etime1.ToString("000")
                    RichTextBox1.AppendText(vbCrLf & etime0 & " : ")
                    butt_bin = buttons
                    '.Image = My.Resources.bd
                    'Using fs As System.IO.FileStream = New System.IO.FileStream(My.Resources.ResourceManager.GetObject(buttons.ToString),
                    'System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    'Dim bmp As Bitmap = New Bitmap(System.Drawing.Image.FromStream(fs))
                    Dim bmpB As Bitmap = My.Resources.ResourceManager.GetObject(buttons.ToString)
                    bmpB = New Bitmap(bmpB, CInt(siz * 4), CInt(siz))
                    Clipboard.SetDataObject(bmpB, True)
                    'End Using
                    Dim iData2 As IDataObject = Clipboard.GetDataObject()
                    If iData2.GetDataPresent(DataFormats.Bitmap) Then
                        RichTextBox1.Paste()
                    End If
                    Lvr_bin = lever
                    'Using fs As System.IO.FileStream = New System.IO.FileStream("include\l" & lever & ".png",
                    'System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    'Dim bmp As Bitmap = New Bitmap(System.Drawing.Image.FromStream(fs))
                    Dim bmpL As Bitmap = My.Resources.ResourceManager.GetObject("l" & lever.ToString)
                    bmpL = New Bitmap(bmpL, CInt(siz), CInt(siz))
                    Clipboard.SetDataObject(bmpL, True)
                    'End Using
                    Dim iData1 As IDataObject = Clipboard.GetDataObject()
                    If iData1.GetDataPresent(DataFormats.Bitmap) Then
                        RichTextBox1.Paste()
                    End If
                    RichTextBox1.ScrollToCaret()
                    etime1 = 0
                    buttOn = True
                End If

                If (lever <> Lvr_bin) Then
                    If etime1 > 99 Then
                        etime1 = 0
                        RichTextBox1.Text = ""
                    End If
                    Dim etime0 As String = etime1.ToString("000")
                    RichTextBox1.AppendText(vbCrLf & etime0 & " : ")
                    'Using fs As System.IO.FileStream = New System.IO.FileStream("include\" & buttons & ".png",
                    '                                              System.IO.FileMode.Open, System.IO.FileAccess.Read)
                    '    Dim bmp As Bitmap = New Bitmap(System.Drawing.Image.FromStream(fs))
                    Dim bmpB As Bitmap = My.Resources.ResourceManager.GetObject(buttons.ToString)
                    bmpB = New Bitmap(bmpB, CInt(siz * 4), CInt(siz))
                    Clipboard.SetDataObject(bmpB, True)
                    'End Using
                    Dim iData2 As IDataObject = Clipboard.GetDataObject()
                    If iData2.GetDataPresent(DataFormats.Bitmap) Then
                        RichTextBox1.Paste()
                    End If
                    Lvr_bin = lever
                    Dim bmpL As Bitmap = My.Resources.ResourceManager.GetObject("l" & lever.ToString)
                    bmpL = New Bitmap(bmpL, CInt(siz), CInt(siz))
                    Clipboard.SetDataObject(bmpL, True)
                    Dim iData1 As IDataObject = Clipboard.GetDataObject()
                    If iData1.GetDataPresent(DataFormats.Bitmap) Then
                        RichTextBox1.Paste()
                    End If
                    etime1 = 0
                    RichTextBox1.ScrollToCaret()
                End If
            End If
        Else
            joybox1.Image = Nothing
        End If
    End Sub

    Private Function TentoTwo(ByVal value As String) As String
        If Math.Floor(value / 2) Then
            Return TentoTwo(Math.Floor(value / 2)) + CStr(value Mod 2)
        End If
        Return CStr(value Mod 2)
    End Function


    Private Sub Surround_Tick(sender As Object, e As EventArgs) Handles Surround.Tick
        SurroundingSub1()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Me.TopMost = True
    End Sub

    Private Sub jumpbox1_Click(sender As Object, e As MouseEventArgs) Handles jumpbox1.DoubleClick
        If Me.WindowState <> FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub shiftbox1_Click(sender As Object, e As EventArgs) Handles shiftbox1.DoubleClick
        Me.Close()
    End Sub

    Private Sub beatbox1_Click(sender As Object, e As EventArgs) Handles beatbox1.Click
        If Center_i = 0 Then
            Center_i = 128
        Else
            Center_i = 0
        End If
    End Sub

    Private Sub chargebox1_Click(sender As Object, e As EventArgs) Handles chargebox1.Click
        Select Case mode
            Case 3
                comnd1 = False
                comnd2 = False
            Case 2
                comnd1 = True
                comnd2 = False
            Case 1
                comnd1 = False
                comnd2 = True
            Case 0
                comnd1 = True
                comnd2 = True
        End Select
        If mode > 0 Then
            mode -= 1
        Else
            mode = 3
        End If
        RichTextBox1.Text = ""
    End Sub
End Class