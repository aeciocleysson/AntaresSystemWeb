using AntaresSystemWeb.Repository.Interfaces;
using AntaresSystemWeb.Services.Interfaces;
using AntaresSystemWeb.Util;
using Domain.ViewModel;
using FluentValidation;

namespace AntaresSystemWeb.Services.Implementations
{
    public class FuncionarioService : IFuncionarioService
    {
        public FuncionarioService(AuthenticatedUser user, IFuncionarioRepository funcionarioRepository, IValidator<FuncionarioViewModel> validator)
        {
            _user = user;
            _funcionarioRepository = funcionarioRepository;
            _validator = validator;
        }

        public readonly AuthenticatedUser _user;
        private readonly IFuncionarioRepository _funcionarioRepository;
        private IValidator<FuncionarioViewModel> _validator;

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioViewModel> Insert(FuncionarioViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<List<FuncionarioViewModel>> Select()
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioViewModel> Select(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioViewModel> Update(FuncionarioViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}