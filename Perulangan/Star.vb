Public Class Star

    Dim HASIL As String = ""

    Private Sub tombol_proses_Click(sender As Object, e As EventArgs) Handles tombol_proses.Click
        Try
            Select Case combo_pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(textbox_baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(textbox_baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(textbox_baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(textbox_baris.Text))
                Case Else
                    textbox_hasil.Text = "Anda Belum Memilih Polanya"
            End Select
        Catch ex As Exception
            textbox_hasil.Text = "Input Anda Bukan Angka"
        End Try
    End Sub


    Private Sub pyramid(batas As Integer)
        Dim bataskolom1 As Integer = batas
        Dim bataskolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < bataskolom1 Or kolom > bataskolom2) Then
                    Me.HASIL &= "  "
                Else
                    Me.HASIL &= "*"
                End If
            Next
            bataskolom1 -= 1
            bataskolom2 += 1
            Me.HASIL &= vbCrLf
        Next
        textbox_hasil.Text = HASIL
        HASIL = ""
    End Sub


    Private Sub hollowPyramid(batas As Integer)
        Dim bataskolom3 As Integer = batas
        Dim bataskolom4 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = bataskolom3 Or kolom = bataskolom4) Then
                        Me.HASIL &= "*"
                    Else
                        Me.HASIL &= "  "
                    End If
                Else
                    Me.HASIL &= "*"
                End If
            Next
            bataskolom3 -= 1
            bataskolom4 += 1
            Me.HASIL &= vbCrLf
        Next
        textbox_hasil.Text = HASIL
        HASIL = ""
    End Sub


    Private Sub invertedPyramid(batas As Integer)
        Dim bataskolom5 As Integer = 0
        Dim bataskolom6 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > bataskolom5 And kolom < bataskolom6) Then
                    Me.HASIL &= "*"
                Else
                    Me.HASIL &= "  "
                End If
            Next
            Me.HASIL &= vbCrLf
            bataskolom5 += 1
            bataskolom6 -= 1
        Next
        textbox_hasil.Text = HASIL
        Me.HASIL = ""
    End Sub


    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim bataskolom7 As Integer = 1
        Dim bataskolom8 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.HASIL &= "*"
                Else
                    If (kolom = bataskolom7 Or kolom = bataskolom8) Then
                        Me.HASIL &= "*"
                    Else
                        Me.HASIL &= "  "
                    End If
                End If
            Next
            bataskolom7 += 1
            bataskolom8 -= 1
            Me.HASIL &= vbCrLf
        Next
        textbox_hasil.Text = HASIL
        Me.HASIL = ""
    End Sub

    Private Sub textbox_hasil_TextChanged(sender As Object, e As EventArgs) Handles textbox_hasil.TextChanged

    End Sub
    Private Sub label_pola_Click(sender As Object, e As EventArgs) Handles label_pola.Click

    End Sub
    Private Sub label_baris_Click(sender As Object, e As EventArgs) Handles label_baris.Click

    End Sub
    Private Sub textbox_baris_TextChanged(sender As Object, e As EventArgs) Handles textbox_baris.TextChanged

    End Sub
    Private Sub Combo_pola_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_pola.SelectedIndexChanged

    End Sub
End Class