using Bookstore.Admin.Entity;

namespace Bookstore.Admin.Interface
{
    public interface IAdminRepo
    {
        public AdminEntity addAdmin(AdminEntity admin);
    }
}