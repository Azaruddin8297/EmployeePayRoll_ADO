using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPayroll
{
    public class EmpModel
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TexablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
