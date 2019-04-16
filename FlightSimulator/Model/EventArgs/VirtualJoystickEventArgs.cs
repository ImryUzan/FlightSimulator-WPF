using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model.EventArgs
{
    public class VirtualJoystickEventArgs
    {
        private double alieron;
        private double elevator;

        public VirtualJoystickEventArgs()
        {
            alieron = 0;
            elevator = 0;
        }
        public double Aileron
        {
            get
            {
                return alieron;
            }
            set
            {
                List<string> arg = new List<string>();
                alieron = value;
               if (alieron < -1)
               {
                    alieron = -1;
                }else if (alieron > 1)
                {
                    alieron = 1;
                }
                string pathVal = "aileron";
                arg.Add(pathVal);
                arg.Add(alieron.ToString());
                ClientSingleton.Instance.setInfo(arg);
            }
        }
        public double Elevator {
            
                get
                {
                    return elevator;
                }
                set
                {
                    List<string> arg = new List<string>();
                     elevator = value;
                    if (elevator < -1)
                    {
                    elevator = -1;
                    }
                    else if (elevator > 1)
                    {
                        elevator = 1;
                    }
                    string pathVal = "elevator";
                    arg.Add(pathVal);
                    arg.Add(elevator.ToString());
                    ClientSingleton.Instance.setInfo(arg);
                }
            }
        }
    }

