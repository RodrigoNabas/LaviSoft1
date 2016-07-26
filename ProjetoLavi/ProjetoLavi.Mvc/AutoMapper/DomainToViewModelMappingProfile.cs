using AutoMapper;
using ProjetoLavi.Dominio.Entities.Cliente;
using ProjetoLavi.Dominio.Entities.Fornecedor;
using ProjetoLavi.Dominio.Entities.Maquinas;
using ProjetoLavi.Dominio.ValueObjects;
using ProjetoLavi.Mvc.ViewModels;

namespace ProjetoLavi.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Fornecedor, FornecedorModel>();
            CreateMap<Maquina, MaquinaModel>();

            CreateMap<Cliente, ClienteModel>()
                .ForMember(dest => dest.Email, orig => orig.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cnpj, orig => orig.MapFrom(src => src.Cnpj));

            CreateMap<Cnpj, ViewModels.ValueObjects.Cnpj>();
            CreateMap<Email, ViewModels.ValueObjects.Email>();


        }
    }
}