using CQRSProjet.Commands;
using CQRSProjet.Models;
using CQRSProjet.Repositories;
using MediatR;

namespace CQRSProjet.Handlers
{
    public class CreateStudentHandler: IRequestHandler<CreateStudentCommand, StudentDetails>
    {
        private readonly IStudentRepository _studentRepository;
        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDetails> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new StudentDetails()
            {
                StudentName = request.StudentName,
                StudentEmail = request.StudentEmail,
                StudentAddress = request.StudentAddress,
                StudentAge = request.StudentAge,
            };

            return await _studentRepository.AddStudentAsync(student);
        }
    }
}
