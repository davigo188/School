using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.UnitOfWork;

namespace School.WebApi.Controllers
{

    [Route("api/StudentGrade")]
    public class StudentGradeController : BaseController
    {
        public StudentGradeController(IUnitOfWork unit) : base(unit)
        {

        }
        
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_unit.StudentGrades.GetList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_unit.StudentGrades.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] StudentGrade studentgrade)
        {
            if (ModelState.IsValid)
                return Ok(_unit.StudentGrades.Insert(studentgrade));
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put([FromBody] StudentGrade studentgrade)
        {
            if (ModelState.IsValid && _unit.StudentGrades.Update(studentgrade))
                return Ok(new { Message = "The StudentGrade is updated" });
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] StudentGrade studentgrade)
        {
            if (studentgrade.StudentID > 0)
                return Ok(_unit.StudentGrades.Delete(studentgrade));
            return BadRequest(new { Message = "Incorrect data." });
        }

    }
}