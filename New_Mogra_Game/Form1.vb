Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    ' 難易度選択
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' スタートボタン(Easy)
        ' モグラを消す
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        ' スタートボタンと終了ボタンを消す
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        ' 残り時間と得点を初期化
        Label1.Text = 30
        Label2.Text = 0
        ' タイマーを起動
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' スタートボタン(Hard)
        ' モグラとネコを消す
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        ' スタートボタンと終了ボタンを消す
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        ' 残り時間と得点を初期化
        Label1.Text = 30
        Label2.Text = 0
        ' タイマーを起動
        Timer3.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' モグラが叩かれたとき
        ' サウンド再生とポイント追加
        ' My.Computer.Audio.Play("get.wav", AudioPlayMode.WaitToComplete)
        Label2.Text += 1
        If Label1.Text = 10 And Label2.Text > 13 Then
            Label1.Text += 5
        End If
        PictureBox1.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        ' ネコが叩かれたとき
        ' サウンド再生とポイントを減らす
        ' My.Computer.Audio.Play("lost.wav", AudioPlayMode.WaitToComplete)
        If Label2.Text > 0 Then
            Label2.Text -= 1
        End If
        PictureBox1.Visible = False
    End Sub
    ' イージーモード
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a, b, x, y As Integer
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        ' 画像の座標を生成
        a = Int(Rnd() * 900) + 10
        b = Int(Rnd() * 600) + 10
        x = Int(Rnd() * 900) + 10
        y = Int(Rnd() * 600) + 10
        ' 画像を移動
        PictureBox1.Location = New Point(x, y)
        PictureBox2.Location = New Point(a, b)
        ' 画像を表示
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub
    ' ハードモード
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim a, b, x, y As Integer
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        ' 画像の座標を生成
        a = Int(Rnd() * 900) + 10
        b = Int(Rnd() * 600) + 10
        x = Int(Rnd() * 900) + 10
        y = Int(Rnd() * 600) + 10
        ' 画像を移動
        PictureBox1.Location = New Point(x, y)
        PictureBox2.Location = New Point(a, b)
        ' 画像を表示
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            PictureBox1.Visible = False
            PictureBox2.Visible = False
        End If
        If Label1.Text < 4 Then
            Label1.ForeColor = Color.Red    ' 3秒以下は赤文字
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
