using System;
using System.Collections;
using System.Collections.Generic;

namespace Klusser.Models
{
    public class Chore
    {
        #region field
        private readonly int _points;

        #endregion

        //field wordt automatisch aangemaakt
        #region properties
        public string Name { get; set; }
        public DateTime Date { get; private set; }
        //negatieve&positieve bonus van 10%?
        private IEnumerable<string> _lijst = new List<string>();
        private ICollection<string> _lijst2 = new List<string>();

        #endregion

        #region constructors
        public Chore(string name, int points)
        {
            Name = name;
            _points = points;
            Date = DateTime.Now;

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
