﻿using LocadoraDeVeiculos.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WinFormsApp.ModuloTaxa
{
    public partial class TelaCadastroTaxa : Form
    {
        RepositorioTaxaEmBancoDeDados repositorio = new RepositorioTaxaEmBancoDeDados();
        public TelaCadastroTaxa()
        {
            InitializeComponent();
            this.ConfigurarTela();
        }

        private Taxa taxa;

        public Func<Taxa, ValidationResult> GravarRegistro { get; set; }

        public Taxa Taxa
        {
            get { return taxa; }
            set
            {
                taxa = value;

                tbNumero.Text = taxa.Id.ToString();
                tbDescricao.Text = taxa.Descricao;

                if (taxa.Valor == 0)
                {
                    tbValor.Text = "";
                }
                else
                {
                    tbValor.Text = taxa.Valor.ToString();
                }
                cbTipoCalculo.SelectedItem = taxa.TipoCalculo;
            }
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            taxa.Descricao = tbDescricao.Text;

            if (validador.ApenasNumeros(tbValor.Text))
            {
                taxa.Valor = Convert.ToDouble(tbValor.Text);
                taxa.TipoCalculo = (string)cbTipoCalculo.SelectedItem;

                var resultadoValidacao = GravarRegistro(taxa);

                if (resultadoValidacao.IsValid == false)
                {
                    string erro = resultadoValidacao.Errors[0].ErrorMessage;

                    TelaMenuPrincipal.Instancia.AtualizarRodape(erro);

                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show("Insira um número válido no campo 'Valor'",
                "Cadastro de Taxas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DialogResult = DialogResult.None;

                return;
            }
        }

        private void TelaCadastroContatosForm_Load(object sender, EventArgs e)
        {
            TelaMenuPrincipal.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroContatosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaMenuPrincipal.Instancia.AtualizarRodape("");
        }
    }
}

