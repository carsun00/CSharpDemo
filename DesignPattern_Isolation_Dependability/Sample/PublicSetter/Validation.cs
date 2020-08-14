using Dependability.Interface;
using System;

namespace Dependability.Sample.PublicSetter
{
    /// <summary>
    ///     公開屬性（public setter property）
    /// </summary>
    class Validation
    {
        /*  
         *  公開屬性與公開建構式非常類似，透過public的property（property型別仍為interface），
         *  讓外部在使用目標物件時，可先setting目標物件的相依物件，接著才呼叫其方法。
         *  
         *  舉例：
         *      優1.只會將setter公開給外部設定，getter則設定為private。
         *          外部只需設定，而不需取用。
         *          
         *      缺1.使用目標物件時，相依介面應有其對應執行個體，
         *          但卻因為使用端沒有設定public property，導致使用方法時出現NullReferenceException。
         *          
         *          今天有第三方因程式需求，引用了[Validation]，要取得AccountDao的資料，
         *          但在這隻程式中[Get]被設定為[private]，
         *          可是[IAccountDao]中[Get]、[Set]都是Public。
         *          
         *          從最小知識原則（Least Knowledge Principle）來說，
         *          在[Validation]中是對的選擇，因此也不能責怪這隻程式的開發者。
         *      
         *  解決方式：
         *      Repository Pattern
         */
        public IAccountDao AccountDao { private get; set; }
        public IHash Hash { private get; set; }

        public bool CheckAuthentication(string id, string password)
        {
            if(this.AccountDao == null)
            {
                throw new ArgumentNullException();
            }

            if(this.Hash == null)
            {
                throw new ArgumentNullException();
            }

            var passwordByDao = this.AccountDao.GetPassword(id);
            var hashResult = this.Hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
