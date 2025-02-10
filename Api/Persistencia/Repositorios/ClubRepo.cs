using Api.Core.Entidades;
using Api.Core.Repositorios;
using Api.Persistencia._Config;
using Microsoft.EntityFrameworkCore;

namespace Api.Persistencia.Repositorios;

public class ClubRepo : RepositorioABM<Club>, IClubRepo
{
    public ClubRepo(AppDbContext context) : base(context)
    {
    }
}