using System.Collections.Generic;

namespace Adapter
{
    // 'Adaptee' class
    public class ThirdPartyEmployee
    {
        public List<string> GetEmployeeList()
        {
            List<string> EmployeeList = new List<string>
            {
                "Peter",
                "Paul",
                "Puru",
                "Preethi"
            };

            return EmployeeList;
        }
    }
}
