using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abyat.Tournament.Tournments;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Abyat.Tournament.Players;

namespace Abyat.Tournamet.Tests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void Match_TwoWinnerTeams_ShouldBeInValid()
        {
            Match match = new Match
            {
                Team1 = new Team { IsWinner = true , Players = new List<Player>() },
                Team2 = new Team { IsWinner = true , Players = new List<Player>() }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(match, new ValidationContext(match), validationResults, true);

            Assert.AreEqual(actual, false);
            Assert.AreEqual(validationResults.First().ErrorMessage, "Match must has one winner");
        }
        [TestMethod]
        public void Match_TwoLoserTeams_ShouldBeInValid()
        {
            Match match = new Match
            {
                Team1 = new Team { IsWinner = false , Players = new List<Player>() },
                Team2 = new Team { IsWinner = false , Players = new List<Player>() }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(match, new ValidationContext(match), validationResults, true);

            Assert.AreEqual(actual, false);
            Assert.AreEqual(validationResults.First().ErrorMessage, "Match must has one winner");
        }
        [TestMethod]
        public void Match_OneWinnerTeam_ShouldBeValid()
        {
            Match match = new Match
            {
                Team1 = new Team { IsWinner = true, Players = new List<Player>() },
                Team2 = new Team { IsWinner = false, Players = new List<Player>() }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(match, new ValidationContext(match), validationResults, true);

            Assert.AreEqual(actual, true);
        }
        [TestMethod]
        public void Match_PlayerInTwoTeams_ShouldBeInValid()
        {
            Match match = new Match
            {
                Team1 = new Team { IsWinner = true, Players = new List<Player> { new HandBallPlayer { NickName = "Badr" } } },
                Team2 = new Team { IsWinner = false, Players = new List<Player> { new HandBallPlayer { NickName = "Badr" } } }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(match, new ValidationContext(match), validationResults, true);

            Assert.AreEqual(actual, false);
            Assert.AreEqual(validationResults.First().ErrorMessage, "Player must play in one team in the same match");
        }
        [TestMethod]
        public void Match_UniquePlayerInTeams_ShouldBeInValid()
        {
            Match match = new Match
            {
                Team1 = new Team { IsWinner = true, Players = new List<Player> { new HandBallPlayer { NickName = "Badr" } } },
                Team2 = new Team { IsWinner = false, Players = new List<Player> { new HandBallPlayer { NickName = "Mooo" } } }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(match, new ValidationContext(match), validationResults, true);

            Assert.AreEqual(actual, true);
        }
    }
    
}
