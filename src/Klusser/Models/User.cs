﻿using System.Collections.Generic;

namespace Klusser.Models
{
    public class User
    {
        #region fields
        private string _password;

        #endregion

        #region properties
        private int Score { get; set; }

        public string Name { get; set; }
        public string Password { get; private set; }
        public string Color { get; set; }


        //niet zeker
        public List<Chore> ChoreHistoryList { get; }
        #endregion

        #region constructors
        public User(string name, string password, int score)
        {
            Name = name;
            _password = password;
            Score = score;

            ChoreHistoryList = new List<Chore>();

            Password = createPassword();
        }

        #endregion

        #region methods
        //klopt niet
        private string createPassword()
        {
            string psswd = "";

            return psswd;

        }
        

        #endregion
    }
}
