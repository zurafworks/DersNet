using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class OnBasvuru : Entity<Guid>
{
    public Guid PackId { get; set; }//Kullanıcı hangi paket için başvuru yapıyor?
    public Guid LessonId { get; set; }//O öğrencinin eğitim durumunu gösterecek olan kayıt
    public string FirstName { get; set; }//Başvuruyu yapan kullanıcının adı
    public string LastName { get; set; }//Başvuruyu yapan kullanıcının soyadı
    public string VeliFirstName { get; set; }//Öğrencinin velisinin adı
    public string VeliLastName { get; set; }//Öğrencinin velisinin soyadı
    public double NotOrtalamasi { get; set; }//Öğrencinin son bitirdiği senenin not ortalaması
    public string OkulAdi { get; set; }//Ogrencinin okulunun adı
    public string VeliCepNo { get; set; }//Öğrencinin velisinin telefon numarası
    public string OgrCepNo { get; set; }//Öğrencinin telefon numarası
}
