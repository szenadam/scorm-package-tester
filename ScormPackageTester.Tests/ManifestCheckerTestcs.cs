using System.Xml;
using ScormPackageTester;
using Xunit;

namespace ManifestTester.Tests
{
    public class ManifestCheckerTest
    {
        [Fact(DisplayName = "Should pass on valid root element and namespace")]
        public void Check_RootElement_PassAndFail()
        {
            XmlDocument doc = new XmlDocument();
            var checker = new ManifestChecker();
            Result result = checker.Check(doc);
            Assert.False(result.Passed);

            XmlNode node = doc.CreateElement("manifest");
            doc.AppendChild(node);
            result = checker.Check(doc);
            Assert.False(result.Passed);
            Assert.Equal("Root element in manifest file is invalid.", result.GetMessages()[0]);


            doc.RemoveAll();
            node = doc.CreateElement("manifest", "http://www.imsglobal.org/xsd/imscp_v1p1");
            doc.AppendChild(node);
            result = checker.Check(doc);
            
            Assert.True(result.Passed);
            Assert.Equal("Root element namespace is invalid.", result.GetMessages()[1]);
        }
    }
}