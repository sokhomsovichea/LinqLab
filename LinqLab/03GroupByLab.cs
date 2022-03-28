using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{

    public class GroupByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public GroupByLab()
        {
            Source = new SampleDate().GetData();
        }
        public IList<IGrouping<string, Sample>> GroupByUserName()
        {
            return new List<IGrouping<string, Sample>>(Source.GroupBy(x => x.UserName));
        }

        public IEnumerable<IGrouping<TempObj, Sample>> GroupByUserNameAndCreateTime()
        {
            return new List<IGrouping<TempObj, Sample>>(Source.GroupBy(x => new TempObj { UserName = x.UserName, CreateTime = x.CreateTime }));
        }
    }
}
