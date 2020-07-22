using System.Xml;

namespace ManifestTester
{
    public class ManifestChecker
    {
        private readonly Result _result;

        public ManifestChecker()
        {
            _result = new Result();
        }

        public Result Check(XmlDocument doc)
        {
            XmlElement root = doc.DocumentElement;
            if (root != null && 
                root.Name == "manifest" &&
                root.NamespaceURI == "http://www.imsglobal.org/xsd/imscp_v1p1")
            {
                _result.Passed = true;
            }
            else
            {
                _result.Passed = false;
            }

            return _result;
        }
    }
}