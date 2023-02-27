namespace CarsApp.DataBase.Repositories
{
    public interface ICarsRepositories<T> where T : class
    {
        void Create(T obj);
        void Delete(int id);
        IEnumerable<T> GetAllModels();
        void Update(T obj);
    }
}
