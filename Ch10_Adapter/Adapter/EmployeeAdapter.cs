using System.Collections.Generic;

namespace Adapter
{
    // 'Adapter' class
    public class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public List<string> GetEmployees()
        {
            return GetEmployeeList();
        }
    }
}
