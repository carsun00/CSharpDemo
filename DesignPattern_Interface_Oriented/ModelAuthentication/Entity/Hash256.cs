using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity
{
    class Hash256 : IHash
    {
        public string GetHashResult(string password)
        {
            //  Useing SHA-256
            throw new NotImplementedException();
        }
    }
}
