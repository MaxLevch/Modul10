using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Calculator : ISum
    {
        public void calculSum()
        {
            Logger log = new Logger();
            try
            {
                Console.WriteLine("Введите 1 слагаемое");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите 2 слагаемое");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                log.Event(sum);
                
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            
        }
    }
}
