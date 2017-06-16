using MiniBlog2.Entities;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MiniBlog2.Infrastructure.Repositories
{
    /// <summary>
    /// Concrete realization of access to Users
    /// </summary>
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(SimpleBlogContext context) : base(context)
        {

        }

        public User GetSingleUserByUserName(string userName)
        {
            return (from p in _context.Users where p.UserName == userName && p.IsActive == true select p).FirstOrDefault();
        }

        public User GetSingleUserByUsernamePassword(string userName, string password)
        {
            return (from p in _context.Users where p.UserName == userName && p.Password == password && p.IsActive == true select p).FirstOrDefault();
        }
    }
}
