using PersonelApp.DataAccessLayer.Repositories.Abstract;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccessLayer.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        //context nesnesi alması lazım
        //base class'ına yani repository'de bizden bir dbContext istiyordu
        //personel context de dbcontext'ten türüyor.
        //Her personel context aslında bir dbcontext
        public DepartmentRepository(PersonelContext context) : base(context)
        {
   
        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            return PersonelContext.Departments.Include("Personels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }

        //Property
        //_context'i PersonelContext'e cast işlemi
        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
