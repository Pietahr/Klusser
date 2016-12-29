using System;
using System.Collections.Generic;

namespace Klusser.Models
{
    public class Household
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

        public ICollection<Chore> GetChores(DateTime? from, DateTime? till)
        {
            if (from == null && till == null) return ChoreList;
            if (from == null) from = DateTime.MinValue;
            if(!till.HasValue) till = DateTime.MaxValue;

            ICollection<Chore> choreList = new List<Chore>();
            foreach (Chore c in ChoreList)
            {
                if (c.DateOfChore >= from && c.DateOfChore <= till)
                    choreList.Add(c);
            }
            return choreList;
        }
        

        #endregion
    }
}
