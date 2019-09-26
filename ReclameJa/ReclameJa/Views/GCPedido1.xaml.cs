using GCPedido.Services.DataService;
using GCPedido.Services.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReclameJa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GCPedido1 : ContentPage
    {
        public GCPedido1()
        {
            InitializeComponent();
        }

        private void btnAdicionarCarrinho_Clicked(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido()
            {
                Cliente = new Cliente()
                {
                    IdCliente = 0,
                    Nome = "Glauber Marcelino da Silva",
                    CPF = "7918151520",
                    DataCadastro = DateTime.Now,
                    Finalizado = false,
                    Telefone = "79 99650-5521"
                },
                TipoPagamento = 0,
                Finalizado = false,
                DataPedido = DateTime.Now
            };
            List<ItemPedido> itens = new List<ItemPedido>()
            {
                new ItemPedido
                {
                    Produto = new Models.Produto(){},
                    Qtd =5,
                    Desconto =0,
                    Valor =10,
                    Cancelado =0
                }
            };

            RestClient client = new RestClient();
            client.Post<Pedido>(pedido);
        }
    }
}