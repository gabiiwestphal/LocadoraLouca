using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloGrupoDeVeiculo
{
    public class ConfiguracaoToolboxGrupoDeVeiculo : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Grupo de Veículos";

        public override string TooltipInserir { get { return "Inserir um grupo de veículos."; } }

        public override string TooltipEditar { get { return "Editar um grupo de veículos."; } }

        public override string TooltipExcluir { get { return "Excluir um grupo de veículos."; } }
    }
}
