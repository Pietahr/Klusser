using System.Collections.Generic;

namespace Klusser.Models
{
    internal class Household
    {
        #region fields

        #endregion

        #region properties

        public List<Chore> ChoreList { get; }
        public List<User> UserList { get; }
        public string Name { get; set; }

        #endregion

        #region constructors

        public Household(List<Chore> choreList, List<User> userList)
        {
            ChoreList = choreList;
            UserList = userList;
        }

        #endregion

        #region methods

        

        #endregion
    }
}
