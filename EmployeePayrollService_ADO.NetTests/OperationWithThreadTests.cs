using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayrollService_ADO.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService_ADO.net.Tests
{
    [TestClass()]
    public class OperationWithThreadTests
    {
        [TestMethod()]
        public void addEmployeeToPayRollTest()
        {
            List<Employee_details2> employeeDetails = new List<Employee_details2>();
            employeeDetails.Add(new Employee_details2(EmployeeID: 2, FirstName: "Amisha", LastName: "Jain", Gender: "Female", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 1, FirstName: "Disha", LastName: "Jain", Gender: "Female", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Abad", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 3, FirstName: "Roshni", LastName: "John", Gender: "Female", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Abad", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 4, FirstName: "Sagar", LastName: "Kalburgi", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 5, FirstName: "Aarvik", LastName: "Kalburgi", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));

            OperationWithThread operationWIthThreads = new OperationWithThread();
            DateTime StartdateTime = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRoll(employeeDetails);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));

            // Calcuate time for multi-threading
            DateTime StartdateTimeThread = DateTime.Now;
            operationWIthThreads.addEmployeeToPayRollWithThread(employeeDetails);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));


        }


    }
}