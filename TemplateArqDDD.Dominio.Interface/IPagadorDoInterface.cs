using TemplateArqDDD.Dominio.Entidad;

namespace TemplateArqDDD.Dominio.Interface
{
    public interface IPagadorDoInterface
    {
        Task<bool> InsertPagadorAsync(PagadorDoEntidad pagador);
        //Task<bool> UpdateAsync(PagadorDoEntidad pagador);
        //Task<bool> DeleteAsync(int idpagador);
        //Task<PagadorDoEntidad> GetAsync(int idpagador);
        //Task<IEnumerable<PagadorDoEntidad>> GetAllAsync();
    }
}
