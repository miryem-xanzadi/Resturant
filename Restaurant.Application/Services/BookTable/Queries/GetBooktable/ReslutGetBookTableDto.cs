using System.Collections.Generic;

namespace Restaurant.Application.Services.Users.Queries.GetUsers
{
    public class ReslutGetBookTableDto
    {
        public List<GetBookTableDto> BookTable { get; set; }
        public int Rows { get; set; }
    }
}
