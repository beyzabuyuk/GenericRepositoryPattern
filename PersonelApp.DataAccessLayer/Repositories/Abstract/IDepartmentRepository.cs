using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccessLayer.Repositories.Abstract
{
    //Departmana özgü işlemler
    public interface IDepartmentRepository : IRepository<Department>
    {
        IEnumerable<Department> GetTopDepartments(int count);
        IEnumerable<Department> GetDepartmentsWithPersonels();
    }
}
