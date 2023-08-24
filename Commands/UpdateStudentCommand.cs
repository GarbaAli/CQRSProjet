using CQRSProjet.Models;
using MediatR;

namespace CQRSProjet.Commands
{
    public class UpdateStudentCommand: IRequest<int>
    {
        //Declaration des attributs
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentAddress { get; set; } = string.Empty;
        public int StudentAge { get; set; }

        public UpdateStudentCommand(int id, string Name, string Email, string Adress, int Age)
        {
            Id = id;
            StudentName = Name;
            StudentEmail = Email;
            StudentAddress = Adress;
            StudentAge = Age;
        }
    }
}
