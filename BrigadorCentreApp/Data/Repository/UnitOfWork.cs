using BrigadorCentreApp.Data.Repository.IRepository;

namespace BrigadorCentreApp.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            HireApplication = new HireApplicationRepository(_db);
        }

        public IHireApplicationRepository HireApplication { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}