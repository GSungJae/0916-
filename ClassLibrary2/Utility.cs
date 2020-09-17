using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Utility
    {
        //문자열을 int 로 형변환
        public static int ConvertInt(string str)
        {
            int num;
            bool bFlag = int.TryParse(str, out num);
            if (!bFlag)
                num = 0;
            return num;

            //int num = 0;
            //bool bFlag = false;
            //while (!bFlag)
            //{
            //    bFlag = int.TryParse(Console.ReadLine(), out num);
            //}
            //    return num;
        }
        //문자열을 double로 형변환
        public static double ConvertDouble(string str)
        {
            double num;
            bool bFlag = double.TryParse(str, out num);
            if (!bFlag)
                num = 0;
            return num;
        }

    }
}
