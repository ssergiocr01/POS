namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        // Declaración o matricula de interfaces a nivel de repositorio
        ICategoryRepository Category { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
