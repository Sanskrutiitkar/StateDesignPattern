using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.model
{
    internal class YellowLightState : ITrafficLightState
    {
        private TrafficLight _trafficLight;

        public YellowLightState(TrafficLight trafficLight)
        {
            _trafficLight = trafficLight;
        }

        public void Change()
        {
            Console.WriteLine("Yellow Light: Prepare to stop.");
            // Transition to the next state
            _trafficLight.SetState(new RedLightState(_trafficLight));
        }
    }


}
