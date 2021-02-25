using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DataAccessLayer
{
    public class PersonelContext : DbContext
    {
        //PersonelContext hangi veritabanına yazacağını bilmiyor
        public PersonelContext():base("PersonelContext") //base class'ına connection string'i göndereceğim(appconfig)
        {

        }
        //DAL katmanı referans olarak Domains katmanını almak zorunda
        //PersonelContext DbContext'ten miras alacağı için EF dll'lerini DAL projeme eklemem gerekiyor.
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }       
    }
}
