using AutoMapper;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.ValueObjects;
using ProjetoLavi.Mvc.ViewModels;

namespace ProjetoLavi.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public ViewModelToDomainMappingProfile()
        {

            CreateMap<FornecedorModel, Fornecedor>();

            CreateMap<ClienteModel, Cliente>()
                .ForMember(dest => dest.Email, orig => orig.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cnpj, orig => orig.MapFrom(src => src.Cnpj));

            CreateMap<ViewModels.ValueObjects.Cnpj,Cnpj>();
            CreateMap<ViewModels.ValueObjects.Email,Email>();

            CreateMap<MaquinaModel, Maquina>();
        }
    }
}