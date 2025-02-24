using DevExpress.Pdf;
using System.Diagnostics;

namespace CopyPage
{
    class Program
    {
        static void Main(string[] args)
        {

            using (PdfDocumentProcessor source = new PdfDocumentProcessor())
            {
                source.LoadDocument("..\\..\\..\\Document1.pdf");
                using (PdfDocumentProcessor target = new PdfDocumentProcessor())
                {
                    target.LoadDocument("..\\..\\..\\Document2.pdf");
                    target.Document.Pages.Insert(3, source.Document.Pages[0]);
                    target.SaveDocument("..\\..\\..\\Result.pdf");
                }
            }
            Process.Start(new ProcessStartInfo("..\\..\\..\\Result.pdf") { UseShellExecute = true });
        }
    }
}