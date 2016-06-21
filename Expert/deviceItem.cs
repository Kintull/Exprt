using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert
{
    public class deviceItem
    {

        public deviceItem(string name, deviceItem.DeviсeType type, int id, int width)
        {
            timeBoxesList = new bool[width];
            timeBoxesList.Select(i => false).ToArray();
            connections = new List<int>(width);
            timeWidth = width;
            deviceName = name;
            deviceType = type;
            deviceNumber = id;
            addConnection(id);
        }

        public enum DeviсeType { SENSOR, MOTOR, UNKNOWN };

        private int timeWidth;
        private string deviceName;
        private DeviсeType currentdeviceType;
        private bool[] timeBoxesList;
        private List<int> connections;
        private int currentDeviceNumber;

        public DeviсeType deviceType
        {
            get
            {
                return currentdeviceType;
            }
            set
            {
                currentdeviceType = value;
            }
        }

        public int deviceNumber
        {
            get
            {
                return currentDeviceNumber;
            }
            set
            {
                currentDeviceNumber = value;
            }
        }

        public string getName()
        {
            return deviceName;
        }

        public void setName(string name)
        {
            deviceName = name;
        }

        public DeviсeType getDeviceType()
        {
            return deviceType;
        }

        public void setDeviceType(DeviсeType type)
        {
            deviceType = type;
        }

        public bool[] getBoxes()
        {
            return timeBoxesList;
        }

        public void setBoxes(bool[] values)
        {
            timeBoxesList = values;
        }

        public List<int> getConnections()
        {
            return connections;
        }

        public void addConnection(int aConnection)
        {
            connections.Add(aConnection);
        }

        
        
    }
}
