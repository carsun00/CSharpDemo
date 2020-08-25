using Interface_Oriented.ModelAuthentication.Interface;
using System;
namespace Interface_Oriented.ModelAuthentication.Entity
{
    class Hash512 : IHash
    {
        public string GetHashResult(string password)
        {
            //  Useing SHA-512 
            throw new NotImplementedException();
        }
    }
}
