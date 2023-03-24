using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class PaidMovies
    {
        public int Amount = 0;
        
        enum Quality { low=5, medium=10, high=15};        
        public decimal Payment()
        {
            Console.WriteLine($"Choose quality level: (high: 15$, medium: 10$, low: 5$): ");
            string quality = Convert.ToString(Console.ReadLine());
            

            switch (Amount)
            {
                case = 15:
                    Quality.high.ToString() == quality;
                    return 0;
                    break;
                case = 10:
                    Quality.medium.ToString() == quality;
                    return 0;
                    break;
                case = 5:
                    Quality.low.ToString() == quality;
                    return 0;
                    break;
                default:
                    return 0;
                    break;


            }


            return 0;     

        }
    }
}
