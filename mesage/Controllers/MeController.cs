//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//namespace mesage.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MeController : ControllerBase
//    {
//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {

//            var list = await _context.People.Join(_context.Contacts, contacts => contacts.Id, Peoples => Peoples.Id,
//              (Peoples, Contacts) => new
//              {

//                  id = Peoples.Id,
//                  name = Peoples.Name,
//                  cid = Contacts.Id,
//                  local = Contacts.Location,
//                  phone = Contacts.Phone
//              }

//              ).GroupBy(p => p.id).Select(m => new
//              {
//                  m.Key,
//                  id = m.Count(),
//                  name = m.Select(t => t.name),
//                  phone = m.Select(t => t.phone),
//                  local = m.OrderBy(p => p.local)

//              }).ToListAsync();

            


           

//            return Ok();
//        }
//    }
//}
