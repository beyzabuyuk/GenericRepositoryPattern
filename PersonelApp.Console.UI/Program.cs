using PersonelApp.DataAccessLayer;
using PersonelApp.Domains;
using System;

namespace PersonelApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());
            //Ram'e ekleme işlemi
            unitOfWork.DepartmentRepository.Add(new Department() {Name = "Muhasebe", IsActive = true, CreatedDate=DateTime.Now });
         
            //Ram'e ekleme işlemi
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Pazarlama", IsActive = true, CreatedDate = DateTime.Now });

            unitOfWork.Complete();
        }
    }
}
