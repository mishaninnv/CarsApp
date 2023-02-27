using CarsApp.Models;
using Dapper;
using Npgsql;
using System.Data;

namespace CarsApp.DataBase.Repositories
{
    public class ModelRepository : ICarsRepositories<Model>
    {
        private readonly string _connectionString = "Host=localhost; Port=5432; Database=postgres; User ID=postgres; Password=password;";

        public IEnumerable<Model> GetAllModels()
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<Model>("SELECT * FROM Model");
            }
        }

        public void Create(Model model)
        {
            var carModel = GetAllModels();
            if (carModel.FirstOrDefault(x => x.Name.Equals(model.Name)) == null)
            {
                using (IDbConnection db = new NpgsqlConnection(_connectionString))
                {
                    var sqlQuery = $"INSERT INTO Model (\"{nameof(Model.Name)}\", \"{nameof(Model.Active)}\", \"{nameof(Model.BrandId)}\") " +
                                   $"VALUES(@{nameof(Model.Name)}, @{nameof(Model.Active)}, @{nameof(Model.BrandId)})";
                    db.Query<int>(sqlQuery, model);
                }
            }
        }

        public void Update(Model model)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sqlQuery = $"UPDATE Model SET \"{nameof(Model.Name)}\" = @{nameof(Model.Name)}, \"{nameof(Model.Active)}\" = @{nameof(Model.Active)}, \"{nameof(Model.BrandId)}\" = @{nameof(Model.BrandId)} " +
                               $"WHERE \"{nameof(Model.Id)}\" = @Id";
                db.Execute(sqlQuery, model);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                var sqlQuery = $"DELETE FROM Model WHERE \"{nameof(Model.Id)}\" = @id";
                db.Execute(sqlQuery, new { id });
            }
        }

        public IEnumerable<BrandModels> GetModelsGroupedByBrands()
        {
            using (IDbConnection db = new NpgsqlConnection(_connectionString))
            {
                return db.Query<BrandModels>($"select \"brand\".\"Name\" as \"BrandName\", \"model\".\"Name\" as \"ModelName\" " +
                                       $"from model " +
                                       $"join brand on \"BrandId\" = \"brand\".\"Id\" " +
                                       $"Order by \"brand\".\"Name\", \"model\".\"Name\"");
            }
        }
    }
}
