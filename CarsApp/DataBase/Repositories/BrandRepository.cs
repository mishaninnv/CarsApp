using CarsApp.Models;
using Dapper;
using Npgsql;
using System.Data;

namespace CarsApp.DataBase.Repositories
{
    public class BrandRepository : ICarsRepositories<Brand>
    {
        private readonly string _connectionString = "Host=localhost; Port=5432; Database=postgres; User ID=postgres; Password=password;";

        public IEnumerable<Brand> GetAllModels()
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<Brand>("SELECT * FROM Brand");
            }
        }

        public void Create(Brand model)
        {
            var brand = GetAllModels();
            if (brand.FirstOrDefault(x => x.Name.Equals(model.Name)) == null)
            {
                using (IDbConnection db = new NpgsqlConnection(_connectionString))
                {
                    var sqlQuery = $"INSERT INTO Brand (\"{nameof(Brand.Name)}\", \"{nameof(Brand.Active)}\") VALUES(@{nameof(Brand.Name)}, @{nameof(Brand.Active)})";
                    db.Query<int>(sqlQuery, model);
                }
            }
        }

        public void Update(Brand model)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sqlQuery = $"UPDATE Brand SET \"{nameof(Brand.Name)}\" = @Name, \"{nameof(Brand.Active)}\" = @Active WHERE \"{nameof(Brand.Id)}\" = @Id";
                db.Execute(sqlQuery, model);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sqlQuery = $"DELETE FROM Brand WHERE \"{nameof(Brand.Id)}\" = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
    }
}
