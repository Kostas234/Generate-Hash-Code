using GenerateHashCode.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    //[TestClass]
    public class TestClass
    {
        [TestMethod]
        public void CreateMDTest()
        {
            var obj = new GenerateHash();
            string expected = "E012A61C6D1A4F875A3CA17DF394BE98";
            string actual = obj.CreateMD5("wewew");
            Assert.AreEqual(expected, actual);
        }
    }  
}
