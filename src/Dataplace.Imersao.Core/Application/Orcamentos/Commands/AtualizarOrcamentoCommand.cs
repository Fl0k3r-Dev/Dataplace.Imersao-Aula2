﻿using Dataplace.Core.Domain.Commands;
using Dataplace.Imersao.Core.Application.Orcamentos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Commands
{
    public class AtualizarOrcamentoCommand : RegisterCommand<OrcamentoViewModel>
    {
        public AtualizarOrcamentoCommand(OrcamentoViewModel item) : base (item)
        {

        }
    }
}
