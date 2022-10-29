using TemplateArqDDD.Dominio.Entidad;

namespace TemplateArqDDD.Infraestructura.Interface
{
    public interface IPagadorInInterface
    {
        Task<bool> InsertPagadorAsync(PagadorDoEntidad pagador);
    }
}
