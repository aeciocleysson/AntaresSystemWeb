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
        
        public async Task Delete(int id)
        {
            if (id != 0)
            {
                var funcionario = await _funcionarioRepository.Select(id);
                funcionario.UserAlteration = _user.Id.ToString();
                await _funcionarioRepository.Delete(funcionario);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public async Task<FuncionarioViewModel> Insert(FuncionarioViewModel model)
        {
            Random randNum = new Random();
            var startCode = randNum.Next(10, 99);

            var valid = _validator.Validate(model);
            var cargo = await _cargoRepository.Select();
            if (valid.IsValid)
            {
                var funcionario = new Funcionario(nome: model.Nome,
                                                  matricula: $"{model.DataNascimento.ToString().Replace("/", "").Replace("00:00:00", "").Substring(0, 4)}{startCode}",
                                                  dataNascimento: model.DataNascimento,
                                                  cargoId: model.CargoId,
                                                  userInserted: _user.Id.ToString());


                var response = await _funcionarioRepository.Insert(funcionario);

                if (response is not null)
                {
                    var result = new FuncionarioViewModel
                    {
                        Id = response.Id,
                        Nome = response.Nome,
                        DataNascimento = response.DataNascimento,
                        Matricula = response.Matricula,
                        CargoId = response.CargoId,
                        Cargo = cargo.Where(w => w.Id == response.CargoId).Select(x => x.Descricao).FirstOrDefault()
                    };

                    return result;
                }
                else
                    return null;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public async Task<List<FuncionarioViewModel>> Select()
        {
            var response = await _funcionarioRepository.Select();
            var cargo = await _cargoRepository.Select();

            return response.Select(s => new FuncionarioViewModel
            {
                Id = s.Id,
                Nome = s.Nome,
                Matricula = s.Matricula,
                DataNascimento = s.DataNascimento,
                CargoId = s.CargoId,
                Cargo = cargo.Where(w => w.Id == s.CargoId).Select(x => x.Descricao).FirstOrDefault()
            }).ToList();
        }

        public async Task<FuncionarioViewModel> Select(int id)
        {
            var response = await _funcionarioRepository.Select(id);

            var result = new FuncionarioViewModel
            {
                Id = response.Id,
                Nome = response.Nome,
                Matricula = response.Matricula,
                DataNascimento = response.DataNascimento,
                CargoId = response.CargoId
            };

            return result;
        }

        public async Task<FuncionarioViewModel> Update(FuncionarioViewModel model)
        {
            var valid = _validator.Validate(model);
            var cargo = await _cargoRepository.Select();
            if (valid.IsValid)
            {
                var funcionario = await _funcionarioRepository.Select(model.Id);

                funcionario.Update(id: model.Id,
                                   nome: model.Nome,
                                   dataNascimento: model.DataNascimento,
                                   cargoId: model.CargoId,
                                   userAlteration: _user.Id.ToString());

                var response = await _funcionarioRepository.Update(funcionario);

                if (response is not null)
                {
                    var result = new FuncionarioViewModel
                    {
                        Id = response.Id,
                        Nome = response.Nome,
                        DataNascimento = response.DataNascimento,
                        Matricula = response.Matricula,
                        CargoId = response.CargoId,
                        Cargo = cargo.Where(w => w.Id == response.CargoId).Select(x => x.Descricao).FirstOrDefault()
                    };

                    return result;
                }
                else
                    return null;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}