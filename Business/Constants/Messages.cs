using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenceTime = "Sistem Bakımda";
        public static string ProdcutCountOfCategoryError = "Aynı kategoride en fazla 10 ürün olabilir";

        public static string ProdcutNameAlreadyExists = "Aynı isimde zaten bir ürün var";

        public static string CategoryLimitExceed = "Kategory limitini aştınız";
        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt oldundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
