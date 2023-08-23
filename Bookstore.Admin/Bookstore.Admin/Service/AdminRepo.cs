using Bookstore.Admin.Context;
using Bookstore.Admin.Entity;
using Bookstore.Admin.Interface;

namespace Bookstore.Admin.Service
{
    public class AdminRepo : IAdminRepo
    {
        private readonly AdminDBContext _dbContext;
        private readonly IConfiguration _configuration;
        public AdminRepo(AdminDBContext _dbContext, IConfiguration _configuration)
        {
            this._dbContext = _dbContext;
            this._configuration = _configuration;
        }

        public AdminEntity addAdmin(AdminEntity admin)
        {
            _dbContext.Admin.Add(admin);
            _dbContext.SaveChanges();
            return admin;
        }
    }
}
