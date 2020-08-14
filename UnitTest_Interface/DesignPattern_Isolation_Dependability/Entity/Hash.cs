using Dependability.Interface;
using System;

namespace Dependability.Entity
{
    public class Hash : IHash
    {
        // Step: 1 - public string GetHashResult(string password)
        public virtual string GetHashResult(string password)
        {
            throw new NotImplementedException();
        }
    }
}
