using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinFormsApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public virtual void Editar() { }
        public abstract void Excluir();
        public abstract UserControl ObtemListagem();
        public virtual void Duplicar() { }
        public virtual void Filtrar() { }
        public virtual void GerarPdf() { }
        public virtual void Visualizar() { }
        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();
    }
}
