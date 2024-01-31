using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public interface IService
    {
        IEnumerable<CatalogModel> FillTable();
        CarViewModel ShowCar(int CarId);
        void DeleteCar(int CarId);
        RoleModel Login(RoleModel model);
        bool AddCar(CarModel model);
        IEnumerable<SellModel> GetReportData();
        void SellProcess(string FIO, string Phone, int CarId);
    }
}
