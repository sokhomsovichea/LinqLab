using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> AscendingId()
        {
            return new List<Sample>(Source.OrderBy(x => x.Id));
        }

        public List<Sample> DescendingId()
        {
            return new List<Sample>(Source.OrderByDescending(x => x.Id));
        }

        public List<Sample> AscendingPriceAndThenAscendingId()
        {
            return new List<Sample>(Source.OrderBy(x => x.Price).ThenBy(x => x.Id));
        }
    }
}
