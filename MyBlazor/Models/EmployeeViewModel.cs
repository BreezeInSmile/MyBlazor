using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using MyBlazor.Services;

namespace MyBlazor.Models
{
    public class EmployeeViewModel : ComponentBase
    {
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<MyBlazor.Models.Employee> Employees;

        [Inject]
        protected IEmployeeService _employeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await _employeeService.GetByDepartmentId(Convert.ToInt32(DepartmentId));
        }

    }
}
