namespace Singleton
{
    public class Policy
    {
        //First approach for a thread-safe singleton

        //private static readonly object _lock = new object();

        //private static Policy _instance;

        //public static Policy Instance
        //{
        //    get {
        //        lock (_lock)
        //        {

        //            if (_instance == null)
        //            {
        //                _instance = new Policy();
        //            }

        //            return _instance;
        //        }
        //    }
        //}

        //Second approach for a thread-safe singleton

        private static readonly Policy _instance = new Policy();

        public static Policy Instance
        {
            get
            {
                return _instance;
            }
        }


        public Policy()
        {

        }

        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }
}
