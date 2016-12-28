using System;

namespace Klusser.Models
{
    internal class Chore
    {
        #region field
        private readonly int _points;

        #endregion

        //field wordt automatisch aangemaakt
        #region properties
        public string Name { get; set; }
        public DateTime Date { get;} = DateTime.Now;
        //negatieve&positieve bonus van 10%?

        #endregion

        #region constructors
        public Chore(string name, int points)
        {
            Name = name;
            _points = points;
        }

        #endregion

    }
}
