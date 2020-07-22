using System.Collections.Generic;
using System.Xml;

namespace ManifestTester
{
    public class ManifestChecker
    {
        private readonly Result _result;
        private List<string> _checkMessages = new List<string>();

        public ManifestChecker()
        {
            _result = new Result();
        }

        public Result Check(XmlDocument doc)
        {
            XmlElement root = doc.DocumentElement;
            if (root != null && 
                root.Name == "manifest"
                )
            {
                if (root.NamespaceURI == "http://www.imsglobal.org/xsd/imscp_v1p1")
                {
                    _result.Passed = true;
                }
                else
                {
                    _result.Passed = false;
                    _result.AddMessage(Messages.ManifestCheck_1);
                }
            }
            else
            {
                _result.AddMessage(Messages.ManifestCheck_0);
                _result.Passed = false;
            }

            return _result;
        }

        public List<string> GetMessages()
        {
            return _checkMessages;
        }
    }
}