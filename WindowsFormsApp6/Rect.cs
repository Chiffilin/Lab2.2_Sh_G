using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    class Rect
    {
        double number;                          //сторона квадрата
        int operationCode;                      //1-диагональ 2-периметр 3-площадь
        string result;
        
       
        public double Number { get => number; set => number = value; }
        public int OperationCode { get => operationCode; set => operationCode = value; }
       public string Result { get => result; }


        public void Rectg()
        {
            switch (this.operationCode)
            {
               case 1:
                    result = (Math.Sqrt(2) *number).ToString();             //Нахождение диагонали
                  break;
               case 2:
                    result = (4 * number).ToString();                        //Нахождение периметра
                   break;
                case 3:
                    result = (Math.Pow(number, 2)).ToString();               //Нахождение площади
                   break;
                default:
                    break;
            }
            
        }
    }
}
