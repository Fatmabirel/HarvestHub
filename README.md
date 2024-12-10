# HarvestHub: Tarım Yönetim Sistemi 🌾🚜🌿

***HarvestHub***, tarım sektörü odaklı bir yönetim sistemidir. Bu proje, yönetimsel verilerin etkin bir şekilde yönetilmesini sağlayan güçlü bir admin paneli ve kullanıcılar için tarıma dair faydalı içerikler sunan bir platformdur. HarvestHub, iş süreçlerini dijitalleştirerek verimliliği artırmayı ve kullanıcılar için tarım ile ilgili bilgi kaynağı olmayı hedefler.

#### PROJEDE KULLANILAN PROGRAMLAMA DİLLERİ, KÜTÜPHANELER VE TEKNOLOJİLER 💻🔧
<p>
  <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white" />
  <img alt="ASP.NET Core" src="https://img.shields.io/badge/asp.net%20core-%231BA3E8.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="MVC" src="https://img.shields.io/badge/MVC-%23DD0031.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="N Katmanlı Mimari" src="https://img.shields.io/badge/N%20Katmanlı%20Mimari-%237D7D7D.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Entity Framework" src="https://img.shields.io/badge/entity%20framework-%2358B9C9.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="FluentValidation" src="https://img.shields.io/badge/fluentvalidation-%23563D7C.svg?style=for-the-badge&logo=generic&logoColor=white" />
  <img alt="Identity" src="https://img.shields.io/badge/Identity-%233B5998.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="ClosedXml" src="https://img.shields.io/badge/ClosedXml-%23008B8B.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="EPPlus" src="https://img.shields.io/badge/EPPlus-%23FF7F00.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="MSSQL Server" src="https://img.shields.io/badge/MSSQL%20Server-%23FF4F4F.svg?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
</p>

#### 🎯 NASIL BİR PROJE OLUŞTURDUK?
Bu proje, tarımsal süreçlerin dijitalleşmesini sağlayarak verimliliği artırmayı amaçlamaktadır. Sistem, güçlü bir **admin paneli** ile yönetimsel verilerin etkin bir şekilde yönetilmesine olanak tanırken, kullanıcılar için de tarıma dair faydalı içerikler ve bilgiler sunan bir platform oluşturur. 

**HarvestHub**, çiftçiler, üreticiler ve tarım sektöründe faaliyet gösteren tüm kullanıcılar için bilgi kaynağı olmayı hedefler. Proje, kullanıcı dostu arayüzü ile tarım sektörüne dair çeşitli bilgilerin hızlıca erişilmesini sağlar ve iş süreçlerini dijital ortamda yönetme imkanı sunar.

### PROJE DETAYLARI 📝 ###

Projemiz, **ASP.NET Core** ve **MVC** teknolojilerini içeren modern bir web uygulamasıdır. Projede **MsSQL Server** veri tabanı kullanılmış olup, **Code First** yaklaşımı ile veri tabanı yapısı oluşturulmuştur. Veri tabanı işlemleri için **Entity Framework** kullanılmaktadır.

Projemizde **N katmanlı mimari** kullanılarak modüler bir yapı sağlanmıştır. Bu sayede, her bir katman birbirinden bağımsız şekilde geliştirilmiş ve projede sürdürülebilirlik sağlanmıştır.

Ayrıca, projemizde şu önemli kütüphaneler ve araçlar kullanılmıştır:
- **FluentValidation**: Veri doğrulama süreçlerini yönetmek ve kullanıcı girişlerini doğrulamak için.
- **Identity**: Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için güvenli bir çözüm sağlamak amacıyla kullanılmıştır.
- **ClosedXml** ve **EPPlus**: Excel dosyalarını oluşturmak, okumak ve düzenlemek için kullanılmıştır.

Bu sayede, projemiz verimli, yönetilebilir ve güvenli bir yapıya sahiptir. Kullanıcı kimlik doğrulama süreçleri güvenli bir şekilde gerçekleştirilmekte, Excel dosya işlemleri kolaylaştırılmakta ve veritabanı işlemleri sorunsuz bir şekilde yönetilmektedir.

<p> HarvestHub sisteminde iki tip kullanıcı bulunmaktadır: </p>

➡️ **1- Admin/Yönetici**

- [x] **Yönetim Paneli**: Ana panel üzerinden sistemin tüm yönetimini sağlar.
- [x] **Hizmetler**: Tarım hizmetleri ile ilgili bilgileri yönetebilir. Yeni hizmet ekleyebilir, mevcut hizmetleri güncelleyebilir veya silebilir.
- [x] **Ekip Arkadaşları**: Ekip üyelerinin bilgilerini düzenler, yeni ekip üyeleri ekler veya mevcut üyeleri silebilir.
- [x] **Grafikler**: Tarım ile ilgili performans verilerini grafiksel olarak görüntüleyebilir.
- [x] **Duyurular**: Sistemdeki duyuruları yönetebilir, yeni duyurular ekleyebilir veya mevcut duyuruları silebilir.
- [x] **Gelen Mesajlar**: Kullanıcılar tarafından gönderilen mesajları görüntüleyebilir.
- [x] **Adres Bilgileri**: Firma veya tarım alanı ile ilgili adres bilgilerini güncelleyebilir.
- [x] **Galeri**: Görselleri yükleyebilir, galerideki içerikleri düzenleyebilir veya silebilir.
- [x] **Raporlar**: Sistemdeki ***Mesaj Raporları***, ***Duyuru Raporları*** ve ***Statik Rapor*** olmak üzere üç farklı raporu indirebilir:
- [x] **Profil Bilgileri**: Kendi profil bilgilerini görüntüleyebilir ve güncelleyebilir.
- [x] **Yöneticiler**: Diğer admin kullanıcılarını yönetebilir. Yeni admin ekleyebilir, mevcut adminleri güncelleyebilir veya silebilir.

➡️ **2- Ziyaretçi**

- [x] **Tarıma Dair Faydalı İçerikler**: Tarım ile ilgili faydalı bilgilere göz atabilir.
- [x] **Ekip Üyeleri**: Ekip üyelerinin görevlerini ve sosyal medya hesaplarını görüntüleyebilir.
- [x] **Hizmetler**: Tarım sektöründe sunulan hizmetler hakkında detaylı bilgiye ulaşabilir ve hizmetleri görüntüleyebilir.
- [x] **Tarımda Son Haberler**: Tarım sektöründeki en son gelişmeleri ve haberleri takip edebilir.
- [x] **Galeri**: Sistem içerisinde bulunan görsel galeriyi gezebilir, galerideki resimleri inceleyebilir.
- [x] **Harita**: Sistemdeki harita üzerinden ilgili alanlar ve konumlar hakkında bilgi alabilir.
- [x] **İletişim Formu**: İletişim formu aracılığıyla geri bildirimde bulunabilir, öneri ve şikayetlerini iletebilir.
-----------------------------------------------------------------------
📌 ***Ziyaretçi Sayfası*** ve ***Admin Paneli*** olmak üzere 2 modülün birleştirildiği bu projede, ziyaretçilerin ve yöneticilerin farklı yetkilere sahip olduğu bir sistem oluşturulmuştur. Ziyaretçiler belirli sayfalara erişim sağlarken, admin paneli üzerinden yöneticiler içerik yönetimi, kullanıcı işlemleri ve sistem ayarları gibi işlemleri gerçekleştirebilir.</br>

🔎 Ziyaretçi sayfasında, ***Ana Sayfa, Hakkımızda, Hizmetlerimiz, Ekibimiz, Galeri*** ve ***Bize Ulaşın*** gibi bölümler bulunmaktadır. Kullanıcılar bu bölümler arasında hızlı bir şekilde gezinebilir, her tıklamada sayfa yeniden yüklenmeden ilgili içerik anında güncellenir. Böylece, daha hızlı ve akıcı bir deneyim sağlanır. Aşağıda, Ziyaretçi sayfasına ait ekran görüntüleri yer almaktadır: </br>

🌱 ***Ana Sayfa:*** </br>

<img src="https://github.com/user-attachments/assets/1b40a9b0-e5b3-45f8-89f2-f47fa18f7da4" alt="image" width="700"> </br>

🌱 ***Hakkımızda:*** </br>

<img src="https://github.com/user-attachments/assets/1144bc43-35c5-4b0f-84de-d72c33bbd8e9" alt="image" width="700"> </br>

🌱 ***Hizmetlerimiz:*** </br>

<img src="https://github.com/user-attachments/assets/c46a9a54-2d66-4c79-8b26-383d5366c389" alt="image" width="700"> </br>

🌱 ***Ekibimiz:*** </br>

<img src="https://github.com/user-attachments/assets/7b5ba446-ce60-4dee-a0c6-b5b0d100e07b" alt="image" width="700"> </br>

🌱 ***Galeri:*** </br>

<img src="https://github.com/user-attachments/assets/946c4bdf-3327-47e4-b4fb-b97e6f669b20" alt="image" width="700"> </br>

🌱 ***Bize Ulaşın:*** </br>

<img src="https://github.com/user-attachments/assets/f5b64e59-48a0-4728-a117-5fd75a982415" alt="image" width="700"> </br>

-----------------------------------------------------------------------
🔎 Admin Panelinde ***Yönetim Paneli, Hizmetler, Ekip Arkadaşları, Grafikler, Duyurular, Gelen Mesajlar, Adres Bilgileri, Galeri, Raporlar, Profil Bilgileri*** ve ***Yöneticiler*** olmak üzere toplam 11 farklı yönetim modülü bulunmaktadır. Yöneticiler bu modüller üzerinden içerikleri listeleyebilir, silebilir, ekleyebilir ve güncelleyebilir. Aşağıda, Admin Paneline ait yönetim modüllerinin ekran görüntüleri yer almaktadır: </br>

🌱 ***Yönetim Paneli:*** </br>

<img src="https://github.com/user-attachments/assets/e431dc38-137b-414c-a82c-298e3cd67429" alt="image" width="700"> </br>

🌱 ***Hizmetler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/d35d78bb-5cfb-46b7-b9da-b0cfac29c7ae" alt="image" width="700"> </br>

🌱 ***Ekip Arkadaşları Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/c8be7b48-4b8e-4afe-b115-f43a9e96b46a" alt="image" width="700"> </br>

🌱 ***Grafikler Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/fc0cac75-aa0d-4df0-9315-68ef6f36f627" alt="image" width="700"> </br>

🌱 ***Duyurular Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/0dd2fa3f-edc4-4fb0-b2dc-a65debcfec39" alt="image" width="700"> </br>

🌱 ***Gelen Mesajlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/53e166e7-2c4a-45dc-8825-6d394569bbb8" alt="image" width="700"> </br>

🌱 ***Adres Bilgileri Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/142653c0-6474-452f-bca5-b310cfb39850" alt="image" width="700"> </br>

🌱 ***Galeri Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/8814e4c7-1709-4a4d-b670-051f839616d2" alt="image" width="700"> </br>

🌱 ***Raporlar Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/da6eef27-a16a-4904-9766-1d6eb63a1cc6" alt="image" width="700"> </br>

🌱 ***Profil Bilgileri Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/bf8ddb65-c08f-4d6c-b895-9acbecda686d" alt="image" width="700"> </br>

🌱 ***Yöneticiler Bilgisi Yönetim Sayfası:*** </br>

<img src="https://github.com/user-attachments/assets/9ddc8d55-8338-45ca-8adf-a75b7b723e34" alt="image" width="700"> </br>

-----------------------------------------------------------------------

#### 🗂️ Proje Veri Tabanı Yedek Dosyası

Projenin MsSQL veri tabanı yedek dosyasını aşağıdaki linkten indirebilirsiniz. Bu dosya, HarvestHub projesine ait tüm hizmetler, duyurular, yöneticiler ve diğer veri tabanı yapılarıyla birlikte gelir. Dosyayı indirerek yerel ortamınızda projeyi çalıştırabilirsiniz.

📥 [**Veri Tabanı Yedeğini İndir**](https://drive.google.com/file/d/1GipSzIfrBJxiUUwXoJ2XXld2ElUO4lJW/view?usp=sharing)

İyi Çalışmalar! 🎉
