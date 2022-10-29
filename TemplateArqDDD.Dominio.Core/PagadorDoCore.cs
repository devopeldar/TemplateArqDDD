using TemplateArqDDD.Dominio.Entidad;
using TemplateArqDDD.Dominio.Interface;
using TemplateArqDDD.Infraestructura.Interface;

namespace TemplateArqDDD.Dominio.Core
{
    public class PagadorDoCore : IPagadorDoInterface
    {
        private readonly IPagadorInInterface _pagadorinfraestructura;

        public PagadorDoCore(IPagadorInInterface pagadorinfraestructura)
        {
            _pagadorinfraestructura = pagadorinfraestructura;
        }
        public async Task<bool> InsertPagadorAsync(PagadorDoEntidad pagador)
        {
            return await _pagadorinfraestructura.InsertPagadorAsync(pagador);
        }
    }
}
