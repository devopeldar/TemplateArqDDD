using AutoMapper;
using TemplateArqDDD.Dominio.Entidad;
using TemplateArqDDD.Aplicacion.Entidad;
using TemplateArqDDD.Aplicacion.Interface;
using TemplateArqDDD.Transversal.Common;
using TemplateArqDDD.Dominio.Interface;

namespace TemplateArqDDD.Aplicacion.Core
{
    public class PagadorApCore : IPagadorApInterface
    {
        private readonly IPagadorDoInterface _pagadorpointerface;
        private readonly IMapper _mapper;

        public PagadorApCore(IPagadorDoInterface pagadorpointerface, IMapper mapper)
        {
            _pagadorpointerface = pagadorpointerface;
            _mapper = mapper;
        }

        public async Task<Response<bool>> InsertPagadorAsync(PagadorApEntidad pagadorap)
        {
            var response = new Response<bool>();
            try
            {
                var pagador = _mapper.Map<PagadorDoEntidad>(pagadorap);
                response.Data = await _pagadorpointerface.InsertPagadorAsync(pagador);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Se ingreso un nuevo pagador exitosamente";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
