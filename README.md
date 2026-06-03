# Kütüphane Takip Sistemi

C# .NET Framework ve MS SQL Server kullanılarak geliştirilmiş, çok katmanlı mimari kullanan kütüphane yönetim sistemi.

## Özellikler

- Üye kayıt ve yönetim modülü (ekleme, listeleme, düzenleme, silme)
- Kitap envanter yönetimi
- Ödünç verme ve iade işlemleri
- Gösterge paneli ile özet görünüm
- SQL Server tabanlı normalize edilmiş veritabanı

## Teknolojiler

- **Dil:** C#
- **Framework:** .NET Framework
- **UI:** Windows Forms
- **Veritabanı:** MS SQL Server (SQL Express)
- **Veri Erişim:** ADO.NET (SqlConnection)

## Form Yapısı

- `Form1` — Ana giriş ekranı
- `GöstergePaneli` — Özet ve navigasyon
- `KİTAPEKLE` / `KİTAPLİSTELE` — Kitap işlemleri
- `ÜYEEKLE` / `ÜYELİSTELE` — Üye işlemleri

## Veritabanı Bağlantısı

Veritabanı bağlantısı her formda yerel olarak tanımlıdır. Kendi makinenizde çalıştırmak için:

1. SQL Server Management Studio'da `MERVE` adlı veritabanı oluşturun
2. Gerekli tabloları kurun (Üyeler, Kitaplar, Ödünçler)
3. Her formdaki `SqlConnection` satırındaki `Data Source` değerini kendi server adınızla değiştirin

## Geliştirici

Bu proje 2024 yılında Pamukkale Üniversitesi Yönetim Bilişim Sistemleri eğitimi kapsamında geliştirilmiştir.

## Lisans

MIT
