using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal class Horror : ICategory
    {
        public string Name { get; set; } = "Horror";
        public string Description { get; set; } = "Horror is a film that elicit fear or disgust in its audience for entertainment purposes.";
        public decimal Budget { get; set; } = 20000000;
        public int CreationYear { get; set; } = 1912;
        public DateTime CreationDate { get; set; }

        DateTime dateTime = new DateTime(1912, 9, 27);
        double ICategory.LikeQuantity => throw new NotImplementedException();

        public double LikeQuantity = 100650;
    }
}
