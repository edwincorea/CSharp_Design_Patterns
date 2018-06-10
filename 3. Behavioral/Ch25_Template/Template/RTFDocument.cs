using System;

namespace Template
{
    //'ConcreteClass' - concrete class
    public class RTFDocument : DocumentReader
    {
        public override void InterpretDocumentFormat()
        {
            Console.WriteLine("Document file is processed with " +
                "RTF Interpreter");
        }
    }
}
