using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.model
{
    internal class RedLightState : ITrafficLightState
    {
        private  TrafficLight _trafficLight;

        public RedLightState(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Change()
        {
            Console.WriteLine("Red Light: Cars must stop.");
            // Transition to the next state
            _trafficLight.SetState(new GreenLightState(_trafficLight));
        }

    }
}
