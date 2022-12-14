USE [master]
GO
/****** Object:  Database [KutuphaneVeriTabani]    Script Date: 10.06.2021 10:11:02 ******/
CREATE DATABASE [KutuphaneVeriTabani]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KutuphaneVeriTabani', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KutuphaneVeriTabani.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KutuphaneVeriTabani_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KutuphaneVeriTabani_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [KutuphaneVeriTabani] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KutuphaneVeriTabani].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ARITHABORT OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET  MULTI_USER 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KutuphaneVeriTabani] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KutuphaneVeriTabani] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [KutuphaneVeriTabani] SET QUERY_STORE = OFF
GO
USE [KutuphaneVeriTabani]
GO
/****** Object:  Table [dbo].[Calisanlar]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calisanlar](
	[Calisan_id] [int] IDENTITY(1,1) NOT NULL,
	[Calisan_ad] [nvarchar](50) NOT NULL,
	[Calisan_soyad] [nvarchar](50) NOT NULL,
	[Calisan_sifre] [nvarchar](50) NOT NULL,
	[Calisan_telefon] [nvarchar](11) NULL,
	[Calisan_adres] [nvarchar](150) NULL,
	[Calisan_eposta] [nvarchar](60) NOT NULL,
	[Unvan] [nvarchar](50) NOT NULL,
	[Kutuphane_id] [int] NOT NULL,
	[Nobet_gunleri] [nvarchar](50) NULL,
 CONSTRAINT [PK_Calisanlar] PRIMARY KEY CLUSTERED 
(
	[Calisan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emanet]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emanet](
	[Kayit_no] [int] IDENTITY(1,1) NOT NULL,
	[Uye_id] [int] NOT NULL,
	[Kitap_id] [int] NOT NULL,
	[Alis_tarihi] [date] NOT NULL,
	[Teslim_tarihi] [date] NOT NULL,
 CONSTRAINT [PK_Emanet] PRIMARY KEY CLUSTERED 
(
	[Kayit_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[Kategori_id] [int] IDENTITY(1,1) NOT NULL,
	[Kategori_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategori] PRIMARY KEY CLUSTERED 
(
	[Kategori_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[Kitap_id] [int] IDENTITY(1,1) NOT NULL,
	[Kitap_ad] [nvarchar](70) NOT NULL,
	[Sayfa_sayisi] [int] NULL,
	[ISBN] [nvarchar](13) NOT NULL,
	[Yazar_id] [int] NOT NULL,
	[Kütüphane_id] [int] NOT NULL,
	[Adet] [int] NOT NULL,
	[Kategori_id] [int] NOT NULL,
 CONSTRAINT [PK_Kitap] PRIMARY KEY CLUSTERED 
(
	[Kitap_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kitap_Yayinevi]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap_Yayinevi](
	[Kitap_id] [int] NOT NULL,
	[Yayinevi_id] [int] NOT NULL,
	[Basim_tarihi] [int] NULL,
	[Kayit_no] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Kitap_Yayinevi] PRIMARY KEY CLUSTERED 
(
	[Kayit_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kutuphane]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kutuphane](
	[Kutuphane_id] [int] IDENTITY(1,1) NOT NULL,
	[Kutuphane_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kutuphane] PRIMARY KEY CLUSTERED 
(
	[Kutuphane_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kutuphane_Uye]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kutuphane_Uye](
	[Kutuphane_id] [int] NOT NULL,
	[Uye_id] [int] NOT NULL,
	[Kayit_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Kutuphane_Uye] PRIMARY KEY CLUSTERED 
(
	[Kayit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uyeler]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uyeler](
	[Uye_id] [int] IDENTITY(1,1) NOT NULL,
	[Uye_ad] [nvarchar](50) NOT NULL,
	[Uye_soyad] [nvarchar](50) NOT NULL,
	[Uye_eposta] [nvarchar](60) NOT NULL,
	[Uye_telefon] [nvarchar](11) NULL,
	[Ceza] [int] NOT NULL,
	[Max_kitap_sayisi] [int] NOT NULL,
	[Alınan_kitap_sayisi] [int] NOT NULL,
 CONSTRAINT [PK_Uyeler] PRIMARY KEY CLUSTERED 
(
	[Uye_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yayinevi]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yayinevi](
	[Yayinevi_id] [int] IDENTITY(1,1) NOT NULL,
	[Yayinevi_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yayinevi] PRIMARY KEY CLUSTERED 
(
	[Yayinevi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazarlar]    Script Date: 10.06.2021 10:11:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazarlar](
	[Yazar_id] [int] IDENTITY(1,1) NOT NULL,
	[Yazar_ad] [nvarchar](50) NOT NULL,
	[Yazar_soyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Yazarlar] PRIMARY KEY CLUSTERED 
(
	[Yazar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Calisanlar] ON 

INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (1, N'Mehmet', N'Yavuz', N'mehmet123', N'05112223344', NULL, N'mehmet_yavuz@gmail.com', N'Yönetici', 1, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (3, N'Bilgi', N'Temizkan', N'bilgi123', N'05112223345', NULL, N'bilgi_temizkan@gmail.com', N'Kütüphaneci', 1, N'Pazartesi, Çarşamba')
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (5, N'Şerife', N'Karagöz', N'şerife123', N'05112223355', NULL, N'serife_karagoz@gmail.com', N'Kütüphaneci', 1, N'Salı, Perşembe')
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (6, N'Kenan Ahmet', N'Börekci', N'kenanahmet123', N'05112223356', NULL, N'kenan_borekci@gmail.com', N'Memur', 1, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (8, N'Cemre', N'Güçlü', N'cemre123', N'05112223366', NULL, N'cemre_guclu@gmail.com', N'Şef', 1, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (9, N'Alp', N'Eskimen', N'alp123', N'05112223367', NULL, N'alp_eskimen@gmail.com', N'Şef', 2, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (10, N'Saner', N'Baloğlu', N'saner123', N'05112223377', NULL, N'saner_baloglu@gmail.com', N'Kütüphaneci', 2, N'Pazartesi, Çarşamba')
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (11, N'Talha', N'Kılıç', N'talha123', N'05112223378', NULL, N'talha_kilic@gmail.com', N'Kütüphaneci', 2, N'Salı, Perşembe')
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (12, N'Ayça', N'Türk', N'ayça123', N'05112223388', NULL, N'ayca_turk@gmail.com', N'Yönetici', 2, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (14, N'Furkan', N'Cemali', N'furkan123', N'05112223389', NULL, N'furkan_cemali@gmail.com', N'Memur', 2, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (15, N'Sevgi', N'Armağan', N'sevgi123', N'05112223399', NULL, N'sevgi_armagan@gmail.com', N'Yönetici', 3, NULL)
INSERT [dbo].[Calisanlar] ([Calisan_id], [Calisan_ad], [Calisan_soyad], [Calisan_sifre], [Calisan_telefon], [Calisan_adres], [Calisan_eposta], [Unvan], [Kutuphane_id], [Nobet_gunleri]) VALUES (18, N'banu', N'çalişkan', N'banu123', N'05123334567', NULL, N'banu_çaliskan@gmail.com', N'memur', 1, NULL)
SET IDENTITY_INSERT [dbo].[Calisanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Emanet] ON 

INSERT [dbo].[Emanet] ([Kayit_no], [Uye_id], [Kitap_id], [Alis_tarihi], [Teslim_tarihi]) VALUES (11, 1, 1, CAST(N'2021-06-08' AS Date), CAST(N'2021-06-23' AS Date))
INSERT [dbo].[Emanet] ([Kayit_no], [Uye_id], [Kitap_id], [Alis_tarihi], [Teslim_tarihi]) VALUES (12, 4, 11, CAST(N'2021-06-08' AS Date), CAST(N'2021-06-23' AS Date))
INSERT [dbo].[Emanet] ([Kayit_no], [Uye_id], [Kitap_id], [Alis_tarihi], [Teslim_tarihi]) VALUES (15, 20, 33, CAST(N'2021-06-09' AS Date), CAST(N'2021-06-24' AS Date))
INSERT [dbo].[Emanet] ([Kayit_no], [Uye_id], [Kitap_id], [Alis_tarihi], [Teslim_tarihi]) VALUES (16, 1, 21, CAST(N'2021-06-09' AS Date), CAST(N'2021-06-24' AS Date))
SET IDENTITY_INSERT [dbo].[Emanet] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategori] ON 

INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (1, N'Bilim Kurgu')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (2, N'Korku/Gerilim')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (3, N'Dünya Klasik')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (4, N'Türk Roman')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (5, N'Günlük Anı')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (6, N'Polisiye')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (7, N'Dünya Roman')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (8, N'Psikoloji')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (9, N'Tarih')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (10, N'Felsefe')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (11, N'Çizgi-Roman')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (12, N'Politika')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (13, N'Çocuk Bilim')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (14, N'Deneme')
INSERT [dbo].[Kategori] ([Kategori_id], [Kategori_ad]) VALUES (15, N'Biyografi/Otobiyografi')
SET IDENTITY_INSERT [dbo].[Kategori] OFF
GO
SET IDENTITY_INSERT [dbo].[Kitap] ON 

INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (1, N'Suç ve Ceza', 687, N'9789754589023', 1, 1, 2, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (2, N'Kumarbaz', NULL, N'9789755338033', 1, 1, 3, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (4, N'Kan Varsa', 432, N'9789752126343', 5, 1, 1, 2)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (9, N'Siya’nın Güncesi', 176, N'9786057478238', 3, 2, 1, 5)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (10, N'Kayıp Tanrılar Ülkesi', 504, N'9789750850417', 2, 2, 3, 6)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (11, N'Mülksüzler', 344, N'9789753425285', 6, 1, 2, 1)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (12, N'Körlük', 336, N'9786052980811', 7, 1, 3, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (13, N'Görmek', NULL, N'9786052981320', 7, 1, 3, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (14, N'1984', 352, N'9789750718533', 8, 3, 3, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (15, N'Bir İdam Mahkumunun Son Günü', NULL, N'9786053609902', 9, 3, 3, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (16, N'Puslu Kıtalar Atlası', 238, N'9789754704723', 10, 1, 2, 4)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (17, N'Hayvan Çiftliği', 152, N'9789750719387', 8, 1, 2, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (18, N'Cesur Yeni Dünya', 272, N'9789756902165', 11, 3, 2, 1)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (19, N'İnsan Olmak', NULL, N'9789753423984', 12, 3, 1, 8)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (20, N'Fareler ve İnsanlar', 111, N'9789755705859', 13, 1, 3, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (21, N'Altıncı Koğuş', NULL, N'9786052951569', 14, 1, 1, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (22, N'Kırmızı Pazartesi', 111, N'9789750721571', 15, 2, 2, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (24, N'Otomatik Portakal', NULL, N'9786052957929', 16, 3, 3, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (25, N'Yakın Tarihin Gerçekleri', 352, N'9786057635983', 17, 1, 1, 9)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (26, N'Yabancı', 112, N'9789750748677', 18, 3, 1, 11)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (27, N'Savaş Sanatı', NULL, N'9786053322696', 19, 3, 3, 12)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (28, N'Yeraltından Notlar', 140, N'9789944884013', 1, 3, 1, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (29, N'Sıradan Zaferler', 248, N'9786059670241', 26, 2, 1, 11)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (32, N'Varoluşçuluk', 128, N'9786050207262', 27, 1, 1, 10)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (33, N'Kızıl Veba', 72, N'9786257070782', 20, 1, 0, 3)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (34, N'İnsan Vücudu Tiyatrosu', 240, N'9786054729838', 21, 2, 1, 13)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (35, N'İletişim Donanımları', 199, N'9789751408860', 22, 2, 1, 8)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (36, N'Satranç', NULL, N'9786053606116', 23, 3, 3, 7)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (38, N'Kürk Mantolu Madonna', 160, N'9789753638029', 24, 3, 3, 4)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (39, N'İçimizdeki Şeytan', NULL, N'9789753638036', 24, 2, 2, 4)
INSERT [dbo].[Kitap] ([Kitap_id], [Kitap_ad], [Sayfa_sayisi], [ISBN], [Yazar_id], [Kütüphane_id], [Adet], [Kategori_id]) VALUES (40, N'Özgürlüğün Rengi Mavidir', 328, N'9786053119814', 25, 2, 1, 14)
SET IDENTITY_INSERT [dbo].[Kitap] OFF
GO
SET IDENTITY_INSERT [dbo].[Kitap_Yayinevi] ON 

INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (1, 1, 2006, 1)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (2, 2, 2018, 2)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (4, 3, 2021, 3)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (9, 5, 2021, 5)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (10, 6, 2021, 6)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (11, 7, 2017, 7)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (12, 8, 2017, 8)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (13, 8, 2017, 9)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (14, 9, 2000, 10)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (15, 1, 2013, 11)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (16, 10, 1995, 12)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (17, 9, NULL, 13)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (18, 11, 2003, 14)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (19, 7, 2003, 15)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (20, 12, 2012, 16)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (21, 1, 2017, 17)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (22, 9, 2000, 18)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (24, 1, 2019, 19)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (25, 13, 2021, 20)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (26, 9, 1996, 21)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (27, 1, 2014, 22)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (28, 1, 2016, 23)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (29, 17, 2016, 24)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (32, 18, 2000, 25)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (33, 1, 2021, 26)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (34, 14, 2016, 27)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (35, 15, 2016, 28)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (36, 1, 2012, 29)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (38, 6, 1998, 30)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (39, 6, 2016, 31)
INSERT [dbo].[Kitap_Yayinevi] ([Kitap_id], [Yayinevi_id], [Basim_tarihi], [Kayit_no]) VALUES (40, 16, 2020, 32)
SET IDENTITY_INSERT [dbo].[Kitap_Yayinevi] OFF
GO
SET IDENTITY_INSERT [dbo].[Kutuphane] ON 

INSERT [dbo].[Kutuphane] ([Kutuphane_id], [Kutuphane_ad]) VALUES (1, N'Kadıköy Kütüphanesi')
INSERT [dbo].[Kutuphane] ([Kutuphane_id], [Kutuphane_ad]) VALUES (2, N'Kartal Kütüphanesi')
INSERT [dbo].[Kutuphane] ([Kutuphane_id], [Kutuphane_ad]) VALUES (3, N'Beşiktaş Kütüphanesi')
SET IDENTITY_INSERT [dbo].[Kutuphane] OFF
GO
SET IDENTITY_INSERT [dbo].[Kutuphane_Uye] ON 

INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 1, 1)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 3, 2)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 4, 3)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 14, 5)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 15, 6)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 17, 7)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 20, 8)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 3, 9)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 4, 10)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 5, 11)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 7, 12)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 8, 13)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 9, 14)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 13, 15)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 14, 16)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 18, 17)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (2, 20, 18)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 1, 19)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 2, 20)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 6, 21)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 11, 22)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 12, 23)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 16, 24)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 19, 25)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (3, 20, 26)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 10, 27)
INSERT [dbo].[Kutuphane_Uye] ([Kutuphane_id], [Uye_id], [Kayit_id]) VALUES (1, 21, 28)
SET IDENTITY_INSERT [dbo].[Kutuphane_Uye] OFF
GO
SET IDENTITY_INSERT [dbo].[Uyeler] ON 

INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (1, N'Sinan Dinçer', N'Aydınlı', N'sinan_aydinli@gmail.com', N'05111111112', 0, 4, 2)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (2, N'Çağatay', N'Onuk', N'çagatay_onuk@gmail.com', N'05222222222', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (3, N'Çetin', N'Öksüzoğlu', N'cetin_oksuzoglu@gmail.com', N'05333333334', 0, 4, 1)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (4, N'Esin Seren', N'Gökmen', N'esin_gokmen@gmail.com', N'05444444444', 0, 4, 1)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (5, N'Aybüke', N'Eşfer', N'aybuke_esfer@gmail.com', N'05555555555', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (6, N'Erdem', N'Durukan', N'erdem_durukan@gmail.com', N'05666666666', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (7, N'Nilay', N'Asena', N'nilay_asena@gmail.com', N'05777777777', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (8, N'Bade', N'Dayanır', N'bade_dayanir@gmail.com', N'05888888888', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (9, N'Muratcan', N'Yalçınkaya', N'muratcan_yalcinkaya@gmail.com', N'05999999999', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (10, N'Oğuzhan', N'Söylemez', N'oguzhan_soylemez@gmail.com', N'05121111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (11, N'Gözde', N'Emirlioğlu', N'gozde_emirlioglu', N'05131111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (12, N'Alperen', N'İğde', N'alperen_igde@gmail.com', N'05141111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (13, N'Dilek', N'Erdağ', N'dilek_erdag@gmail.com', N'05151111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (14, N'Ezgi Gizem', N'Nurata', N'ezgi_nurata@gmail.com', N'05161111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (15, N'Derya', N'Saka', N'derya_saka@gmail.com', N'05171111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (16, N'Hasan Sami', N'Uyar', N'hasan_uyar@gmail.com', N'05181111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (17, N'Meriç', N'Yurdakul', N'meric_yurdakul@gmail.com', N'05192222222', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (18, N'Tolga', N'Kütük', N'tolga_kütük@gmail.com', N'05191111111', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (19, N'Şeyma', N'Köksoy', N'seyma_koksoy@gmail.com', N'05222222222', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (20, N'Eylem', N'Erköse', N'eylem_erkose@gmail.com', N'05223333333', 0, 4, 1)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (21, N'Ayşe', N'Şahin', N'ayse_sahin@gmail.com', N'05233345678', 0, 4, 0)
INSERT [dbo].[Uyeler] ([Uye_id], [Uye_ad], [Uye_soyad], [Uye_eposta], [Uye_telefon], [Ceza], [Max_kitap_sayisi], [Alınan_kitap_sayisi]) VALUES (22, N'Deniz', N'Katip', N'deniz_katip@gmail.com', N'05555449009', 0, 4, 0)
SET IDENTITY_INSERT [dbo].[Uyeler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yayinevi] ON 

INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (1, N'İş Bankası Kültür Yayınları')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (2, N'İmge Yayınevi')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (3, N'Altın Kitaplar')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (4, N'İnkılap Kitabevi')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (5, N'Aryen')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (6, N'Yapı Kredi Yayınları')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (7, N'Metis Yayıncılık')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (8, N'Kırmızı Kedi')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (9, N'Can Yayınları')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (10, N'İletişim Yayıncılık')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (11, N'İthaki Yayınları')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (12, N'Sel Yayıncılık')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (13, N'Kronik Kitap')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (14, N'Domingo Yayınevi')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (15, N'Remzi Kitabevi')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (16, N'Destek Yayınları')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (17, N'Karakarga')
INSERT [dbo].[Yayinevi] ([Yayinevi_id], [Yayinevi_ad]) VALUES (18, N'Say Yayınları')
SET IDENTITY_INSERT [dbo].[Yayinevi] OFF
GO
SET IDENTITY_INSERT [dbo].[Yazarlar] ON 

INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (1, N'Fyodor Mihayloviç', N'Dostoyevski')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (2, N'Ahmet', N'Ümit')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (3, N'Siya', N'Çınar')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (4, N'Zülfü', N'Livaneli')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (5, N'Stephen', N'King')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (6, N'Ursula K.', N'Le Guin')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (7, N'Jose', N'Saramago')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (8, N'George', N'Orwell')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (9, N'Victor', N'Hugo')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (10, N'İhsan Oktay', N'Anar')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (11, N'Aldous', N'Huxley')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (12, N'Engin', N'Geçtan')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (13, N'John', N'Steinbeck')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (14, N'Anton Pavloviç', N'Çehov')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (15, N'Gabriel Garcia', N'Marquez')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (16, N'Anthony', N'Burgess')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (17, N'İlber', N'Ortaylı')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (18, N'Albert', N'Camus')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (19, N'Sun', N'Tzu')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (20, N'Jack', N'London')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (21, N'Maris', N'Wicks')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (22, N'Doğan', N'Cüceloğlu')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (23, N'Stefan', N'Zweig')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (24, N'Sabahattin', N'Ali')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (25, N'Cem', N'Seymen')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (26, N'Manu', N'Larcenet')
INSERT [dbo].[Yazarlar] ([Yazar_id], [Yazar_ad], [Yazar_soyad]) VALUES (27, N'Jean-Paul', N'Sartre')
SET IDENTITY_INSERT [dbo].[Yazarlar] OFF
GO
ALTER TABLE [dbo].[Uyeler] ADD  CONSTRAINT [DF_Uyeler_Ceza]  DEFAULT ((0)) FOR [Ceza]
GO
ALTER TABLE [dbo].[Uyeler] ADD  CONSTRAINT [DF_Uyeler_Max_kitap_sayisi]  DEFAULT ((4)) FOR [Max_kitap_sayisi]
GO
ALTER TABLE [dbo].[Uyeler] ADD  CONSTRAINT [DF_Uyeler_Alınan_kitap_sayisi]  DEFAULT ((0)) FOR [Alınan_kitap_sayisi]
GO
ALTER TABLE [dbo].[Calisanlar]  WITH CHECK ADD  CONSTRAINT [FK_Calisanlar_Kutuphane] FOREIGN KEY([Kutuphane_id])
REFERENCES [dbo].[Kutuphane] ([Kutuphane_id])
GO
ALTER TABLE [dbo].[Calisanlar] CHECK CONSTRAINT [FK_Calisanlar_Kutuphane]
GO
ALTER TABLE [dbo].[Emanet]  WITH CHECK ADD  CONSTRAINT [FK_Emanet_Kitap] FOREIGN KEY([Kitap_id])
REFERENCES [dbo].[Kitap] ([Kitap_id])
GO
ALTER TABLE [dbo].[Emanet] CHECK CONSTRAINT [FK_Emanet_Kitap]
GO
ALTER TABLE [dbo].[Emanet]  WITH CHECK ADD  CONSTRAINT [FK_Emanet_Uyeler] FOREIGN KEY([Uye_id])
REFERENCES [dbo].[Uyeler] ([Uye_id])
GO
ALTER TABLE [dbo].[Emanet] CHECK CONSTRAINT [FK_Emanet_Uyeler]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Kategori] FOREIGN KEY([Kategori_id])
REFERENCES [dbo].[Kategori] ([Kategori_id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Kategori]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Kutuphane] FOREIGN KEY([Kütüphane_id])
REFERENCES [dbo].[Kutuphane] ([Kutuphane_id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Kutuphane]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yazarlar] FOREIGN KEY([Yazar_id])
REFERENCES [dbo].[Yazarlar] ([Yazar_id])
GO
ALTER TABLE [dbo].[Kitap] CHECK CONSTRAINT [FK_Kitap_Yazarlar]
GO
ALTER TABLE [dbo].[Kitap_Yayinevi]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yayinevi_Kitap] FOREIGN KEY([Kitap_id])
REFERENCES [dbo].[Kitap] ([Kitap_id])
GO
ALTER TABLE [dbo].[Kitap_Yayinevi] CHECK CONSTRAINT [FK_Kitap_Yayinevi_Kitap]
GO
ALTER TABLE [dbo].[Kitap_Yayinevi]  WITH CHECK ADD  CONSTRAINT [FK_Kitap_Yayinevi_Yayinevi] FOREIGN KEY([Yayinevi_id])
REFERENCES [dbo].[Yayinevi] ([Yayinevi_id])
GO
ALTER TABLE [dbo].[Kitap_Yayinevi] CHECK CONSTRAINT [FK_Kitap_Yayinevi_Yayinevi]
GO
ALTER TABLE [dbo].[Kutuphane_Uye]  WITH CHECK ADD  CONSTRAINT [FK_Kutuphane_Uye_Kutuphane] FOREIGN KEY([Kutuphane_id])
REFERENCES [dbo].[Kutuphane] ([Kutuphane_id])
GO
ALTER TABLE [dbo].[Kutuphane_Uye] CHECK CONSTRAINT [FK_Kutuphane_Uye_Kutuphane]
GO
ALTER TABLE [dbo].[Kutuphane_Uye]  WITH CHECK ADD  CONSTRAINT [FK_Kutuphane_Uye_Uyeler] FOREIGN KEY([Uye_id])
REFERENCES [dbo].[Uyeler] ([Uye_id])
GO
ALTER TABLE [dbo].[Kutuphane_Uye] CHECK CONSTRAINT [FK_Kutuphane_Uye_Uyeler]
GO
USE [master]
GO
ALTER DATABASE [KutuphaneVeriTabani] SET  READ_WRITE 
GO
