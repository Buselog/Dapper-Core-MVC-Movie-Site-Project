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

| 🎥 Ana Sayfa Slider | 

<img src="assets/Animation1.gif" width="400" alt="Homepage Animation" />


## 🎬 Homepage Animation
![Homepage](assets/Animation1.gif)




🖼️ Poster Şeridi | 




⚙️ Admin Panel |









## 🎬 Homepage Animation
![Homepage](assets/Animation2.gif)


## 🎬 Homepage Animation
![Homepage](assets/Animation3.gif)
