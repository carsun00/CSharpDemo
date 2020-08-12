namespace Interface_Oriented.ModelAuthentication.Interface
{
    interface IHash
    {
        //  取得雜湊碼
        string GetHashResult(string password);
    }
}
