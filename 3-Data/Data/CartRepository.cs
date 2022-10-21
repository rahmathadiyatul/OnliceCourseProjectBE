using SoupLocal._3_Data.Data.Interface;

namespace SoupLocal._3_Data.Data
{
    public class CartRepository : ICartRepository
    {
        public string CreateCartDB()
        {
            var result = "INSERT INTO dbo.cart " +
                            "(userId, courseId, schedule) values " +
                            "(@UserId, @CourseId, @Schedule)";
            return result;
        }
    }
}
