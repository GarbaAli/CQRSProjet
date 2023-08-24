using CQRSProjet.Models;
using MediatR;

namespace CQRSProjet.Queries
{
    //Obtenir la liste des Etudiants
    public class GetStudentListQuery : IRequest<List<StudentDetails>> { }
}
