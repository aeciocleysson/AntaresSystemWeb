using AntaresLibary.Models;
using AntaresLibary.ViewModel;
using AntaresSystemWeb.Repository.Interfaces;
using AntaresSystemWeb.Services.Interfaces;
using AntaresSystemWeb.Util;
using FluentValidation;

namespace AntaresSystemWeb.Services.Implementations
{
    public class CargoService : ICargoService
    {
        public CargoService(ICargoRepository cargoRepository, AuthenticatedUser user, IValidator<CargoViewModel> validator)
        {
            _cargoRepository = cargoRepository;
            _user = user;
            _validator = validator;
        }

        public readonly AuthenticatedUser _user;
        private readonly ICargoRepository _cargoRepository;
        private IValidator<CargoViewModel> _validator;

        public async Task<CargoViewModel> Insert(CargoViewModel model)
        {
            var valid = _validator.Validate(model);

            if (valid.IsValid)
            {
                if (model == null)
                    throw new ArgumentNullException();

                var cargo = new Cargo(descricao: model.Descricao);
                cargo.UserInserted = model.UserInserted = _user.Id.ToString();

                var response = await _cargoRepository.Insert(cargo);

                if (response is not null)
                {
                    var result = new CargoViewModel
                    {
                        Id = response.Id,
                        Descricao = response.Descricao
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

        public async Task<List<CargoViewModel>> Select()
        {
            var response = await _cargoRepository.Select();

            return response.Select(s => new CargoViewModel
            {
                Id = s.Id,
                Descricao = s.Descricao
            }).ToList();
        }

        public async Task<CargoViewModel> Update(CargoViewModel model)
        {
            var valid = _validator.Validate(model);

            if (valid.IsValid)
            {
                var cargo = await _cargoRepository.Select(model.Id);

                cargo.Update(id: cargo.Id, descricao: model.Descricao);
                cargo.UserAlteration = cargo.UserInserted = model.UserInserted = _user.Id.ToString();

                var response = await _cargoRepository.Update(cargo);

                if (response is not null)
                {
                    var result = new CargoViewModel
                    {
                        Id = response.Id,
                        Descricao = response.Descricao
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

        public async Task<CargoViewModel> Select(int id)
        {
            var response = await _cargoRepository.Select(id);

            var result = new CargoViewModel
            {
                Id = response.Id,
                Descricao = response.Descricao
            };

            return result;
        }

        public async Task Delete(int id)
        {
            if (id != 0)
            {
                var cargo = await _cargoRepository.Select(id);
                cargo.UserAlteration = _user.Id.ToString();
                await _cargoRepository.Delete(cargo);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}