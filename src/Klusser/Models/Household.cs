using System.Collections.Generic;

namespace Klusser.Models
{
    internal class Household
    {
        #region fields

        #endregion

        #region properties

        public ICollection<Chore> ChoreList { get; }
        public IEnumerable<User> UserList { get; }
        public string Name { get; set; }

        #endregion

        #region constructors

        public Household()
        {
            ChoreList = new List<Chore>();
            UserList = new List<User>() { new User("Mathieu"),new User("Corten"), new User("Pieter")};
        }

        #endregion

        #region methods

        

        #endregion
    }
}
