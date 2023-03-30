using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_The_Locked_Door
{
    internal class Door
    {
        DoorState _doorState;

        public DoorState DoorState {
            get 
            {
                return _doorState;
            }

            set {
                _doorState = value;
            }
        }

        int _passcode;

        public int Passcode {
            get
            {
                return _passcode;
            }
        }

        public Door (int passcode)
        {
            _passcode = passcode;
            _doorState = DoorState.Closed;
        }

        public String getDoorState()
        {
            return this._doorState.ToString();
        }

        public void Open()
        {
            if (DoorState == DoorState.Closed)
            {
                DoorState = DoorState.Open;
            }
        }

        public void Close()
        {
            if (DoorState == DoorState.Open)
            {
                DoorState = DoorState.Closed;
            }
        }

        public void Lock()
        {
            if (DoorState == DoorState.Closed)
            {
                DoorState = DoorState.Locked;
            }
        }

        public void Unlock()
        {
            if (DoorState == DoorState.Locked)
            {
                DoorState = DoorState.Closed;
            }
        }

        public void changePasscode()
        {
            Console.Write("Please Enter Old Passcode: ");
            int oldPasscode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (oldPasscode == Passcode)
            {
                Console.Write("Please Enter New Passcode: ");
                int newPasscode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Please Enter New Passcode Again: ");
                int newPasscodeAgain = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (newPasscode == newPasscodeAgain)
                {
                    Console.WriteLine("New Passcode Setted.\n");
                    _passcode = newPasscode;
                }
            } else
            {
                Console.WriteLine("Wrong Passcode!!!");
            }
        }

    }

    enum DoorState { Open, Closed, Locked }
}
