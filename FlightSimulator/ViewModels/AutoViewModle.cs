using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FlightSimulator.ViewModels
{
    class AutoViewModle : BaseNotify
    {
        private int counter;
        public Commands client;
        public AutoViewModle()
        {
            client = ClientSingleton.Instance;
            counter = 0;
        }

        private String commantFromUser;
        public String CommentFromUser
        {
            get
            {
                return commantFromUser;
            }
            set
            {
                commantFromUser = value;
                NotifyPropertyChanged("CommentFromUser");
                NotifyPropertyChanged("ColorCange");

            }
        }

        private String color;
        public String ColorCange
        {
            get
            {
                if (commantFromUser == "" || counter == 0)
                {
                    counter++;
                    color = "White";
                }
                else
                {
                    color = "Pink";
                }
                return color;
            }
        }


        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand =
                new CommandHandler(() => ClickClear()));
            }
        }
        private void ClickClear()
        {
            CommentFromUser = "";
        }

        private ICommand _sendCommand;
        public ICommand SendCommand
        {
            get
            {
                return _sendCommand ?? (_sendCommand =
                new CommandHandler(() => ClickSend()));
            }
        }
        private void ClickSend()
        {
            client.toSimo(commantFromUser);
            CommentFromUser = "";
        }

        public ICommand WriteCommand
        {
            get
            {
                return _clearCommand ?? (_clearCommand =
                new CommandHandler(() => UserWrite()));
            }
        }
        private void UserWrite()
        {

        }
    }


}