using Dependability.Entity;

namespace Dependability.Sample.OverrRide
{

    /// <summary>
    ///     可覆寫的保護方法
    ///     步驟1：
    ///         將New的物件抽出來
    ///         
    ///     步驟2：
    ///         將抽離出來的方法宣告為Virtual、
    ///         使用到的物件同樣也加上Virtual
    ///         到此步驟都在重構而已。
    ///         
    /// </summary>   
    public class ValidationStep2
    {
        public bool CheckAuthentication(string id, string password)
        {
            var accountDao = GetAccountDao();
            var passwordByDao = accountDao.GetPassword(id);

            var hash = GetHash();
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }

        // Step: 1 - private Hash GetHash()
        protected virtual Hash GetHash()
        {
            var hash = new Hash();
            return hash;
        }

        // Step: 1 - private AccountDao GetAccountDao()
        protected virtual AccountDao GetAccountDao()
        {
            var accountDao = new AccountDao();
            return accountDao;
        }
    }
}
