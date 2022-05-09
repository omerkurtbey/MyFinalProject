using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";
        public static string ProductNameInvalid = "Invalid product name";
        public static string MaintenanceTime = "Sytstem maintenance time ";
        public static string ProductsListed = "Products listed successfully";
        public static string ProductCountOfCategoryError = "Aynı kategoride maksimum 10 adet ürünü ekleyebilirsiniz.";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token created";
    }
}
