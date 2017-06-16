using MiniBlog2.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MiniBlog2.Infrastructure.Repositories
{

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleUserByUsernamePassword(string userName, string password);
        User GetSingleUserByUserName(string userName);
    }
}
