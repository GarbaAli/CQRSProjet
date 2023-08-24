﻿using CQRSProjet.Models;
using MediatR;

namespace CQRSProjet.Queries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
