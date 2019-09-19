using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//using org.pdfclown;
//using org.pdfclown.tools;
//using org.pdfclown.documents.contents;
//using Spire.Pdf;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace ExtractText_pdfclown
{
    class Program
    {
        //static void ExtractText(FileInfo file, StreamWriter stream)
        //{
        //    //FileInfo fi = new FileInfo(@"C:\Users\swite\Desktop\Praktikum_po_informatike.pdf");

        //    //FileStream f = File.Open(@"C:\Users\swite\Desktop\Praktikum_po_informatike.pdf", FileMode.Open);
        //    //StreamReader sr = new StreamReader(f);
        //    //TextExtractor te = new TextExtractor();
        //    //te.Extract()

        //    PdfDocument document = new PdfDocument();
        //    Console.WriteLine("Extract Text from PDF File: {0}", file.Name);
        //    document.LoadFromFile(file.FullName);
        //    foreach (PdfPageBase page in document.Pages)
        //    {
        //        string content = page.ExtractText();
        //        string content2 = new string(content.Skip(70).Take(content.Length - 70 - 66).ToArray());
        //        stream.Write(content2);
        //    }
        //}

        static void Main(string[] args)
        {
            //DirectoryInfo di = new DirectoryInfo(@"C:\Users\swite\Desktop\SPbGU_diplomas_2018");
            //DirectoryInfo di = new DirectoryInfo(@"C: \Users\Sweater\YandexDisk\diplom\SPbGU_diplomas_2018");
            //FileStream fi = new FileStream(@"C:\Users\swite\Desktop\SPbGU_diplomas.txt", FileMode.Create);
            //StreamWriter sw = new StreamWriter(fi, Encoding.Unicode);
            //foreach (FileInfo file in di.GetFiles())
            //{
            //    ExtractText(file, sw);
            //    sw.Write(" џ\n");
            //}

            //PdfDocument document = new PdfDocument();
            //Console.WriteLine("Extract Text from PDF Test");
            //document.LoadFromFile(@"C: \Users\Sweater\YandexDisk\diplom\SPbGU_diplomas_2018\441-Akbarov-report.pdf");
            //foreach (PdfPageBase page in document.Pages)
            //{
            //    string content = page.ExtractText();
            //    string content2 = new string(content.Skip(70).Take(content.Length - 70 - 66).ToArray());
            //    Console.Write(content2);
            //    Console.ReadKey();
            //}

            Console.WriteLine("Extract text from PDF using iTextSharp");
            //PDFParser parser = new PDFParser();
            //bool succ = parser.ExtractText(@"C:\Users\Sweater\YandexDisk\diplom\SPbGU_diplomas_2018\441-Akbarov-report.pdf", @"C:\Users\Sweater\Desktop\441-Akbarov-report.txt");
            ////bool succ = parser.ExtractText(@"C:\Users\Sweater\Desktop\VTKUsersGuide.pdf", @"C:\Users\Sweater\Desktop\441-Akbarov-report.txt");
            //Console.WriteLine("Text {0}", succ ? "extracted" : "not extracted");
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Sweater\YandexDisk\diplom\SPbGU_diplomas_2018");
            FileStream fi = new FileStream(@"C:\Users\Sweater\Desktop\SPbGU_diplomas.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fi, Encoding.Unicode);
            foreach (FileInfo file in di.GetFiles())
            {
                PdfReader reader = new PdfReader(file.FullName);
                for (int i = 1; i <= reader.NumberOfPages; ++i)
                {
                    string text = PdfTextExtractor.GetTextFromPage(reader, i, new SimpleTextExtractionStrategy());
                    sw.Write(text);
                }

                sw.Write("\nџ\n");
            }

            Console.WriteLine("DONE!!!");
            Console.ReadKey();
        }
    }
}
