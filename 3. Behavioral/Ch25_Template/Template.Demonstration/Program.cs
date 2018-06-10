using System;

/// <summary>
/// This code demonstrates how a document reader will use the
/// correct kind of interpreter to either read a PDF or RTF
/// </summary>
namespace Template.Demonstration
{
    /// <summary> 
    /// Template Method Pattern.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- Document Reader - PDF doc ----");
            DocumentReader documenteReader = new PDFDocument();
            documenteReader.OpenDocument();

            Console.WriteLine("---- Document Reader - RTF doc ----");
            documenteReader = new RTFDocument();
            documenteReader.OpenDocument();

            Console.ReadKey();

        }
    }
}
