﻿namespace AoE2NetDesktop.AoE2DE.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class AoE2DeAppTests
{
    [TestMethod]
    public void GetPathTest()
    {
        // Arrange
        var expVal = @"C:\Program Files (x86)\Steam\steamapps\common\AoE2DE\";

        // Act
        var actVal = AoE2DeApp.GetPath();

        // Assert
        Assert.AreEqual(expVal, actVal);
    }

    [TestMethod]
    [DataRow("Aztecs", @"C:\Program Files (x86)\Steam\steamapps\common\AoE2DE\widgetui\textures\menu\civs\aztecs.png")]
    [DataRow("Hindustanis", @"C:\Program Files (x86)\Steam\steamapps\common\AoE2DE\widgetui\textures\menu\civs\indians.png")]
    [DataRow("", @"https://aoe2.net/assets/images/crests/25x25/.png")]
    public void GetCivImageLocationTest(string civ, string expVal)
    {
        // Arrange

        // Act
        var actVal = AoE2DeApp.GetCivImageLocation(civ);

        // Assert
        Assert.AreEqual(expVal, actVal);
    }
}
