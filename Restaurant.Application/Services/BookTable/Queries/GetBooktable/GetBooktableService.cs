
using Restaurant.Application.Interfaces.Contexts;
using Restaurant.Application.Services.Users.Queries.GetUsers;
using Restaurant.Common;
using System.Linq;

namespace Bugeto_Store.Application.Services.Users.Queries.GetUsers
{
    public class GetBooktableService : IGetBookTableService
    {
        private readonly IDataBaseContext _context;
        public GetBooktableService(IDataBaseContext context)
        {
            _context = context;
        }


        public ReslutGetBookTableDto Execute(RequestGetBookTableDto request)
        {
            var bookTables = _context.BookTables.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                bookTables = bookTables.Where(p => p.Email.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }
            int rowsCount = 0;
            var BookTableList = bookTables.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetBookTableDto
            { 
                Id = p.Id,
                FullName = p.FullName,
                Guests=p.Guests,
                Phone=p.Phone,
                Note=p.Note,
                TimeReserve=p.TimeReserve,  
                DateReserve = p.DateReserve,
                Email = p.Email,
                IsCancel = p.IsCancel,
                FollowId=p.FollowId

            }).ToList();

            return new ReslutGetBookTableDto
            {
                Rows = rowsCount,
                BookTable = BookTableList,
            };
        }
    }
}
