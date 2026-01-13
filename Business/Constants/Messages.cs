using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages // sabit mesajlar burada toplanır.
    {
        public static string ProductAdded = "Ürün eklendi"; // public static yaparak new'lenmesini engelliyoruz.
        public static string ProductNameInvalid = "Ürün ismi en az 2 karakter olmalıdır";//public ler pascal case yazılır.
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bu kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isim zaten mevcut";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string? AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Register";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre yanlış";
        public static string UserAlreadyExists="Kullanıcı zaten var";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string SuccessfulLogin="Giriş başarılı";
        internal static string ProductUpdated;
    }
}
