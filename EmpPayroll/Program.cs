namespace EmpPayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmpModel empModel = new EmpModel();
            empModel.EmployeeName = "Azar";
            empModel.Address = "17-107";
            empModel.City = "Atmakur";
            empModel.Country = "India";
            empModel.BasicPay = 12000.00;
            empModel.PhoneNumber= 829721;
            empModel.Gender = 'M';
            empModel.Tax = 1000.00;
            empModel.NetPay = 1000.00;
            empModel.TexablePay = 1000.00;

        }
    }
}