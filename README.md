# MvcCvProjesi - Kişisel CV/Portföy Web Sitesi 🚀

[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.6.1-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework/net461)
[![ASP.NET MVC](https://img.shields.io/badge/ASP.NET_MVC-5-purple.svg)](https://dotnet.microsoft.com/apps/aspnet/mvc)
[![Entity Framework](https://img.shields.io/badge/Entity_Framework-6-lightgrey.svg)](https://docs.microsoft.com/en-us/ef/)
[![AdminLTE](https://img.shields.io/badge/AdminLTE-3-blue.svg)](https://adminlte.io/)
[![Bootstrap](https://img.shields.io/badge/Bootstrap-4-purple.svg)](https://getbootstrap.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE) <!-- Eğer bir LICENSE dosyanız varsa -->
<!-- [![Build Status](https://img.shields.io/travis/com/YOUR_USERNAME/MvcCvProjesi.svg?style=flat-square)](https://travis-ci.com/YOUR_USERNAME/MvcCvProjesi) --> <!-- CI/CD kurarsanız bu rozeti aktif edebilirsiniz -->

Kişisel bir CV (Özgeçmiş) veya portföy web sitesi oluşturmak ve yönetmek için tasarlanmış bir **ASP.NET MVC 5** uygulamasıdır. CV bilgilerini modern bir arayüzle sunar ve içeriği yönetmek için kapsamlı bir yönetici paneli içerir.

---

## ✨ Öne Çıkan Özellikler

### 👨‍💻 Genel CV Sayfası (Ziyaretçi Arayüzü)
*   **Modern Tasarım:** `Start Bootstrap Resume` teması ile şık ve duyarlı görünüm.
*   **Kapsamlı Bilgi Sunumu:**
    *   Hakkımda Bölümü
    *   İş Deneyimleri (Kronolojik)
    *   Eğitim Geçmişi
    *   Yetenekler (Görsel gösterimlerle desteklenebilir)
    *   Hobiler ve İlgi Alanları
    *   Alınan Sertifikalar
    *   Sosyal Medya Profil Bağlantıları
*   **Etkileşim:** Ziyaretçilerin mesaj bırakabileceği İletişim Formu.

### 🔐 Yönetici Paneli (Admin Arayüzü)
*   **Güvenli Erişim:** ASP.NET Forms Authentication ile korunan giriş sistemi (`Login Form 20` teması).
*   **Kolay Yönetim:** `AdminLTE 3` teması ile kullanıcı dostu ve güçlü yönetim arayüzü.
*   **Tam Kontrol (CRUD):**
    *   Hakkımda bilgilerini güncelleme.
    *   Deneyim, Eğitim, Yetenek, Hobi, Sertifika ekleme, düzenleme ve silme.
    *   Sosyal Medya bağlantılarını yönetme.
    *   Gelen İletişim Mesajlarını görüntüleme.
    *   Sisteme giriş yapabilecek diğer **Yönetici Kullanıcıları** ekleme, düzenleme ve silme.

---

## 🛠️ Kullanılan Teknolojiler

*   **Backend:** C#, ASP.NET MVC 5, .NET Framework 4.6.1
*   **Veritabanı:** Microsoft SQL Server
*   **ORM:** Entity Framework 6 (Database First)
*   **Mimari Desen:** Repository Pattern
*   **Frontend Şablonları:**
    *   Yönetici Paneli: **AdminLTE 3**
    *   CV Sayfası: **Start Bootstrap Resume**
    *   Giriş Sayfası: **Login Form 20**
*   **Frontend Kütüphaneleri:** Bootstrap 4, jQuery, Chart.js, FontAwesome vb. (AdminLTE entegrasyonu ile)
*   **Kimlik Doğrulama:** ASP.NET Forms Authentication

---

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Ön Gereksinimler:**
    *   Visual Studio 2017 veya üstü (ASP.NET ve web geliştirme iş yükü yüklü)
    *   .NET Framework 4.6.1 Geliştirici Paketi
    *   Microsoft SQL Server (Express sürümü yeterlidir)

2.  **Depoyu Klonlayın:**
    ```bash
    git clone https://github.com/SENIN_KULLANICI_ADIN/MvcCvProjesi.git
    cd MvcCvProjesi
    ```
    *Not: `SENIN_KULLANICI_ADIN` kısmını kendi GitHub kullanıcı adınızla değiştirin.*

3.  **Visual Studio ile Açın:**
    *   Çözüm dosyası olan `MvcCvProjesi.sln` dosyasını Visual Studio'da açın.

4.  **Veritabanı Bağlantısını Ayarlayın:**
    *   `MvcCvProjesi/MvcCvProjesi` dizinindeki `Web.config` dosyasını açın.
    *   `<connectionStrings>` bölümünü bulun.
    *   `DbCvEntities` adlı bağlantı dizesindeki (`connectionString`) `data source` değerini kendi SQL Server örneğinizle değiştirin (örn: `.\SQLEXPRESS`, `localhost`, sunucu adı vb.).
    *   `initial catalog=DbCv` kısmının SQL Server'ınızda oluşturacağınız veya mevcut olan veritabanı adıyla eşleştiğinden emin olun.
    *   `integrated security=True` Windows kimlik doğrulaması içindir. SQL Server Authentication kullanıyorsanız, bağlantı dizenizi buna göre düzenleyin (`User ID=your_user;Password=your_password;`).
    *   **Veritabanı Şeması:** Proje Entity Framework **Database First** kullandığından, `DbCv` veritabanının ve gerekli tabloların (`TblAdmin`, `TblDeneyimlerim`, `TblEgitimlerim` vb.) SQL Server'da mevcut olması gerekir. Eğer bir `.sql` betiğiniz varsa, veritabanını oluşturmak için onu çalıştırın. Yoksa, `.edmx` dosyasına bakarak veya `Models/entity/` altındaki C# sınıflarına göre tabloları manuel oluşturmanız gerekebilir.

5.  **NuGet Paketlerini Geri Yükleyin:**
    *   Visual Studio'da çözüme sağ tıklayıp "Manage NuGet Packages for Solution..." seçeneğini açın. Eksik paketler varsa üstte bir uyarı belirir, "Restore" düğmesine tıklayın.
    *   Alternatif olarak, Paket Yöneticisi Konsolu'nu (Package Manager Console) açıp `Update-Package -reinstall` komutunu çalıştırabilirsiniz.

6.  **Projeyi Derleyin:**
    *   Menüden `Build > Build Solution` seçeneğini seçin veya `Ctrl+Shift+B` kısayolunu kullanın.

7.  **Projeyi Çalıştırın:**
    *   `F5` tuşuna basın veya Visual Studio'daki `IIS Express` (veya projenizin adı) düğmesine tıklayarak projeyi başlatın.

---

## 🚀 Kullanım

*   **CV Görüntüleme:** Proje çalıştığında tarayıcınızda açılan ana sayfa (`/Default/Index`) CV'nizi gösterir.
*   **Yönetici Girişi:**
    *   `/Login/Index` adresine gidin.
    *   `TblAdmin` tablosunda bulunan geçerli bir kullanıcı adı ve şifre ile giriş yapın. (Başlangıçta veritabanına manuel bir kullanıcı eklemeniz gerekebilir).
    *   Başarılı giriş sonrası yönetici paneline yönlendirilirsiniz. Buradan CV içeriğini yönetebilirsiniz.

---

## 🤝 Katkıda Bulunma

Projeye katkıda bulunmak isterseniz:

1.  Projeyi Fork'layın.
2.  Yeni bir Feature Branch oluşturun (`git checkout -b ozellik/HarikaBirOzellik`).
3.  Değişikliklerinizi Commit'leyin (`git commit -m 'Şu harika özellik eklendi'`).
4.  Branch'inizi Push'layın (`git push origin ozellik/HarikaBirOzellik`).
5.  Bir Pull Request açın.

İyileştirme önerileri ve hata bildirimleri için lütfen bir [Issue](https://github.com/SENIN_KULLANICI_ADIN/MvcCvProjesi/issues) açmaktan çekinmeyin.

---

## 📜 Lisans

Bu proje MIT Lisansı altında dağıtılmaktadır. Daha fazla ayrıntı için `LICENSE` dosyasına bakın (varsa).
