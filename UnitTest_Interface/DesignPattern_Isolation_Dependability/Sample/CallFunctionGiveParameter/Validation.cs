using Dependability.Interface;

namespace Dependability.Sample.CallFunctionGiveParameter
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
         *      優1.目標物件的方法內容則僅相依於參數上的介面。
         *      
         *      缺1.當需求異動，該方法需要額外相依於其他物件時，方法名稱可能會被迫改變。
         *      缺2.方法的參數過多，在使用上也會造成困擾。而且會影響到legacy code的呼叫端，需要全面跟著異動，才能編譯成功。
         *          在.net framework還是有許多這樣的設計，例如：List<T>.Sort 方法 (IComparer<T>)
         *      
         *  解決方式：
         *      這個方式是可以與其他方式共存的，所以在設計物件時，可衡量搭配使用
         */
        private IAccountDao accountDao;
        private IHash hash;

        public bool CheckAuthentication(IAccountDao accountDao, IHash hash, string id, string password)
        {
            var passwordByDao = accountDao.GetPassword(id);
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }

        public bool CheckAuthentication(string id, string password)
        {
            var passwordByDao = accountDao.GetPassword(id);
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
