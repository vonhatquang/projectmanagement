using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public interface IStringHelper
    {
        string EncodeString(string originString);
        string DecodeString(string encodeString);
        string EncodeUserName(string originUserName);
        bool CompareUserName(string userName, string dbUserName);
        string EncodePassword(string originPassword);
        bool ComparePassword(string password, string dbPassword);
        Guid GuiIdGenerate();
    }
}
