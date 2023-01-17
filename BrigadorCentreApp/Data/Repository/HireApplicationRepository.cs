using BrigadorCentreApp.Data.Repository.IRepository;
using BrigadorCentreApp.Models;


namespace BrigadorCentreApp.Data.Repository
{
    internal class HireApplicationRepository : Repository<HireApplication>, IHireApplicationRepository
    {
        private readonly ApplicationDbContext _db;
        public HireApplicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(HireApplication obj)
        {
            _db.HireApplicationModel.Update(obj);
        }
    }
}