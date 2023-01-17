namespace BrigadorCentreApp.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IHireApplicationRepository HireApplication { get; }
        void Save();
    }

}