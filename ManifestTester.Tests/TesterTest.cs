using System.Xml;
using Xunit;

namespace ManifestTester.Tests
{
    public class TesterTest
    {
        private readonly XmlDocument _doc = new XmlDocument();
        
        [Fact]
        public void LoadXml()
        {
            Tester tester = new Tester(_doc);
            
            Assert.IsType<XmlDocument>(tester.Doc);
        }

        [Fact]
        public void Check_Manifest_RootElement()
        {
            Tester tester = new Tester(_doc);
        }
    }
}