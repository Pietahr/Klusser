using System;

namespace Klusser.Models
{
    public class Chore
    {
        #region field

        #endregion

        //field wordt automatisch aangemaakt
        #region properties
        public string Name { get; set; }
        public int Points { get; }
        public DateTime DateOfChore { get; private set; }
        //negatieve&positieve bonus van 10%?

        #endregion

        #region constructors
        public Chore(string name, int points)
        {
            Name = name;
            Points = points;
            DateOfChore = DateTime.Now;

        }

        #endregion

        #region methods
        //Different chores produce different questions posed to the user
        public virtual void PromptUser(User user)
        {
            
        }

        #endregion
    }
}
