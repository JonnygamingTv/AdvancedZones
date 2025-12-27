using System.Xml.Serialization;

namespace Game4Freak.AdvancedZones
{
    public class Node
    {
        [XmlElement("x")]
        public float x;
        [XmlElement("z")]
        public float z;
        [XmlElement("y")]
        public float y;
        
        public Node()
        {
        }

        public Node(float nX, float nZ, float nY)
        {
            x = nX;
            z = nZ;
            y = nY;
        }
    }
}
