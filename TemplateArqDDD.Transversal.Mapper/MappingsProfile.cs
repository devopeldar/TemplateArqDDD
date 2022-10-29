using AutoMapper;
using TemplateArqDDD.Aplicacion.Entidad;
using TemplateArqDDD.Dominio.Entidad;

namespace TemplateArqDDD.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<PagadorDoEntidad, PagadorApEntidad>().ReverseMap();
        }
    }
}
