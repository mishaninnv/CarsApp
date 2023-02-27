using CarsApp.DataBase.Repositories;
using CarsApp.Models;

namespace CarsApp.Infrastructure
{
    public class TestDataManager
    {
        private static BrandRepository _brandRepository = new BrandRepository();
        private static ModelRepository _modelRepository = new ModelRepository();

        public static void AddBrands()
        {
            _brandRepository.Create(new Brand() { Name = "BMW", Active = true });
            _brandRepository.Create(new Brand() { Name = "Audi", Active = false });
            _brandRepository.Create(new Brand() { Name = "Ford", Active = true });
            _brandRepository.Create(new Brand() { Name = "Honda", Active = true });
            _brandRepository.Create(new Brand() { Name = "Hyundai", Active = false });
            _brandRepository.Create(new Brand() { Name = "Kia", Active = true });
            _brandRepository.Create(new Brand() { Name = "Lada", Active = false });
            _brandRepository.Create(new Brand() { Name = "Mazda", Active = true });
        }

        public static void AddModels()
        {
            _modelRepository.Create(new Model() { Name = "BMW X1", Active = true, BrandId = 1});
            _modelRepository.Create(new Model() { Name = "BMW X2", Active = false, BrandId = 1 });
            _modelRepository.Create(new Model() { Name = "BMW X3", Active = false, BrandId = 1 });
            _modelRepository.Create(new Model() { Name = "BMW X4", Active = true, BrandId = 1 });
            _modelRepository.Create(new Model() { Name = "BMW X5", Active = true, BrandId = 1 });
            _modelRepository.Create(new Model() { Name = "BMW X6", Active = false, BrandId = 1 });
            _modelRepository.Create(new Model() { Name = "Audi S1", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S2", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi SQ2", Active = false, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi TTS", Active = false, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S3", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S4", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S5", Active = false, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi SQ5", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S6", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S7", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi SQ7", Active = true, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Audi S8", Active = false, BrandId = 2 });
            _modelRepository.Create(new Model() { Name = "Explorer", Active = true, BrandId = 3 });
            _modelRepository.Create(new Model() { Name = "Fiesta", Active = false, BrandId = 3 });
            _modelRepository.Create(new Model() { Name = "Fiesta Sedan", Active = true, BrandId = 3 });
            _modelRepository.Create(new Model() { Name = "Focus", Active = true, BrandId = 3 });
            _modelRepository.Create(new Model() { Name = "Accord", Active = false, BrandId = 4 });
            _modelRepository.Create(new Model() { Name = "Civic", Active = false, BrandId = 4 });
            _modelRepository.Create(new Model() { Name = "Crosstour", Active = true, BrandId = 4 });
            _modelRepository.Create(new Model() { Name = "CR-V", Active = true, BrandId = 4 });
            _modelRepository.Create(new Model() { Name = "Hyundai Creta", Active = false, BrandId = 5 });
            _modelRepository.Create(new Model() { Name = "Hyundai Elantra", Active = false, BrandId = 5 });
            _modelRepository.Create(new Model() { Name = "Hyundai Palisade", Active = true, BrandId = 5 });
            _modelRepository.Create(new Model() { Name = "Hyundai Santa Fe", Active = true, BrandId = 5 });
            _modelRepository.Create(new Model() { Name = "Hyundai Solaris", Active = true, BrandId = 5 });
            _modelRepository.Create(new Model() { Name = "KIA Picanto", Active = true, BrandId = 6 });
            _modelRepository.Create(new Model() { Name = "KIA Rio", Active = false, BrandId = 6 });
            _modelRepository.Create(new Model() { Name = "KIA Ceed", Active = true, BrandId = 6 });
            _modelRepository.Create(new Model() { Name = "KIA K5", Active = true, BrandId = 6 });
            _modelRepository.Create(new Model() { Name = "LADA Granta", Active = true, BrandId = 7 });
            _modelRepository.Create(new Model() { Name = "LADA Vesta", Active = true, BrandId = 7 });
            _modelRepository.Create(new Model() { Name = "LADA XRAY", Active = true, BrandId = 7 });
            _modelRepository.Create(new Model() { Name = "LADA Largus", Active = false, BrandId = 7 });
            _modelRepository.Create(new Model() { Name = "LADA Niva", Active = false, BrandId = 7 });
            _modelRepository.Create(new Model() { Name = "Mazda CX-4", Active = true, BrandId = 8 });
            _modelRepository.Create(new Model() { Name = "Mazda CX-5", Active = true, BrandId = 8 });
            _modelRepository.Create(new Model() { Name = "Mazda CX-9", Active = true, BrandId = 8 });
            _modelRepository.Create(new Model() { Name = "Mazda 6", Active = true, BrandId = 8 });
        }
    }
}
