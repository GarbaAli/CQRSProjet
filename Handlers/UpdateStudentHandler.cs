using CQRSProjet.Commands;
using CQRSProjet.Repositories;
using MediatR;

namespace CQRSProjet.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;
        public UpdateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByIdAsync(request.Id);
            if (student == null) { return default; }

            student.StudentName = request.StudentName;
            student.StudentEmail = request.StudentEmail;
            student.StudentAddress = request.StudentAddress;
            student.StudentAge = request.StudentAge;

            return await _studentRepository.UpdateStudentAsync(student);
        }
    }
}
