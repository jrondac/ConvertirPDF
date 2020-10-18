Imports System.IO 'Para trabajar con archivos
Imports iTextSharp.text 'Para trabajar con los pdf
Imports iTextSharp.text.pdf

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnTexto_Click(sender As Object, e As EventArgs) Handles btnTexto.Click
        TextoaPDF.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        imagenPDF.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        unir_Dividir.ShowDialog()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Enabled = False
    End Sub
End Class
