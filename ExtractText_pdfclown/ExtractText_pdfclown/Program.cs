using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spire.Pdf;

//using org.pdfclown;
//using org.pdfclown.tools;
//using org.pdfclown.documents.contents;

namespace ExtractText_pdfclown
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"C:\Users\swite\Desktop\Praktikum_po_informatike.pdf");

            //FileStream f = File.Open(@"C:\Users\swite\Desktop\Praktikum_po_informatike.pdf", FileMode.Open);
            //StreamReader sr = new StreamReader(f);
            //TextExtractor te = new TextExtractor();
            //te.Extract()

            PdfDocument document = new PdfDocument();
            //document.LoadFromFile(@"C:\Users\swite\Desktop\Praktikum_po_informatike.pdf");
            foreach (PdfPageBase page in document.Pages)
            {
                string content = page.ExtractText();
                string content2 = new string(content.Skip(70).Take(content.Length - 70 - 66).ToArray());
                Console.Write(content2);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
