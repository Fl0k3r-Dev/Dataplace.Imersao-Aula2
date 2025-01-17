﻿using Dataplace.Core.Domain.Query;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Queries
{
    public class ObterOcamentoQuery : QueryRefeshItem<OrcamentoViewModel>, IQueryRefeshItem<OrcamentoViewModel>
    {
        public string CdEmpresa { get; set; }
        public string CdFilial { get; set; }
        public int NumOrcamento { get; set; }
    }
}
