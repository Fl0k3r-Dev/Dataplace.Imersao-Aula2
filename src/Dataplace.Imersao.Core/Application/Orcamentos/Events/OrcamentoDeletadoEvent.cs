﻿using Dataplace.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    public class OrcamentoDeletadoEvent : Event
    {
        public OrcamentoDeletadoEvent(int numOcamento)
        {
            NumOcamento = numOcamento;
        }
        public int NumOcamento { get; set; }
    }
}
