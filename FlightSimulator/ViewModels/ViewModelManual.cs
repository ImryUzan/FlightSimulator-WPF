using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class ViewModelManual : BaseNotify
    {
        Commands client;
        private double alieron;
        private double elevator;
        public ViewModelManual()
        {
            client = ClientSingleton.Instance;
            alieron = 0;
            elevator = 0;
         }

        private double _changeRudder;
        public double ChangeRudder
        {
            get
            {
                return _changeRudder;
            }
            set
            {
                List<String> path = new List<string>();
                path.Add("rudder");
                path.Add(value.ToString("N5"));
                Console.WriteLine("im rudder");
                _changeRudder = value;
                Console.WriteLine(value);
                client.setInfo(path);
            }

        }

        private double _changeTorttel;
        public double ChangeTorttel
        {
            get
            {
                return _changeTorttel;
            }
            set
            {
                List<String> path = new List<string>();
                path.Add("throttle");
                path.Add(value.ToString("N5"));
                Console.WriteLine("im throttel");
                _changeTorttel = value;
                Console.WriteLine(value);
                client.setInfo(path);
            }
        }





       

        public double AileronP
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
                }
                else if (alieron > 1)
                {
                    alieron = 1;
                }
                string pathVal = "aileron";
                arg.Add(pathVal);
                arg.Add(alieron.ToString());
                ClientSingleton.Instance.setInfo(arg);
            }
        }
        public double ElevatorP
        {

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