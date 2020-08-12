using Interface_Oriented.ModelAuthentication.Interface;

namespace Interface_Oriented.ModelAuthentication.Logic
{
    class Validation
    {
        private IAccountDao accountDao;
        private IHash hash;

        public Validation(IAccountDao dao, IHash hash)
        {
            this.accountDao = dao;
            this.hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        {
            //  get data password by id
            var passwordByDao = this.accountDao.GetPassword(id);

            //  get hash password 
            var hashResult = this.hash.GetHashResult(password);

            //  Validation
            return passwordByDao == hashResult;

        }
    }
}
