using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptops
{
    class Battery
    {
        private string batteryType;
        private float batteryLife;

        public Battery(string type)
        {
            this.BatteryType = type;
        }

        public Battery(string type, float life)
            : this(type)
        {
            this.BatteryLife = life;
        }

        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Battery type cannot be empty.");
                }
                this.batteryType = value;
            }
        }

        public float BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be negative.");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            string result = null;
            if (this.batteryType != null)
            {
                result = "Battery: " + this.batteryType;
            }
            if (this.batteryLife > 0)
            {
                result += Environment.NewLine + "Battery Life: " + this.batteryLife + " hours";
            }
            return result;
        }
    }
}
