using CQRSProjet.Commands;
using CQRSProjet.Repositories;
using MediatR;

namespace CQRSProjet.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
    {
        private readonly IStudentRepository _studentRepository;
        public DeleteStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentRepository.GetStudentByIdAsync(request.Id);
            if (student == null) { return 0; }

            return await _studentRepository.DeleteStudentAsync(student.Id);
        }
    }
}
