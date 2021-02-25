using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccessLayer.Repositories.Abstract
{
    public interface IPersonelRepository:IRepository<Personel>
    {
       IEnumerable<Personel> GetPersonelsWithDepartments();
    }
}
