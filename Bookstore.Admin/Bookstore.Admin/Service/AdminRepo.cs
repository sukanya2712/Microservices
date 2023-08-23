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
            try
            {
                AdminEntity adminEntity = new AdminEntity();
                adminEntity.FirstName = admin.FirstName;
                adminEntity.LastName = admin.LastName;  
                adminEntity.Email = admin.Email;
                adminEntity.Password = admin.Password;
                adminEntity.Password = EncodePasswordToBase64(admin.Password);
                adminEntity.CreatedAt = DateTime.Now;
                adminEntity.UpdatedAt = DateTime.Now;
                _dbContext.Admin.Add(adminEntity);
                _dbContext.SaveChanges();
                return admin;

            }
            catch (Exception ex) { throw ex; }
           
        }

        public static string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
