using AntaresLibary.ViewModel;

namespace AntaresSystemWeb.Services.Interfaces
{
    public interface IFuncionarioService
    {
        Task<FuncionarioViewModel> Insert(FuncionarioViewModel model);

        Task<List<FuncionarioViewModel>> Select();

        Task<FuncionarioViewModel> Update(FuncionarioViewModel model);

        Task<FuncionarioViewModel> Select(int id);

        Task Delete(int id);
    }
}