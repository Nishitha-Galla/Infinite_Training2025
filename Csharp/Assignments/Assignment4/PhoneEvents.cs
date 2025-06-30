using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public delegate void RingEventHandler();

    class MobilePhone
    {
        public event RingEventHandler OnRing;

        public void ReceiveCall()
        {
            Console.WriteLine("Incoming call..");
            if (OnRing != null)
                OnRing();
        }
    }
    class RingTonePlayer
    {
        public void PlayRingtone()
        {
            Console.WriteLine("Playing ringtone..");
        }
    }
    
    class ScreenDisplay
    {
        public void ShowCallerInfo()
        {
            Console.WriteLine("Displaying caller info..");
        }
    }

    class VibrationMotor
    {
        public void Vibrate()
        {
            Console.WriteLine("Phone is vibrating..");
        }
    }
    
    
    class PhoneEvents
    {
        static void Main()
        {
            MobilePhone phone = new MobilePhone();

            RingTonePlayer ringTone = new RingTonePlayer();
            ScreenDisplay screen = new ScreenDisplay();
            VibrationMotor vibration = new VibrationMotor();

            phone.OnRing += ringTone.PlayRingtone;
            phone.OnRing += screen.ShowCallerInfo;
            phone.OnRing += vibration.Vibrate;

            phone.ReceiveCall();

            Console.ReadLine();

        }
    }
}
