using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klusser.Models
{
    internal class Household
    {
        #region fields
        private List<Chore> _choreList;
        private List<User> _userList;
        #endregion


        #region properties

        public string Name { get; set; }

        #endregion

        #region constructors

        public Household(List<Chore> choreList, List<User> userList)
        {
            _choreList = choreList;
            _userList = userList;
        }

        #endregion

        #region methods

        

        #endregion
    }
}
