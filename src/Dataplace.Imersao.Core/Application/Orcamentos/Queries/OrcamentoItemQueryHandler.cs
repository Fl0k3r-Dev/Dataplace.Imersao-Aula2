using Dapper;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using dpLibrary05;
using MediatR;
using System.Data.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Queries
{
    public class OrcamentoItemQueryHandler :
        IRequestHandler<ObterOrcamentoItemQuery, OrcamentoItemViewModel>
    {

        #region fields
        private readonly IDataAccess _dataAccess;
        private readonly Domain.Orcamentos.Repositories.IOrcamentoItemRepository _orcamentoItemRepository;
        #endregion

        #region contructors
        public OrcamentoItemQueryHandler(Domain.Orcamentos.Repositories.IOrcamentoItemRepository orcamentoItemRepository, IDataAccess dataAccess)
        {
            _orcamentoItemRepository = orcamentoItemRepository;
            _dataAccess = dataAccess;
        }
        #endregion

        public async Task<OrcamentoItemViewModel> Handle(ObterOrcamentoItemQuery query, CancellationToken cancellationToken)
        {
            var sql = $@"
            SET TRANSACTION ISOLATION LEVEL SNAPSHOT;
            SELECT
                  CdEmpresa
                , CdFilial
                , NumOrcamento
                , Seq
                , TpRegistro
                , CdProduto 
                , dsitemnocliente
                , qtdproduto
                , PercAltPreco
                , vlvenda
                , ValorCustoR
                , stitem
            FROM OrcamentoItem
            ";
            var builder = new SqlBuilder();
            var selector = builder.AddTemplate(sql);

            builder.Where("orcamentoItem.NumOrcamento = @NumOrcamento", new { query.NumOrcamento });
            builder.Where("orcamentoItem.Seq = @SeqItem", new { query.SeqItem });
            builder.Where("orcamentoItem.CdEmpresa = @CdEmpresa", new { query.CdEmpresa });
            builder.Where("orcamentoItem.CdFilial = @CdFilial", new { query.CdFilial });

            var cmd = new CommandDefinition(selector.RawSql, selector.Parameters, flags: CommandFlags.NoCache);
            return _dataAccess.Connection.QueryFirstOrDefault<OrcamentoItemViewModel>(cmd);
        }

    }

}
