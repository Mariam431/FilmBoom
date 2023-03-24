using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Comedy : ICategory
    {
        public string Name { get; set; } = "Comedy";
        public string Description { get; set; } = "A comedy film is a category of film which emphasizes humor.";
        public decimal Budget { get; set; } = 5000000;
        public int CreationYear { get ; set ; } = 1892;
        public DateTime CreationDate { get; set; } 
        DateTime dateTime = new DateTime ( 1892, 14, 10 );


        double ICategory.LikeQuantity => throw new NotImplementedException();

        public double LikeQuantity = 276034;
    }
}
