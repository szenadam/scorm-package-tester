using System.Xml;

namespace ManifestTester
{
    public class Tester
    {
        /// <summary>
        /// The Manifest XML Document.
        /// </summary>
        public XmlDocument Doc { get; }
        
        public Tester(XmlDocument manifestDoc)
        {
            Doc = manifestDoc;
        }        
    }
}