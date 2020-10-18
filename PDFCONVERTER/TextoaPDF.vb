Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class TextoaPDF


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                DOCUMENTO.Add(New Paragraph(TxtTexto.Text))
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TxtTexto.Clear()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


