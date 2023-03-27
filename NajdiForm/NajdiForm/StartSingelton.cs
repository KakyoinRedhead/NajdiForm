using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiForm
{
    internal class StartSingelton
    {
        static Rectangle Bounds = Screen.PrimaryScreen.Bounds;
        private static StartSingelton _instance;
        public static StartSingelton Instance
        {
            get 
            {

                if (_instance == null)
                    _instance = new StartSingelton();
                return _instance;
            }       
        }

        public Action OnWon;
        public Action OnLose;
        internal void Lost()
        {
            
        }

    }    
}

