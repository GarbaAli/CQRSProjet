using CQRSProjet.Commands;
using CQRSProjet.Models;
using CQRSProjet.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<StudentDetails>> GetAllStudent()
        {
            var students = await _mediator.Send(new GetStudentListQuery());
            return students;
        }

        [HttpGet("{studentId}")]
        public async Task<StudentDetails> GetStudent(int studentId)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery() { Id = studentId});
            return student;
        }

        [HttpPost]
        public async Task<StudentDetails> CreateStudent(StudentDetails student)
        {
            var studentDetail = await _mediator.Send(new CreateStudentCommand(
                student.StudentName,
                student.StudentEmail,
                student.StudentAddress,
                student.StudentAge
                ));

            return studentDetail;
        }

        [HttpPut]
        public async Task<int> UpdateStudentAsync(StudentDetails studentDetails)
        {
            var isStudentDetailUpdated = await _mediator.Send(new UpdateStudentCommand(
               studentDetails.Id,
               studentDetails.StudentName,
               studentDetails.StudentEmail,
               studentDetails.StudentAddress,
               studentDetails.StudentAge));
            return isStudentDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteStudentCommand() { Id = Id });
        }
    }
}
