Public Class Matriks

    Dim cekkolom As Boolean = True


    Private Sub tombol_proses_Click(sender As Object, e As EventArgs) Handles tombol_proses.Click
        Try
            Dim barisMatriks1 As Integer = textbox_matrik1.Lines.Count
            Dim kolomMatriks1 As Integer = textbox_matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = textbox_matrik1.Lines.Count
            Dim kolomMatriks2 As Integer = textbox_matrik1.Lines.ElementAt(0).Split(" ").Length

            Dim copyMatriks1(barisMatriks1, kolomMatriks1) As Integer
            Dim copyMatriks2(barisMatriks2, kolomMatriks2) As Integer
            cek(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2)
            copyToArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, copyMatriks1, copyMatriks2)
            operasi(copyMatriks1, copyMatriks2, barisMatriks1, kolomMatriks2)
        Catch ex As Exception
            MsgBox("Input Anda Bukan Angka")
        End Try
    End Sub


    Private Sub copyToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekkolom) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = textbox_matrik1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = textbox_matrik2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub


    Private Sub cek(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim HASIL As Boolean = True
        For baris = 0 To baris1 - 2
            If (textbox_matrik1.Lines.ElementAt(baris).Split(" ").Length <> textbox_matrik1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                HASIL = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (textbox_matrik2.Lines.ElementAt(baris).Split(" ").Length <> textbox_matrik2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                HASIL = False
            End If
        Next
        If (HASIL = False) Then
            Me.cekkolom = False
            Convert.ToInt32(textbox_matrik1.Text)
            Convert.ToInt32(textbox_matrik2.Text)
            MsgBox("Matriks Yang Anda Inputkan Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.cekkolom = True
        Else
            Me.cekkolom = False
            MsgBox("Baris dan Kolom Pada Semua Matriks Haruslah Sama")
        End If
    End Sub


    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim HASIL As String = ""
        If (Me.cekkolom) Then
            Select Case combo_operasi.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            HASIL &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        HASIL &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            HASIL &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        HASIL &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            textbox_hasil.Text = HASIL
        End If
    End Sub
End Class