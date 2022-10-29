using TemplateArqDDD.Aplicacion.Entidad;
using TemplateArqDDD.Transversal.Common;

namespace TemplateArqDDD.Aplicacion.Interface
{
    public interface IPagadorApInterface
    {
        Task<Response<bool>> InsertPagadorAsync(PagadorApEntidad pagadorapentidad);
      }
}
