# 👨‍🏫 Pratik - Inheritance (Kalıtım Örneği)

Bu proje, C# dilinde **nesne yönelimli programlama (OOP)** prensiplerinden **kalıtım (inheritance)** konusunu basit bir şekilde örneklemek için hazırlanmıştır.

##  Proje Amacı

Temel bir `Person` (kişi) sınıfı üzerinden türeyen `Ogrenci` ve `Ogretmen` sınıfları ile kalıtım yapısını kavratmak hedeflenmiştir. Aynı zamanda miras alınan sınıflar üzerinden **metot çağırma**, **özellik tanımlama** ve **nesne oluşturma** gibi temel konular da pekiştirilmiştir.



##  Sınıf Yapısı

### `Person` (abstract sınıf)
- `Ad`, `Soyad` → Ortak özellikler
- `AdSoyadYazdir()` → Ortak metot

### `Ogrenci` (Person'dan türetilmiş)
- Ek Özellik: `OgrenciNo`
- Metot: `BilgileriYazdir()` → AdSoyad + öğrenci numarası

### `Ogretmen` (Person'dan türetilmiş)
- Ek Özellik: `Maas`
- Metot: `BilgileriYazdir()` → AdSoyad + maaş bilgisi



##  Uygulama Akışı

1. `Ogrenci` ve `Ogretmen` sınıflarından örnek nesneler oluşturulur.
2. Her nesneye ait bilgiler atanır.
3. `BilgileriYazdir()` metoduyla ekrana yazdırılır.




