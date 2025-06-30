# 🎬 FilmFusion – ASP.NET Core MVC Film Yönetim Sistemi

**FilmFusion**, modern ve görsel açıdan zengin bir film yönetim sistemidir. **ASP.NET Core MVC** ve **Dapper ORM** kullanılarak geliştirilmiştir. Film, tür ve oyuncu gibi verilerin kolayca eklenip güncellenebildiği, şık bir admin paneline sahiptir.

Proje, estetik arayüz ile güçlü mimari yapıyı bir araya getirir. **ViewComponent tabanlı modüler yapı**, canlı UI animasyonları ve gerçek zamanlı fragman ön izlemeleri sunar.

-----

## 💡 Projenin Öne Çıkan Özellikleri

### 🌐 ASP.NET Core MVC + Dapper ORM
- ASP.NET Core MVC ile geliştirildi.
- Tüm veritabanı işlemleri **Stored Procedure** kullanılarak **Dapper** aracılığıyla gerçekleştirildi.

### 🧩 ViewComponent ile Modüler Yapı
- Navbar, Footer, İstatistik Kartları gibi bölümler ViewComponent ile geliştirildi.
- Bu sayede tekrar kullanılabilir ve düzenli bir yapı sağlandı.

### 🎞️ Dinamik Film Kartları ve Animasyonlar
- Ana sayfada en son eklenen filmlerin yer aldığı kayan bir kart (slider) yer alır.
- Posterler ve fragmanlar yan yana görünür, şeffaf arka plan efekti ve blur ile stilize edilmiştir.

### 🖼️ Poster Şeridi (Filmstrip)
- Filmlere ait posterler yatay olarak yavaşça kayar.
- Mouse ile üzerine gelindiğinde poster öne çıkar, animasyonla büyür.
- Altında filmin adı görünür.

### ⚙️ Yönetici Paneli (Admin CRUD)
- Filmler, Oyuncular ve Türler için ekleme/güncelleme/silme işlemleri.
- Dapper ile çoklu eşleme (multi-mapping) kullanımı.
- Kullanıcı dostu formlar ve doğrulamalar.

### 📁 Temiz Proje Yapısı
- Models, Views, Controllers, ViewComponents gibi klasörler ile ayrılmış, düzenli yapı.
- wwwroot/assets klasöründe görseller ve animasyonlar yer alır.

-----

## 🔧 Kullanılan Teknolojiler

- ASP.NET Core MVC (.NET)
- Dapper ORM
- Microsoft SQL Server
- Stored Procedures
- FontAwesome
- ViewComponent Yapısı
- Custom CSS Animasyonlar
- Animasyon kaydı: ScreenToGif

-----

## 🖼️ Ekran Görüntüleri & GIF’ler
##### GIF animasyonları birkaç saniyede görüntülenebilir.


### 🎥 Home Page 

<img src="assets/Animation1.gif" width="700" alt="Homepage Animation" />


<img src="assets/Animation2.gif" width="700" alt="Homepage Animation" />

 
<img src="assets/Animation3.gif" width="700" alt="Homepage Animation" />


<img src="assets/Animation4_.gif" width="700" alt="Homepage Animation" />


<img src="assets/Animation5.gif" width="700" alt="Homepage Animation" />

-----

### 🎞️ Movie Page

#### Movie List

<img src="assets/Animation6.gif" width="700" />

#### Update Movie

<img src="assets/Animation7.gif" width="700" />

-----

### 💡 Actor Page

#### Actor List

<img src="https://github.com/user-attachments/assets/ae3785f5-f7d8-4f4d-9f75-dbbe7047c2a4" width="700"  />

#### Update Actor

<img src="https://github.com/user-attachments/assets/785232a7-c377-439e-b52a-0f41f5e673b3" width="700" />

#### Add New Actor

<img src="https://github.com/user-attachments/assets/645d03bb-9f01-4efe-a0b1-2062010b3d7c" width="700" />


-----

### 👩‍🎤 Movie - Actor Page


#### Movie - Actor List

<img src="https://github.com/user-attachments/assets/83f7ed5a-924a-49d4-b99f-47659d90d95b" width="700"  />


#### Update Movie - Actor

<img src="https://github.com/user-attachments/assets/9edccc8a-497c-4994-a927-b4ee95ca171c" width="700" />

-----


### 👩‍🎤 Genre Page


#### Genre List

<img src="https://github.com/user-attachments/assets/01280629-0af4-4376-ad8d-630acc0021da" width="700"  />


#### Add Genre

<img src="https://github.com/user-attachments/assets/47e8f97f-cfad-4576-9644-fa3fe0908e9b" width="700" />





