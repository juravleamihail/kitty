using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty.Reader;
using Kitty;
using System.Data.Entity;


namespace Tests
{
    [TestClass]
   public class ReadingFromFile
    {

        [TestMethod]
        public void CanReadFromJsonFile()
        {
            string locations = null;
            locations = JsonLocationReader.ReadJsonFile();
            Assert.IsNotNull(locations);
        }

        [TestMethod]
        public void CanSplitStrigInCities()
        {
            string locations = JsonLocationReader.ReadJsonFile();
            string[] cities = JsonLocationReader.SplitCities(locations);
            Assert.IsNotNull(cities);

        }

    }
}
