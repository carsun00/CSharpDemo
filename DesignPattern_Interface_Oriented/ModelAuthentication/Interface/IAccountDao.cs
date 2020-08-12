namespace Interface_Oriented.ModelAuthentication.Interface
{
    interface IAccountDao
    {
        //  取得資料來源的方式
        string GetPassword(string id);
    }
}
