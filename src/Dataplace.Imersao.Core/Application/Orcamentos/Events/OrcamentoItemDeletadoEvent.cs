using Dataplace.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataplace.Imersao.Core.Application.Orcamentos.Events
{
    public class OrcamentoItemDeletadoEvent : Event
    {
        public OrcamentoItemDeletadoEvent(int numOrcamento, int seqItem)
        {
            NumOrcamento = numOrcamento;
            SeqItem = seqItem;
        }

        public int NumOrcamento {get; set;}
        public int SeqItem {get; set;}
    }
}
