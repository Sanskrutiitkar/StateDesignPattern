using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.model
{
    internal class TrafficLight
    {
        private ITrafficLightState _currentState;

        public TrafficLight()
        {
            // Initial state
            _currentState = new GreenLightState(this);
        }

        public void Change()
        {
            _currentState.Change();
        }

        public void SetState(ITrafficLightState state)
        {
            _currentState = state;
        }
    }
}
