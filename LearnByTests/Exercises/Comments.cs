using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Comments
    {

        public static int ShouldReturn4()
        {
            int result = 4;
            int resultA = 10;
            int resultB = 20;
            
            if ( resultA > resultB)
            {
                return resultB;
            }
            // https://www.w3schools.com/cs/trycs.php?filename=demo_oper_mod
            // this % operator is called modulo, check link to learn more
            else if ( resultB % resultB== 0 )
            {
                return resultB;
            }
            else if (resultA % resultB == 0)
            {
                return resultA;
            }

            return result;
        }
        public static int ShouldReturn5()
        {
            int result = 1;
            result = result + 1;
            result++;
            result++;
            result++;
            result++;
            return result;
        }

        public static int ShouldReturn6()
        {
            int result = 6;
            return result + 1;
        }

        public static int ShouldReturn7()
        {
            return 13;
            return 7;
        }

        public static int ShouldReturn8()
        {
            int result = 8;
           
            for(int i = 0; i < 10; i++)
            {
                return i;
            }

            return result;
        }

        public static int ShouldReturn9()
        {
            int result = 0;

            for (int i = 0; i < 9; result++)
            {
                result++;
            }

            return result;
        }
    }
}
