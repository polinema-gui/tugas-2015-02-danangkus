Public Class Form1
    Dim a As Integer
    Dim cek As Byte

    Private Function cekIsi()
        If (layar.Text.Equals("0") Or Me.cek > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub layar_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles kurang.Click
        If (Me.a = 0 Or Me.cek = 2) Then
            Me.a += Convert.ToInt32(layar.Text)
        Else
            Me.a -= Convert.ToInt32(layar.Text)
        End If
        layar.Text = Me.a.ToString
        Me.cek = 1
    End Sub

    Private Sub empat_Click(sender As Object, e As EventArgs) Handles empat.Click
        If (cekIsi()) Then
            layar.Text = "4"
        Else
            layar.Text &= "4"
        End If
    End Sub

    Private Sub dua_Click(sender As Object, e As EventArgs) Handles dua.Click
        If (cekIsi()) Then
            layar.Text = "2"
        Else
            layar.Text &= "2"
        End If
    End Sub

    Private Sub layar_TextChanged_1(sender As Object, e As EventArgs) Handles layar.TextChanged

    End Sub

    Private Sub tiga_Click(sender As Object, e As EventArgs) Handles tiga.Click
        If (cekIsi()) Then
            layar.Text = "3"
        Else
            layar.Text &= "3"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub satu_Click(sender As Object, e As EventArgs) Handles satu.Click
        If (cekIsi()) Then
            layar.Text = "1"
        Else
            layar.Text &= "1"
        End If
    End Sub

    Private Sub lima_Click(sender As Object, e As EventArgs) Handles lima.Click
        If (cekIsi()) Then
            layar.Text = "5"
        Else
            layar.Text &= "5"
        End If
    End Sub

    Private Sub enam_Click(sender As Object, e As EventArgs) Handles enam.Click
        If (cekIsi()) Then
            layar.Text = "6"
        Else
            layar.Text &= "6"
        End If
    End Sub

    Private Sub tujuh_Click(sender As Object, e As EventArgs) Handles tujuh.Click
        If (cekIsi()) Then
            layar.Text = "7"
        Else
            layar.Text &= "7"
        End If
    End Sub

    Private Sub delapan_Click(sender As Object, e As EventArgs) Handles delapan.Click
        If (cekIsi()) Then
            layar.Text = "8"
        Else
            layar.Text &= "8"
        End If
    End Sub

    Private Sub sembilan_Click(sender As Object, e As EventArgs) Handles sembilan.Click
        If (cekIsi()) Then
            layar.Text = "9"
        Else
            layar.Text &= "9"
        End If
    End Sub

    Private Sub nol_Click(sender As Object, e As EventArgs) Handles nol.Click
        If (cekIsi()) Then
            layar.Text = "0"
        Else
            layar.Text &= "0"
        End If
    End Sub

    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        Select Case Me.cek
            Case 1
                layar.Text = Convert.ToString(Me.a - Convert.ToInt32(layar.Text))
            Case 2
                layar.Text = Convert.ToString(Me.a + Convert.ToInt32(layar.Text))
        End Select
        Me.a = 0
    End Sub

    Private Sub tambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        If (Me.cek = 1) Then
            Me.a -= Convert.ToInt32(layar.Text)
        Else
            Me.a += Convert.ToInt32(layar.Text)
        End If
        layar.Text = Me.a.ToString
        Me.cek = 2
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles hapus.Click
        layar.Text = "0"
        Me.a = 0
        Me.cek = 0
    End Sub
End Class
