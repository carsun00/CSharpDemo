using Interface_Oriented.ModelAuthentication.Interface;
using System;

namespace Interface_Oriented.ModelAuthentication.Entity
{
    class AccountDB : IAccountDao
    {
        public string GetPassword(string id)
        {
            //  Get Data From DataBase
            throw new NotImplementedException();
        }
    }
}
