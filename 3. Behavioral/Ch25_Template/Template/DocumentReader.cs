using System;

namespace Template
{
    //'AbstractClass' abstract class
    public abstract class DocumentReader
    {
        //default steps 
        public void LoadFile()
        {
            Console.WriteLine("Document File loaded");
        }

        // steps that will be overidden by subclass
        public abstract void InterpretDocumentFormat();

        // default step
        public void Open()
        {
            Console.WriteLine("Document File open");
        }

        //'Template Method'
        public void OpenDocument()
        {
            this.LoadFile();
            this.InterpretDocumentFormat();
            this.Open();
        }

    }
}
