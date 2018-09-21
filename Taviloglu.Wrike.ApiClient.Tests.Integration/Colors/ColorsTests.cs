﻿using NUnit.Framework;

namespace Taviloglu.Wrike.ApiClient.Tests.Integration.Colors
{
    [TestFixture]
    public class ColorsTests
    {
        WrikeClient _wrikeClient;
        [SetUp]
        public void Setup()
        {
            _wrikeClient = new WrikeClient("eyJ0dCI6InAiLCJhbGciOiJIUzI1NiIsInR2IjoiMSJ9.eyJkIjoie1wiYVwiOjIzMTc2ODQsXCJpXCI6NTM3NDAyNCxcImNcIjo0NTk1MDE0LFwidlwiOm51bGwsXCJ1XCI6NDc2NzU4MSxcInJcIjpcIlVTXCIsXCJzXCI6W1wiV1wiLFwiRlwiLFwiSVwiLFwiVVwiLFwiS1wiLFwiQ1wiXSxcInpcIjpbXSxcInRcIjowfSIsImlhdCI6MTUzNzMyMTkyOH0.r8MaouEsyTiWJ0qPqUt2McslSPP2NTinL9YrnQ9Lcow");
        }

        [Test]
        public void GetAsync_ShouldRetun64Colors()
        {
            var expectedColorCount = 64;

            var actualColorCount = _wrikeClient.Colors.GetAsync().Result.Count;

            Assert.AreEqual(expectedColorCount, actualColorCount);
        }
    }
}
