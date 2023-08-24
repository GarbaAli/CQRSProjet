using CQRSProjet.Models;
using MediatR;

namespace CQRSProjet.Commands
{
    public class CreateStudentCommand : IRequest<StudentDetails>
    {
        //Declaration des attributs
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
        public string StudentAddress { get; set; } = string.Empty;
        public int StudentAge { get; set; }

        //initialisation du constructeur
        public CreateStudentCommand(string Name, string Email, string Adress, int Age)
        {
            StudentName = Name;
            StudentEmail = Email;
            StudentAddress = Adress;
            StudentAge = Age;
        }
    }
}
