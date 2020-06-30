using System;
using System.Globalization;
using Xunit;

namespace xUnitCulture
{
    public class UnitTest1
    {
        [Fact]
        public void CheckGermanCulture()
        {
            var expected = "Guten Tag";
            var actual = GetResourceWithCulture("de");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckFrenchCulture()
        {
            var expected = "Bonjour";
            var actual = GetResourceWithCulture("fr");
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("nb")]
        [InlineData("nb-NO")]
        [InlineData("no")]
        public void CheckNorwegianBokmalCulture(string norwegianCulture)
        {
            var expected = "Hei";
            var actual = GetResourceWithCulture(norwegianCulture);
            Assert.Equal(expected, actual);
        }


        private string GetResourceWithCulture(string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
            var resource = Resource.Greeting;
            return resource;
        }
    }
}
