using Dependability.Entity;

namespace Dependability.Sample.OverrRide
{
    /// <summary>
    ///     可覆寫的保護方法
    /// </summary>   
    public class ValidationStep1
    {
        public bool CheckAuthentication(string id, string password)
        {
            var accountDao = new AccountDao();
            var passwordByDao = accountDao.GetPassword(id);

            var hash = new Hash();
            var hashResult = hash.GetHashResult(password);

            return passwordByDao == hashResult;
        }
    }
}
