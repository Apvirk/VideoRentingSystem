using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentingSystem;

namespace RentalTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckDBConn()
        {
            Assert.AreEqual("Closed", new Database().CheckConnection());
        }

        [TestMethod]
        public void CheckData()
        {
            Assert.IsNotNull(new Database().GetTopMovies());
        }
    }
}
