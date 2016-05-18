using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert
{
    public class deviceItem
    {
        public enum DeviсeType { SENSOR, MOTOR, UNKNOWN };

        private string deviceName;
        private DeviсeType deviceType;
        private List<int> activeBoxesList = new List<int>(100);
        private List<int> connections = new List<int>(30);
        private int currentDeviceNumber;

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

        public List<int> getActiveBoxes()
        {
            return activeBoxesList;
        }

        public void setActiveBoxes(List<int> values)
        {
            activeBoxesList = values;
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
