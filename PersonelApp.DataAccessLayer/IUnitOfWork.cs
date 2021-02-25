using PersonelApp.DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccessLayer
{
    //Repository'lerimi burada toplamam gerekiyor
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository DepartmentRepository { get; }
        IPersonelRepository PersonelRepository { get; }

        int Complete();
    }
}
