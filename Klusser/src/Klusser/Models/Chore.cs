using System;
using System.Reflection.Metadata;

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
        public DateTime date { get;} = DateTime.Now;
        //negatieve&positieve bonus van 10%?

        #endregion

        #region constructors
        public Chore(string name, int points)
        {
            this.Name = name;
            this._points = points;
        }

        #endregion

    }
}
