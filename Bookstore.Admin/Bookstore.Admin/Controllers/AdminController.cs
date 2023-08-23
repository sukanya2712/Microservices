using Bookstore.Admin.Entity;
using Bookstore.Admin.Interface;
using Bookstore.Admin.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminRepo adminRepo;

        public AdminController(IAdminRepo adminRepo)
        {
            this.adminRepo = adminRepo;
        }

        //[HttpPost("AddAdmin")]
        [Route("AddAdmin")]
        [HttpPost]
        public IActionResult AddAdmin(AdminEntity admin)
        {
            AdminEntity adminEntity = adminRepo.addAdmin(admin);

            if (adminEntity != null)
            {
                return Ok(new ResponseModel<AdminEntity> { Status = true, Message = "succesfully to added admin", Data = adminEntity });
            }
            return BadRequest(new ResponseModel<AdminEntity> { Status = false, Message = "unsuccesfull to add admin",Data=null });
        }

        
    }
}
