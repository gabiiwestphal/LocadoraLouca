using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.Compartilhado.ModuloTaxa
{
    public class ConfiguracaoToolboxTaxa : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Taxas";

        public override string TooltipInserir { get { return "Inserir uma nova taxa"; } }

        public override string TooltipEditar { get { return "Editar uma taxa"; } }

        public override string TooltipExcluir { get { return "Excluir uma taxa"; } }

    }
}
