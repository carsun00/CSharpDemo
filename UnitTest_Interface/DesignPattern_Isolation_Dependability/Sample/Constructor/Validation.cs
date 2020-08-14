using Dependability.Interface;

namespace Dependability.Sample.Constructor
{
    /// <summary>
    ///     建構式（constructor）
    /// </summary>
    class Validation
    {
        /*  
         *  物件的相依介面，拉到公開的建構式，供外部物件使用時，可自行組合目標物件的相依物件實體。   
         *  當相依的物件越來越多時，會造成使用目標物件上的困難與疑惑。
         *  舉例：
         *      缺1.假設IHash實作了一個 Hash128、Hash256
         *          在使用Validation到底是使用[128]還是[256]?
         *          在程式邏輯上都會通過，因為都屬於IHash這個介面的衍伸類別。
         *          但執行上可能會跑出非預期的結果。
         *      
         *      缺2.呼叫端會大量的將相依物件實現，導致喪失封裝的優點。
         *      
         *  解決方式：
         *      Repository Pattern
         */
        private IAccountDao accountDao;
        private IHash hash;

        public Validation(IAccountDao dao, IHash hash)
        {
            accountDao = dao;
            this.hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        {
            var passwordByDao = accountDao.GetPassword(id);
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
