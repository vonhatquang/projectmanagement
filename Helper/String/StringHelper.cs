using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class StringHelper : IStringHelper
    {
        #region "String Encode/Decode"
        public string EncodeString(string originString)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(originString));
        }

        public string DecodeString(string encodeString)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(encodeString));
        }
        #endregion

        #region "User Name Encode - Compare"
        public string EncodeUserName(string originUserName)
        {
            return this.EncodeString(this.EncodeString(originUserName));
        }

        public bool CompareUserName(string userName, string dbUserName)
        {
            return userName.Equals(dbUserName);
        }
        #endregion

        #region "Password Encode - Compare"
        public string EncodePassword(string originPassword)
        {
            return this.EncodeString(this.EncodeString(originPassword));
        }

        public bool ComparePassword(string password, string dbPassword)
        {
            return password.Equals(dbPassword);
        }
        #endregion

        #region "GUI ID Generate"
        public Guid GuiIdGenerate(){
            return Guid.NewGuid();
        }
        #endregion
    }
}
