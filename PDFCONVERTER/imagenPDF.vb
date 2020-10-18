Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class imagenPDF
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                Dim IMAGEN As Image = Image.GetInstance(OpenFileDialog1.FileName)
                IMAGEN.ScalePercent(CInt(txtEscala.Text))
                DOCUMENTO.Add(IMAGEN)
                DOCUMENTO.Close()
                MsgBox("IMAGEN CONVERTIDA A PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class



