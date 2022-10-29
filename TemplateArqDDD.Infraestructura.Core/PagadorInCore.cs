using Dapper;
using TemplateArqDDD.Dominio.Entidad;
//using TemplateArqDDD.Infraestructura.Entidad;
using TemplateArqDDD.Infraestructura.Interface;
using TemplateArqDDD.Transversal.Common;

namespace TemplateArqDDD.Infraestructura.Core /// es Repository
{
    public class PagadorInCore : IPagadorInInterface
    {
        private readonly IConnectionFactory _connectionFactory;
        public PagadorInCore(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task<bool> InsertPagadorAsync(PagadorDoEntidad pagador)
        {
            try
            {
                using (var conn = _connectionFactory.GetConnection)
                {
                    var sql = "USE mediqa; INSERT INTO pagador(Nombre, Observaciones) VALUES('" + pagador.Nombre.ToString() + "', '" + pagador.Observaciones.ToString() + "');";
                    var rdo = await conn.ExecuteAsync(sql);
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return true;
        }
    }
}
