using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeController
{
    internal class SmartThermostat
    {
        //private fields
        private double currentTemperature;
        private double targetTemperature;

        //public properties
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set { currentTemperature = value; }
        }

        public double TargetTemperature
        {
            get { return targetTemperature; }
            set { targetTemperature = value; }
        }

        //constructor
    }
}
