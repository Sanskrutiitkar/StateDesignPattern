using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.model
{
    internal class GreenLightState : ITrafficLightState
    {
        private TrafficLight _trafficLight;

        public GreenLightState(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Change()
        {
            Console.WriteLine("Green Light: Cars can go.");
            // Transition to the next state
            _trafficLight.SetState(new YellowLightState(_trafficLight));
        }

    }
}
