using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace Teams.UnitTests
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private const string EmployeeServicePath = @"D:\TeamProject\TeamProject\EmployeeService\bin\Debug\netcoreapp2.1\EmployeeService.dll";
        private const string EmployeeServiceUrl = "http://localhost:5002/";
        PowerShell _ps;
        RestClient _employeeService;

        [TestInitialize]
        public void Startup()
        {
            var serverStartTask = Task.Factory.StartNew(() =>
            {
                _ps = PowerShell.Create();
                _ps.AddScript($"dotnet {EmployeeServicePath} --urls={EmployeeServiceUrl}").Invoke();
            });
            Task.Delay(2000).Wait();
            _employeeService = new RestClient(EmployeeServiceUrl);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _ps?.Stop();
            _ps?.Dispose();
        }

        [TestMethod]
        public void Test()
        {
            var postRequest = new RestRequest("api/Employees", Method.POST, DataFormat.Json);
            postRequest.AddJsonBody(new
            {
                FirstName = "a1",
                SecondName = "a2",
                LastName ="a3"
            });
           var response = _employeeService.Post(postRequest);


        }
    }
}
