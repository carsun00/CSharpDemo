using Dependability.Interface;
using System;

namespace Dependability.Entity
{
    public class AccountDao : IAccountDao
    {
        // Step: 1 - public string GetPassword(string id)
        public virtual string GetPassword(string id)
        {
            throw new NotImplementedException();
        }
    }
}
