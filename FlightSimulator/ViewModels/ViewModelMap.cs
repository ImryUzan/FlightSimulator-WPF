using FlightSimulator.Model;
using FlightSimulator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlightSimulator.ViewModels
{
    class ViewModelMap
    {
        private Commands client;
        SettingsWindow setting;
        public ViewModelMap()
        {
            
            client = ClientSingleton.Instance;
        }

        private ICommand _connectCommand;
        public ICommand ConnectCommand
        {
            get
            {
                return _connectCommand ?? (_connectCommand =
                new CommandHandler(() => ConnectFunc()));
            }
        }
        private void ConnectFunc()
        {
            if(ClientSingleton.Instance.connectedVal == false)
            {
                client.connectClient();
            }
            else
            {
                return;
            }
        }


        private ICommand _openWindow;
        public ICommand OpenWindow
        {
            get
            {
                return _openWindow ?? (_openWindow =
                new CommandHandler(() => WindowShow()));
            }
        }
        private void WindowShow()
        {
            setting = new SettingsWindow();
            setting.Show();
        }



        private ICommand _paintCommand;
        public ICommand PaintComman
        {
            get
            {
                return _paintCommand ?? (_paintCommand =
                new CommandHandler(() => PaintctFunc()));
            }
        }
        private void PaintctFunc()
        {
            
        }

        private ICommand _disconnectCommand;
        public ICommand DisconnectCommand
        {
            get
            {
                return _disconnectCommand ?? (_disconnectCommand =
                new CommandHandler(() => DisconnectFunc()));
            }
        }
        private void DisconnectFunc()
        {
            if (ClientSingleton.Instance.connectedVal == true)
            {
                client.disconnectClient();
                ClientSingleton.Instance.connectedVal = false;
            }
            else
            {
                return;
            }
        }

    }
}