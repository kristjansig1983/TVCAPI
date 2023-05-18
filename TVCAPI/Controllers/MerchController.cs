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


            try
            {


                Merch? merch = _repo.GetMerchById(id);

                if (merch == null)
                {
                    return NotFound();

                }

                

                return merch;
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpDelete]
        [Route("merch/{id}")]
        public ActionResult<Merch> DeleteMerchById(int id)
        {

            try
            {


                Merch? merch = _repo.GetMerchById(id);

                if (merch == null)
                {
                    return NotFound();

                }
                bool success = _repo.DeleteMerch(merch);

                if (!success)
                {
                    return StatusCode(500);
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }


        }




        [HttpPost]
            [Route("merch")]
            public ActionResult<Merch> CreateMerch(Merch merch)
            {

            try
            {


                _repo.CreateMerch (merch);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }



            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetMerchById), new { id = merch.MerchId }, merch);
        }

        [HttpPut]
        [Route("merch/{id}")]
        public IActionResult UpdateMerch(int id, Merch merchFromBody)
        {
            if (id != merchFromBody.MerchId)
            {
                return BadRequest();
            }





            try
            {

                Merch? updated = _repo.UpdateMerch(id, merchFromBody);
                if (updated == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }


        }
    }
    }

