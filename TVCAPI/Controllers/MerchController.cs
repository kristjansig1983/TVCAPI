using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TVCAPI.Interfaces;
using TVCAPI.Models;
using TVCAPI.Data;

namespace TVCAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class MerchController : ControllerBase
    {

        private ITVCRepository _repo;

        public MerchController(ITVCRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("merch")]
        public List<Merch> GetAllMerch()
        {
            return _repo.GetAllMerch();

        }

        [HttpGet]
        [Route("merch/{id}")]
        public ActionResult<Merch> GetMerchById(int id)
        {


            Merch? merch = _repo.GetMerchById(id);

            if (merch == null)
            {
                return NotFound();

            }

            return merch;
        }




            [HttpPost]
            [Route("merch")]
            public ActionResult<Merch> CreateMerch(Merch merch)
            {

                _repo.CreateMerch(merch);



                //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
                return CreatedAtAction(nameof(GetMerchById), new { id = merch.MerchId }, merch);
            }
        }
    }

