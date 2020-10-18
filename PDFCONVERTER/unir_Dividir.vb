Imports System.IO 'Para trabajar con archivos
Imports iTextSharp.text 'Para trabajar con los pdf
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdfPublic

Class unir_Dividir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUnir.Click

        Dim Lista As New List(Of String)

        ' Identificamos los documentos que queremos unir

        Dim sFile1 As String = txtArchivo1.Text
        Dim sFile2 As String = TxtArchivo2.Text

        Lista.Add(sFile1)
        Lista.Add(sFile2)
        Dim sFileJoin As String = “C:\Users\JORGE RONDA\Desktop\ArchivoUnido.pdf”

        Dim Doc As New Document()
        Try

            Dim fs As New FileStream(sFileJoin, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim copy As New PdfCopy(Doc, fs)
            Doc.Open()

            Dim Rd As PdfReader
            Dim n As Integer 'Número de páginas de cada pdf

            For Each file In Lista
                Rd = New PdfReader(file)
                n = Rd.NumberOfPages
                Dim page As Integer = 0
                Do While page < n
                    page += 1
                    copy.AddPage(copy.GetImportedPage(Rd, page))
                Loop

                copy.FreeReader(Rd)
                Rd.Close()
            Next
        Catch ex As Exception

            MsgBox(ex.Message, vbExclamation, “Error uniendo los pdf”)

        Finally

            ' Cerramos el documento

            Doc.Close()
            MsgBox("ARCHIVO GENERARDO Escritorio/ArchivoUnido.pdf")

        End Try
        txtArchivo1.Clear()
        TxtArchivo2.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBuscar.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub BtnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim pdf3 As New PdfReader(txtBuscar.Text)
                Dim pdfnuevo1 As New Document()
                
                Dim pagina1 As New PdfCopy(pdfnuevo1, New FileStream(SaveFileDialog1.FileName, FileMode.Create))

                pdfnuevo1.Open()

                Dim importa1 As PdfImportedPage = pagina1.GetImportedPage(pdf3, 1)

                pagina1.AddPage(importa1)

                pdf3.Close()
                pagina1.Close()
                pdfnuevo1.Close()

                MessageBox.Show("DOCUMENTO 1 CREADO CORRECTAMENTE")


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try
        End If

        If SaveFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim pdf3 As New PdfReader(txtBuscar.Text)
                Dim pdfnuevo2 As New Document()


                Dim pagina2 As New PdfCopy(pdfnuevo2, New FileStream(SaveFileDialog2.FileName, FileMode.Create))

                pdfnuevo2.Open()

                Dim importa2 As PdfImportedPage = pagina2.GetImportedPage(pdf3, 2)

                pagina2.AddPage(importa2)

                pdf3.Close()
                pagina2.Close()
                pdfnuevo2.Close()

                MessageBox.Show("DOCUMENTO 2 CREADO CORRECTAMENTE")


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try
        End If
        txtBuscar.Clear()



    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtArchivo1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnCargar2_Click(sender As Object, e As EventArgs) Handles btnCargar2.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TxtArchivo2.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class

