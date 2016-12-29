using System;
using Klusser.Models;
using Xunit;


namespace Klusser.Tests.Models
{
    public class ChoreTest
    {
     
        private Chore _chore;

        public ChoreTest()
        {
            _chore = new Chore("Stofzuigen",100);
        }

        [Fact]
        public void NewChore_SetsDateOfChore()
        {
            DateTime dateTime = DateTime.Now;
            DateTime dateTimePre = new DateTime(dateTime.Year,dateTime.Month,dateTime.Day,dateTime.Hour,dateTime.Minute-15,0);
            DateTime dateTimePost = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute+15, 0);

            Assert.InRange(_chore.DateOfChore,dateTimePre, dateTimePost);
        }
    }
}
