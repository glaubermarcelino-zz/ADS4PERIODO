using MvvmHelpers;
using ReclameJa.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReclameJa.ViewModels
{
    public class AcompanhamentoViewModel :BaseViewModel
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText, value); }
        }

        private ICommand _searchTextCommand;

        public ICommand SearchTextCommand
        {
            get { return _searchTextCommand; }
            set { SetProperty(ref _searchTextCommand, value); }
        }


        private ObservableCollection<DashBoard> _itens;


        public ObservableCollection<DashBoard> Itens
        {
            get { return _itens; }
            set { SetProperty(ref _itens, value); }
        }

        private ObservableCollection<Solicitacao> _solicitacao;
        public ObservableCollection<Solicitacao> Solicitacao
        {
            get { return _solicitacao; }
            set { SetProperty(ref _solicitacao, value); }
        }

        private ObservableCollection<Solicitacao> _solicitacoesFiltradas;

        public ObservableCollection<Solicitacao> SolicitacoesFiltradas
        {
            get { return _solicitacoesFiltradas; }
            set { SetProperty(ref _solicitacoesFiltradas, value); }
        }

        private ObservableCollection<Solicitacao> _solicitacoesNaoFiltradas;

        public ObservableCollection<Solicitacao> SolicitacoesNaoFiltradas
        {
            get { return _solicitacoesNaoFiltradas; }
            set { SetProperty(ref _solicitacoesNaoFiltradas, value); }
        }


        public AcompanhamentoViewModel()
        {
            _itens = new ObservableCollection<DashBoard>(GetItens());
            _solicitacoesNaoFiltradas = new ObservableCollection<Solicitacao>(GetSolicitacao());
            _solicitacao = new ObservableCollection<Solicitacao>(GetSolicitacao());
            _searchTextCommand = new Command(PerformSearch);
        }

        private void PerformSearch()
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                _solicitacao = _solicitacoesNaoFiltradas;
            }
            else
            {
                if (_searchText.Length > 3)
                {
                    var lista = _solicitacoesNaoFiltradas
                                                    .Where(su => su.Descricao.ToLower()
                                                    .Contains(_searchText.ToLower()));

                    _solicitacoesFiltradas = new ObservableCollection<Solicitacao>(lista);
                    _solicitacao = _solicitacoesFiltradas;
                }
            }
        }

        private static List<Solicitacao> GetSolicitacao()
        {
            return new List<Solicitacao>()
            {
                new Solicitacao{ IdSolicitacao = 1,Usuario="Glauber Marcelino da Silva",DataSolicitacao = DateTime.Now,Descricao="Solicitacão de Teste 1",Status="pendente" },
                new Solicitacao{ IdSolicitacao = 2,Usuario="Acacia Santos Mota",DataSolicitacao = DateTime.Now,Descricao="Solicitacão de Teste 2",Status="aprovado" },
                new Solicitacao{ IdSolicitacao = 4,Usuario="Welder",DataSolicitacao = DateTime.Now,Descricao="Solicitacão de Teste 4" ,Status="aprovado"},
                new Solicitacao{ IdSolicitacao = 3,Usuario="Aline Celestrini",DataSolicitacao = DateTime.Now,Descricao="Solicitacão de Teste 3",Status="cancelado" }
            };
        }

        private static List<DashBoard> GetItens()
        {
            return new List<DashBoard>()
            {
                new DashBoard("https://quantocustaviajar.com/blog/wp-content/uploads/2017/01/lugares-mais-bonitos-do-mundo.jpg","Lugares"),
                new DashBoard("https://gooutside-static-cdn.akamaized.net/wp-content/uploads/sites/3/2019/10/airbnb-lanca-experiencias-com-animais.jpg","Experiências"),
                new DashBoard("https://www.agenciatsuru.com.br/blog/wp-content/uploads/2016/07/marketing-digital-para-turismo-de-aventura-e-ecoturismo.jpg","Aventuras"),
            };
        }
    }
}
