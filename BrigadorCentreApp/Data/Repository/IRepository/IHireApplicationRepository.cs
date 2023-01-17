using BrigadorCentreApp.Models;

namespace BrigadorCentreApp.Data.Repository.IRepository
{
    public interface IHireApplicationRepository : IRepository<HireApplication>
    {
        void Update(HireApplication obj);
    }
}