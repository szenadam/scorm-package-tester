using System.Xml;
using Xunit;

namespace ManifestTester.Tests
{
    public class ManifestCheckerTest
    {
        [Fact]
        public void CheckRootElement()
        {
            XmlDocument doc = new XmlDocument();
            var checker = new ManifestChecker();
            checker.Check(doc);
            Assert.False(checker.Result.Passed);
            
            XmlNode node = doc.CreateElement("manifest");
            doc.AppendChild(node);
            checker.Check(doc);
            Assert.False(checker.Result.Passed);
            
            
            doc.RemoveAll();
            node = doc.CreateElement("manifest", "http://www.imsglobal.org/xsd/imscp_v1p1");
            doc.AppendChild(node);
            checker.Check(doc);
            Assert.True(checker.Result.Passed);
        }
    }
}