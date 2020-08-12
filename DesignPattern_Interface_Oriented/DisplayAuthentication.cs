using Interface_Oriented.ModelAuthentication.Entity;
using Interface_Oriented.ModelAuthentication.Interface;
using Interface_Oriented.ModelAuthentication.Logic;

namespace Interface_Oriented
{
    class DisplayAuthentication
    {
        /// <summary>
        ///     Useing Api Data With SHA-256
        /// </summary>
        /// <returns></returns>
        public bool GetFromAPIWithHash256()
        {
            //  initial Dao and Hash.
            IAccountDao dao = new AccountAPI();
            IHash hash = new Hash256();

            //  initial Validtion
            Validation validation = new Validation(dao, hash);

            //  give data
            string id = "Demo";
            string password = "DemoPassword";

            return validation.CheckAuthentication(id, password);
        }


        /// <summary>
        ///     Useing Api Data With SHA-512
        /// </summary>
        /// <returns></returns>
        public bool GetFromAPIWithHash512()
        {
            //  initial Dao and Hash.
            IAccountDao dao = new AccountAPI();
            IHash hash = new Hash512();

            //  initial Validtion
            Validation validation = new Validation(dao, hash);

            //  give data
            string id = "Demo";
            string password = "DemoPassword";

            return validation.CheckAuthentication(id, password);
        }

        /// <summary>
        ///     Useing Api Data With SHA-512
        /// </summary>
        /// <returns></returns>
        public bool GetFromDBWithHash512()
        {
            //  initial Dao and Hash.
            IAccountDao dao = new AccountDB();
            IHash hash = new Hash512();

            //  initial Validtion
            Validation validation = new Validation(dao, hash);

            //  give data
            string id = "Demo";
            string password = "DemoPassword";

            return validation.CheckAuthentication(id, password);
        }
    }
}
