using System.Collections.Generic;
using System.Linq;
using Interface;

namespace Defination
{
    public class CourceRepository : Repository<Course>, ICourceRepository
    {
        public CourceRepository(PlutoContext context) 
            : base(context)
        {
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
