using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klusser.Models
{
    public class ChoreShop : Chore
    {

        #region construstors
        public ChoreShop(string name, int points) : base(name, points)
        {
        } 
        #endregion

        public override void PromptUser(User user)
        {
            
        }
    }
}
