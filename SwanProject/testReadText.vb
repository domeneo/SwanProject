'Imports WebSupergoo.ABCocr3
Imports Tesseract
Imports System.IO
Public Class testReadText
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim file_name As String = Path.Combine("E:\", "img4.jpg")
        Dim str As String
        'Work
        'Dim bm As Bitmap = DirectCast(Bitmap.FromFile(file_name), Bitmap)
        'Dim ocr As New Ocr()
        'ocr.SetBitmap(bm)


        'Using gr As Graphics = Graphics.FromImage(bm)
        '    gr.PageUnit = GraphicsUnit.Pixel
        '    For Each word As Word In ocr.Page.Words
        '        Dim flags As TextFormatFlags = TextFormatFlags.NoClipping Or TextFormatFlags.NoPadding
        '        TextRenderer.DrawText(gr, word.Text, Font, word.Bounds, Color.Red, flags)

        '        str += word.Text
        '        ' gr.DrawRectangle(Pens.Green, word.Bounds)
        '    Next
        'End Using
        'Console.WriteLine(str)



        'Free
        Using engine As New TesseractEngine("tessdata", "eng", EngineMode.Default)


            Using img = Pix.LoadFromFile(file_name)
                Using page = engine.Process(img)
                    Dim text = page.GetText()
                    Console.Write(text)
                    'Using iter = page.GetIterator()
                    '    iter.Begin()
                    '    Do While iter.Next(PageIteratorLevel.Block)
                    '        Console.Write(iter.GetText(PageIteratorLevel.Word))

                    '        Do While iter.Next(PageIteratorLevel.Block, PageIteratorLevel.Para)
                    '            Do While iter.Next(PageIteratorLevel.Para, PageIteratorLevel.TextLine)

                    '                Do While iter.Next(PageIteratorLevel.TextLine, PageIteratorLevel.Word)
                    '                    Console.Write(iter.GetText(PageIteratorLevel.Word))
                    '                    Console.Write(" ")
                    '                Loop

                    '            Loop
                    '        Loop

                    '    Loop
                    'End Using
                End Using

            End Using
        End Using

    End Sub
End Class