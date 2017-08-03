using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kitty.Reader;
using Kitty;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
   public class ReadingFromFile
    {

        [TestMethod]
        public void CanReadFromJsonFile()
        {
            IEnumerable<string> locations = null;
            locations = JsonLocationReader.Cities();
            Assert.IsNotNull(locations);
            Assert.IsTrue(locations.Count()>0);
        }
    }
}
