using System.Xml;

namespace ManifestTester
{
    public class ManifestChecker
    {
        public Result Result { get; }

        public ManifestChecker()
        {
            Result = new Result();
        }

        public void Check(XmlDocument doc)
        {
            var root = doc.DocumentElement;
            if (root != null && 
                root.Name == "manifest" &&
                root.NamespaceURI == "http://www.imsglobal.org/xsd/imscp_v1p1")
            {
                Result.Passed = true;
            }
            else
            {
                Result.Passed = false;
            }
        }
    }
}