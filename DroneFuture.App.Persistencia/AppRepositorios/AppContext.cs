using Microsoft.EntityFrameworkCore;
using DroneFuture.App.Dominio;

namespace DroneFuture.App.Persistencia 
{ 
    public class AppContext : DbContext 
{ 
    public DbSet<Persona> Personas{get;set;} 
}
}
