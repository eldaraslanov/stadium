using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stadium
{


    #region extension
    static class Extension
    {
        public static bool  IsEmpty(string [] inputArr,string inp)
        {
            foreach ( var arrItem in inputArr)
            {
                if (arrItem==inp)
                {
                    return false;
                }
            }
            return true;
        }
    }
    #endregion
}
