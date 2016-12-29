using System;
using System.Collections.Generic;
using Klusser.Models;
using Xunit;

namespace Klusser.Tests.Models
{
    public class HouseholdTest
    {
        private Household _household;
        public HouseholdTest()
        {
            _household = new Household();
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                DateTime yesterday = DateTime.Today.AddDays(-1);
                DateTime tomorrow = DateTime.Today.AddDays(1);

                yield return new Object[] { null, null, 2 };//All
                yield return new Object[] { yesterday, tomorrow, 2 };//WithinAPeriodThatHasTransactions
                yield return new Object[] { yesterday, yesterday, 0 };//WithinAPeriodThatHasNoTransactions
                yield return new Object[] { null, tomorrow, 2 };//BeforeADateWithTransactions
                yield return new Object[] { null, yesterday, 0 };//BeforeADateWithoutTransactions
                yield return new Object[] { yesterday, null, 2 };//AfterADateWithTransactions
                yield return new Object[] { tomorrow, null, 0 }; //AfterADateWithoutTransactions
            }
        }


        [Theory]
        [MemberData("TestData")]
        public void GetChores_ReturnsChores(DateTime? from, DateTime? till, int expected)
        {
        Chore c1 = new Chore(" ", 0);
        Chore c2 = new Chore(" ", 0);

        _household.ChoreList.Add(c1);
        _household.ChoreList.Add(c2);

        Assert.Equal(expected, _household.GetChores(from,till).Count);

        }
    }
}
