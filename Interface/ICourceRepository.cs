using System.Collections.Generic;

namespace Interface
{
    public interface ICourceRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
    }
}
