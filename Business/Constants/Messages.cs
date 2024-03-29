﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarsListed = "Arabalar listelendi.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Renk silindi";
        public static string BrandUpdated = "Renk güncellendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandsListed = "Markalar listelendi.";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorsListed = "Renkler listelendi.";

        public static string RentalAdded = "Kiralık araç eklendi";
        public static string RentalDeleted = "Kiralık araç silindi";
        public static string RentalUpdated = "Kiralık araç güncellendi";
        public static string RentalNameInvalid = "Kiralık araç geçersiz";
        public static string RentalsListed = "Kiralamalar listelendi.";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UsersListed = "Kullanıcılar listelendi.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImagesNotAdded = "Araba resmi eklenemedi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImagesListed = "Araba resimleri listelendi.";

        public static string MaintenanceTime = "Sistem bakımda.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";

        public static string CarImageCountExceeded = "Araba resim sayısı limiti aşıldı";

    }
}
