using MyBlazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlazor.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
        Task<CompanySummary> GetCompanySummary();
        Task Add(Department department);
    }
}
