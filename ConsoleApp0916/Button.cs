using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916
{
    class Button
    {
        int click = 0;
        static int buttonCnt = 0;
        static Button btn;

        public void Click()
        {
            click++;
            Console.WriteLine(click);
        }
        private  Button()
        {

        }
        public static Button CreateInstanceBinder() // 인스턴스 없이 호출해야해서 static 을 넣어서 호출함
        {
            if (btn == null)                // btn은 1개이상 만들어지지않음.
                btn = new Button();
            return btn;
        }
    }
    class ClickCount
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine(args[0] + " /" + args[1]);

            }

            Button btn1 = Button.CreateInstanceBinder();
            btn1.Click();
            btn1.Click();
            btn1.Click();
            
            Button btn2 = Button.CreateInstanceBinder();
            btn2.Click();
            btn2.Click();
            btn2.Click();
            
        }
    }
}
