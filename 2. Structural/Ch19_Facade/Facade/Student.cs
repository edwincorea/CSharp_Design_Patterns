namespace Facade
{
    /// <summary>
    /// Student class
    /// </summary>
    public class Student
    {
        private string _name;

        // Constructor
        public Student(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }
}
