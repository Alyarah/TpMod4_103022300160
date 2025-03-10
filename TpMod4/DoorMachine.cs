using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMod4
{
    class DoorMachine
    {
        public enum pintu { Terkunci, Terbuka };
        public enum Trigger { KunciPintu, bukaPintu };

        class transition
        {
            public pintu prevState;
            public pintu nextState;
            public Trigger trigger;
            public transition(pintu prevState, pintu nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }
            transition[] transitions ={
                new transition(pintu.Terkunci, pintu.Terbuka, Trigger.bukaPintu),
                new transition(pintu.Terkunci, pintu.Terkunci, Trigger.KunciPintu),
                new transition(pintu.Terbuka, pintu.Terkunci, Trigger.KunciPintu),
                new transition(pintu.Terbuka, pintu.Terbuka, Trigger.bukaPintu)
            };
            public pintu currentState;
            public pintu getNextState(pintu prevState, Trigger trigger)
            {
                pintu nextState = prevState;
                for (int i = 0; i < transitions.Length; i++)
                {
                    if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                        nextState = transitions[i].nextState;
                }
                return nextState;
            }
            public void activateTrigger(Trigger trigger)
            {
                pintu nextState = getNextState(currentState, trigger);
                currentState = nextState;
            }
    }

}
