using System;

namespace Template
{
    //'ConcreteClass'- concrete class
    public class PDFDocument : DocumentReader
    {
        public override void InterpretDocumentFormat()
        {
            Console.WriteLine("Document file is processed with " +
                "PDF Interpreter");
        }
    }
}
