using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._Events
{
    public delegate void PressKeyEventHandler();
    internal class Keyboard
    {
        public event PressKeyEventHandler PressKeyA = null;
        public event PressKeyEventHandler PressKeyE = null;
        public void PressKeyAEvent()
        {
            if(PressKeyA != null)
            {
                PressKeyA.Invoke();
            }
        }

        public void PressKeyEEvent()
        {
            if(PressKeyE != null)
            {
                PressKeyE.Invoke();
            }
        }

        public void Start()
        {
            Console.CursorVisible = false;
            while(true)
            {
                string s = Console.ReadLine();
                Console.Clear();
                switch(s)
                {
                    case "a":
                    case "A":
                        PressKeyAEvent(); break;
                    case "e":
                    case "E":
                        PressKeyEEvent(); break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine($"Event handler not selected! {s}");
                        break;
                }
            }
            Console.WriteLine("Exit!");
        }
    }
}
