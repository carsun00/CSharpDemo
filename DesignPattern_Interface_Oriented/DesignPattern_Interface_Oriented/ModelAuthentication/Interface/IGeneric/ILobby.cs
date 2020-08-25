namespace Interface_Oriented.ModelAuthentication.Interface
{
    interface ILobby<T>
    {
        #region 基礎屬性

        public string Status
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string ErrorCode
        {
            get;
            set;
        }

        #endregion

        public T DataInfo  //T as return type of property
        { get; set; }

        #region 方法
        bool CheckStatus();
        #endregion
    }
}
