using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Drama : ICategory
    {
        public string Name { get; set; } = "Drama";
        public string Description { get; set; } = "Drama is a category of narrative fiction more serious than humorous in tone.";
        public decimal Budget { get; set; } =5000000;
        public int CreationYear { get; set; } = 1893;
        public DateTime CreationDate { get ; set ; }

        DateTime dateTime = new DateTime(1893, 15, 03);
        double ICategory.LikeQuantity => throw new NotImplementedException();

        public double LikeQuantity = 345889;
    }
}
