using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class CheckGroupNo
    {
        public static bool CheckGroupNoo(this string GroupNo) 
        {
            if (GroupNo.Length == 4 && char.IsLetter(GroupNo[0]) && char.IsDigit(GroupNo[1]) && char.IsDigit(GroupNo[2]) && char.IsDigit(GroupNo[3]) )
            {
                return true;
            }
            return false;
        }

        public static bool CheckFullName(this string FullName) 
        {
            if (FullName.Split(" ").Length == 2 && FullName.Split(" ")[1] != "")
            {
                return true;
            }
            return false;
        }
    }
}
