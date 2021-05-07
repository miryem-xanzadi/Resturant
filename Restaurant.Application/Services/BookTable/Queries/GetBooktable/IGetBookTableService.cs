using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.Services.Users.Queries.GetUsers
{
    public interface IGetBookTableService
    {
        ReslutGetBookTableDto Execute(RequestGetBookTableDto request);
    }
}
