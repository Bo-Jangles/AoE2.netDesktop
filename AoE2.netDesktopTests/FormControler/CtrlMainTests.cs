﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibAoE2net;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using AoE2NetDesktop.Tests;

namespace AoE2NetDesktop.Form.Tests
{
    [TestClass()]
    public class CtrlMainTests
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            if (context is null) {
                throw new ArgumentNullException(nameof(context));
            }

            AoE2net.ComClient = new TestHttpClient();
            StringsExt.InitAsync();
        }

        [TestMethod()]
        public void CtrlMainTest()
        {
            // Arrange
            // Act
            var testClass = new CtrlMain();

            // Assert
            Assert.AreEqual("N/A", testClass.UserCountry);
            Assert.AreEqual("-- Invalid ID --", testClass.UserName);
        }

        [TestMethod()]
        public void InitAsyncTest()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();

            // Act
            var testClass = new CtrlMain();
            var actVal = Task.Run(
                () => CtrlMain.InitAsync(Language.en)
                ).Result;

            // Assert
            Assert.IsTrue(actVal);
        }

        [TestMethod()]
        [DataRow(true, true, false)]
        [DataRow(false, true, true)]
        [DataRow(null, true, false)]
        public void GetFontStyleTest(bool? won, bool isBold, bool isStrikeout)
        {
            // Arrange
            var player = new Player {
                Won = won
            };
            var prototype = new Font(new Label().Font, FontStyle.Regular);

            // Act
            var expVal = CtrlMain.GetFontStyle(player, prototype);

            // Assert
            Assert.AreEqual(isBold, expVal.Bold);
            Assert.AreEqual(isStrikeout, expVal.Strikeout);
        }

        [TestMethod()]
        [DataRow(TeamType.OddColorNo, 4)]
        [DataRow(TeamType.EvenColorNo, 40)]
        public void GetAverageRateTest(TeamType teamType, int expVal)
        {
            // Arrange
            var players = new List<Player> {
                new Player { Color = 1, Rating = 1 },
                new Player { Color = 2, Rating = 10 },
                new Player { Color = 3, Rating = 3 },
                new Player { Color = 4, Rating = 30 },
                new Player { Color = 5, Rating = 5 },
                new Player { Color = 6, Rating = 50 },
                new Player { Color = 7, Rating = 7 },
                new Player { Color = 8, Rating = 70 },
            };

            // Act
            var actVal = CtrlMain.GetAverageRate(players, teamType);

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        [DataRow(TeamType.OddColorNo, 3)]
        [DataRow(TeamType.EvenColorNo, 30)]
        public void GetAverageRateTestIncludeRateNull(TeamType teamType, int expVal)
        {
            // Arrange
            var players = new List<Player> {
                new Player { Color = 1, Rating = 1 },
                new Player { Color = 2, Rating = 10 },
                new Player { Color = 3, Rating = 3 },
                new Player { Color = 4, Rating = 30 },
                new Player { Color = 5, Rating = 5 },
                new Player { Color = 6, Rating = 50 },
                new Player { Color = 7, Rating = null },
                new Player { Color = 8, Rating = null },
            };

            // Act
            var actVal = CtrlMain.GetAverageRate(players, teamType);

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        public void GetAverageRateTestArgumentOutOfRangeException()
        {
            // Arrange
            // Act
            // Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                _ = CtrlMain.GetAverageRate(new List<Player>(), (TeamType)(-1));
            });
        }

        [TestMethod()]
        [DataRow(IdType.Steam, TestData.AvailableUserSteamId)]
        [DataRow(IdType.Profile, TestData.AvailableUserProfileIdString)]
        public void GetPlayerLastMatchAsyncTest(IdType idType, string id)
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();

            // Act
            var actVal = Task.Run(
                () => CtrlMain.GetPlayerLastMatchAsync(idType, id)
                ).Result;

            // Assert
            Assert.AreEqual(TestData.AvailableUserSteamId, actVal.SteamId);
            Assert.AreEqual(TestData.AvailableUserProfileId, actVal.ProfileId);
            Assert.AreEqual(3333, actVal.LastMatch.Players[2].Rating);
        }

        [TestMethod()]
        public void GetPlayerLastMatchAsyncTestInvalidArg()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();

            // Act
            var actVal = Task.Run(
                () => CtrlMain.GetPlayerLastMatchAsync(IdType.NotSelected, TestData.AvailableUserSteamId)
                ).Result;

            // Assert
            Assert.IsNull(actVal.ProfileId);
        }

        [TestMethod()]
        public async Task GetPlayerLastMatchAsyncTestFormatExceptionAsync()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();

            // Act
            // Assert
            await Assert.ThrowsExceptionAsync<FormatException>(() =>
                CtrlMain.GetPlayerLastMatchAsync(IdType.Steam, "FormatException")
            );
        }

        [TestMethod()]
        public async Task GetPlayerLastMatchAsyncTestNullAsync()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();

            // Act
            // Assert
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(() =>
                CtrlMain.GetPlayerLastMatchAsync(IdType.Steam, null)
            );
        }

        [TestMethod()]
        public async Task GetPlayerLastMatchAsyncTestHttpRequestExceptionAsync()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient() {
                ForceHttpRequestException = true,
            };
            // Act
            // Assert
            await Assert.ThrowsExceptionAsync<HttpRequestException>(() =>
                CtrlMain.GetPlayerLastMatchAsync(IdType.Steam, TestData.AvailableUserSteamId)
            );
        }

        [TestMethod()]
        [DataRow(1, "1")]
        [DataRow(null, " N/A")]
        public void GetRateStringTest(int? rate, string expVal)
        {
            // Arrange
            // Act
            var actVal = CtrlMain.GetRateString(rate);

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        [DataRow("testName", "testName")]
        [DataRow(null, "-- AI --")]
        public void GetPlayerNameStringTest(string name, string expVal)
        {
            // Arrange
            // Act
            var actVal = CtrlMain.GetPlayerNameString(name);

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        public void DelayStartTest()
        {
            // Arrange
            var isCalledFunction = false;

            // Act
            var testClass = new CtrlMain() {
                Scheduler = TaskScheduler.Current,
            };

            Task function()
            {
                isCalledFunction = true;
                return Task.CompletedTask;
            };

            testClass.DelayStart(function);
            Task.Delay(1600).Wait();

            // Assert
            Assert.IsTrue(isCalledFunction);
        }

        [TestMethod()]
        [DataRow(IdType.Steam, TestData.AvailableUserSteamId)]
        [DataRow(IdType.Profile, TestData.AvailableUserProfileIdString)]
        [DataRow(IdType.Profile, TestData.AvailableUserProfileIdWithoutSteamIdString)]
        public void GetPlayerDataAsyncTest(IdType idType, string id)
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var notExpValUserCountry = "N/A";
            var notExpValUserName = "-- Invalid ID --";

            // Act
            var testClass = new CtrlMain();
            var actVal = Task.Run(
                () => testClass.ReadPlayerDataAsync(idType, id)
                ).Result;

            // Assert
            Assert.IsTrue(actVal);
            Assert.AreNotEqual(notExpValUserCountry, testClass.UserCountry);
            Assert.AreNotEqual(notExpValUserName, testClass.UserName);
        }

        [TestMethod()]
        public void GetPlayerDataAsyncTestException()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var expValUserCountry = "N/A";
            var expValUserName = "-- Invalid ID --";

            // Act
            var testClass = new CtrlMain();
            try {
                var actVal = Task.Run(
                    () => {
                        // The following code can read the player data.
                        _ = testClass.ReadPlayerDataAsync(IdType.Profile, TestData.AvailableUserProfileIdString);
                        // The following code cannot read the player data, so write null to playerLastmatch..
                        return testClass.ReadPlayerDataAsync(IdType.Profile, "-1");
                    }
                    ).Result;
            } catch (Exception) {
            }

            // Assert
            Assert.AreEqual(expValUserCountry, testClass.UserCountry);
            Assert.AreEqual(expValUserName, testClass.UserName);
        }

        [TestMethod()]
        public void GetPlayerDataAsyncTestAvailableUserProfileIdWithoutSteamIdString()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var notExpValUserCountry = "N/A";
            var notExpValUserName = "-- Invalid ID --";


            // Act
            var testClass = new CtrlMain();
            var actVal = Task.Run(
                () => testClass.ReadPlayerDataAsync(IdType.Profile, TestData.AvailableUserProfileIdWithoutSteamIdString)
                ).Result;

            // Assert
            Assert.IsTrue(actVal);
            Assert.AreNotEqual(notExpValUserCountry, testClass.UserCountry);
            Assert.AreNotEqual(notExpValUserName, testClass.UserName);
            Assert.AreEqual(TestData.AvailableUserProfileIdWithoutSteamId, testClass.ProfileId);
            Assert.IsNull(testClass.SteamId);
        }

        [TestMethod()]
        public void GetPlayerDataAsyncTestInvalidArg()
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var expValUserCountry = "N/A";
            var expValUserName = "-- Invalid ID --";

            // Act
            var testClass = new CtrlMain();
            var actVal = Task.Run(
                () => testClass.ReadPlayerDataAsync(IdType.NotSelected, TestData.AvailableUserSteamId)
                ).Result;

            // Assert
            Assert.IsTrue(actVal);
            Assert.AreEqual(expValUserCountry, testClass.UserCountry);
            Assert.AreEqual(expValUserName, testClass.UserName);
        }

        [TestMethod()]
        [DataRow(9, "Arabia")]
        [DataRow(0, "Unknown(Map No.0)")]
        [DataRow(null, "Unknown(Map No. N/A)")]
        public void GetMapNameTest(int? mapType, string expVal)
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var match = new Match() {
                MapType = mapType,
            };

            // Act
            var testClass = new CtrlMain();
            _ = Task.Run(
                () => CtrlMain.InitAsync(Language.en)
                ).Result;

            var actVal = match.GetMapName();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        [DataRow(0, "invalid civ:0")]
        [DataRow(1, "Britons")]
        [DataRow(37, "Sicilians")]
        [DataRow(40, "invalid civ:40")]
        [DataRow(null, "invalid civ:null")]
        public void GetCivEnNameTest(int? civ, string expVal)
        {
            // Arrange
            AoE2net.ComClient = new TestHttpClient();
            var player = new Player() {
                Civ = civ,
            };

            // Act
            var testClass = new CtrlMain();
            _ = Task.Run(
                () => CtrlMain.InitAsync(Language.en)
                ).Result;

            var actVal = player.GetCivEnName();

            // Assert
            Assert.AreEqual(expVal, actVal);
        }

        [TestMethod()]
        public void ShowHistoryTest()
        {
            // Arrange

            // Act
            var testClass = new CtrlMain() {
                SelectedId = IdType.Steam,
            };

            testClass.ShowHistory();

            // Assert
        }
    }
}