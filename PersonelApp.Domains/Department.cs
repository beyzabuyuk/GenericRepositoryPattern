using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    //Department Entity'si
    public class Department : BaseEntity
    {
        public Department()
        {
            Personels = new List<Personel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //Veri tabanındaki tablolarda ortak olan alanlar var.
        //Tüm kayıtların eklenme tarihini, güncellenme tarihini, silinme tarihini, aktif mi pasif mi
        //Bu alanları ortak olarak tutmak istiyorum.
        //Bunun icin BaseEntity ekliyorum.

        //Bir departmanda birden çok personel bulunabilir.
        //ICollection olduğu için ileride bir null hatası almamak için 
        //Bu listeyi hafızaya çıkarmak gerekiyor.(constructor)
        public ICollection<Personel> Personels { get; set; }
    }
}
