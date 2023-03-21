using AntaresSystemWeb.Repository.Interfaces;
using AntaresSystemWeb.Services.Interfaces;
using AntaresSystemWeb.Util;
using Domain.Models;
using Domain.ViewModel;
using FluentValidation;

namespace AntaresSystemWeb.Services.Implementations
{
    public class FuncionarioService : IFuncionarioService
    {
        public FuncionarioService(AuthenticatedUser user, IFuncionarioRepository funcionarioRepository, IValidator<FuncionarioViewModel> validator, ICargoRepository cargoRepository)
        {
            _user = user;
            _funcionarioRepository = funcionarioRepository;
            _validator = validator;
            _cargoRepository = cargoRepository; 
        }

        public readonly AuthenticatedUser _user;
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly ICargoRepository _cargoRepository;
        private IValidator<FuncionarioViewModel> _validator;

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<FuncionarioViewModel> Insert(FuncionarioViewModel model)
        {
            Random randNum = new Random();
            var startCode = randNum.Next(10, 99);

            if (model is not null)
            {
                var funcionario = new Funcionario(nome: model.Nome,
                                                  matricula: Convert.ToInt64($"{model.DataNascimento.ToString().Replace("/", "").Replace("00:00:00", "").Substring(0,4)}{startCode}"),
                                                  dataNascimento: model.DataNascimento,
                                                  cargoId: model.CargoId);

                await _funcionarioRepository.Insert(funcionario);
            }

            return null;
        }

        public async Task<List<FuncionarioViewModel>> Select()
        {
            var response = await _funcionarioRepository.Select();

            return response.Select(s => new FuncionarioViewModel
            {
                Id = s.Id,
                Nome = s.Nome,
                Matricula = s.Matricula,
                DataNascimento = s.DataNascimento,
                CargoId = s.CargoId,
                Cargo = s.Cargo.Descricao
            }).ToList();
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