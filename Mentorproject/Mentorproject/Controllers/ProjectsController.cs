using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mentorproject.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mentorproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get(bool includeBfgs = false, bool showDeleted = false)
        {
            try
            {
                var repo = _unitOfWork.GetRepository<Project>();
                var result = await repo.GetPagedListAsync();
                var projects = result?.Items;
                if (projects != null && projects.Count > 0)
                {
                    return Ok(projects);
                }
                return Json(new List<Project>());
            }
            catch (Exception e)
            {
                //mLogHelper.WriteLog(LogEventLevel.Error, e, e.Message, new LogHeader("ProjectsController", HttpMethods.Get));
                return StatusCode(500, e.Message);
            }
        }
    }
}