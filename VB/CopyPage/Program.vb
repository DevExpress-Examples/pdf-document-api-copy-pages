Imports DevExpress.Pdf

Namespace CopyPage
    Friend Class Program
        Shared Sub Main(ByVal args() As String)

            Using source As New PdfDocumentProcessor()
                source.LoadDocument("..\..\Document1.pdf")
                Using target As New PdfDocumentProcessor()
                    target.LoadDocument("..\..\Document2.pdf")
                    target.Document.Pages.Insert(3, source.Document.Pages(0))
                    target.SaveDocument("..\..\Result.pdf")
                End Using
            End Using
        End Sub
    End Class
End Namespace