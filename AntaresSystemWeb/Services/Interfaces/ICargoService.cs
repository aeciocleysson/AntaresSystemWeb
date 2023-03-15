using Domain.ViewModel;

namespace AntaresSystemWeb.Services.Interfaces
{
    public interface ICargoService
    {
        Task<CargoViewModel> Insert(CargoViewModel model);

        Task<List<CargoViewModel>> Select();

        Task<CargoViewModel> Update(CargoViewModel model);

        Task<CargoViewModel> Select(int id);

        Task Delete(int id);
    }
}