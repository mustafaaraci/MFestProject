1)ilk olarak dotnet new mvc -o MfestProject -f net7.0 komutunu kullanarak mvc projemizi oluşturduk
2)static verilerimizin oldugu dosyamızı 
dotnet libman init -p cdnjs
libman install bootstrap@5.3.1 -d wwwroot\lib\bootstrap  komutlarını kullanarak oluşturduk
3)Anasayfa tasarımımızı partial razor sayfaları oluşturarak tasarladık.navbarı layout içersinde oluşturduk.
HeroSection,Tabcard,Footer razor larımızı oluşturup Layout'a partial olarak ekledik.
4)kullanıcı girisi için UserController oluşturuldu view tarafında user adında bir klasor oluturuldu ve içersine Login razor dosyası oluşturuldu model kısmında LoginViewModel adında model oluşturuldu.
5)Projenin ayaga kaldırılması için bağımlılıkarımızı kurmak için
//dotnet restore// komutunu kullanarak gerekli kütüphanelerin otomatik indirilmesini sağlıyoruz.
ardından //dotnet watch run //Bu komut, projeyi derledikten sonra otomatik olarak başlatıyor ve projemizi ayaga kaldırmış oluyoruz.
6)Projemiz içersinde genel olarak Yeşil renk kullanıldı.Bunun sebebi ise Yeşil yaşamı, gençliği, yenilenmeyi, ümitleri ve dinçliği simgeler.Yeşil, gözler için en rahat renktir ve görme gücünü artırır. Sakinleştiricidir ve sinir sistemi üzerinde doğal bir etki yapar.