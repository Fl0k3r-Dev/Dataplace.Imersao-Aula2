﻿using Dataplace.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    public class OrcamentoReabertoEvent : Event
    {
        public OrcamentoReabertoEvent(int numOrcamento)
        {
            NumOrcamento = numOrcamento;
        }
        public int NumOrcamento { get; set; }
    }
}
