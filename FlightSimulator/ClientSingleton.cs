using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class ClientSingleton
    {
        #region Singleton
        private static Commands m_Instance = null;
        public static Commands Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Commands();
                }
                return m_Instance;
            }
        }
        #endregion
    }
}
