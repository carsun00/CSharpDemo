using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity
{
    class AccountTxt : IAccountDao
    {
        public string GetPassword(string id)
        {
            //  Get Data From Txt File
            throw new NotImplementedException();
        }
    }
}
