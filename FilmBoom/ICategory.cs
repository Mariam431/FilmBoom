using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal interface ICategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public int CreationYear { get; set; }   
        public DateTime CreationDate { get; set; }
        public double LikeQuantity { get; } //?
        public double Likes(double LikeQuantity) //?
        {
            Console.WriteLine("Do you like this cadegory? (yes / no): ");
            string answer = Convert.ToString(Console.ReadLine);
            if(answer == "yes")
            {
                LikeQuantity += 1;
                return LikeQuantity; 
            }
            else
            {
                return LikeQuantity;
            }

        }



    }
}
