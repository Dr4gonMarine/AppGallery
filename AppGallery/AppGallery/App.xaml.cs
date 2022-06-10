using AppGallery.AppBase.Models;
using AppGallery.Recursos.Effects;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /* Pagina do tipo NavigationPage
            var pagina = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
            MainPage = pagina;

            Pagina do tipo Modal
            MainPage = new XamarinForms.Paginas.Modal.Conteudo01();

            Pagina do tipo Carrossel
            var pagina = new CarouselPage();
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
            
            pagina.CurrentPage = pagina.Children[1];
            
            MainPage = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel;
            

           var pagina = new MasterDetailPage();
            //Menu
            pagina.Master = ;
            //Conteudo
            pagina.Detail = ;
            */

            MainPage = new AppBase.Menu();
            //MainPage = new Recursos.Controls.TelaTemp(); //->Tela temporaria

            UpdateStatusBarColorByTheme();
        }

        //private void LogicUpdateStatusBarColorByTheme()  -> não funciona
        //{
        //    UpdateStatusBarColorByTheme();
        //    Application.Current.RequestedThemeChanged += (obj, args) => { UpdateStatusBarColorByTheme(); };
        //}

        private void UpdateStatusBarColorByTheme()
        {
            if (Application.Current.RequestedTheme == OSAppTheme.Light)
            {
                ((MasterDetailPage)MainPage).Detail.Effects.Add(new StatusBarEffect() { BackgroundColor = Color.FromHex("#C4C4C4") });
            }
            else
            {
                ((MasterDetailPage)MainPage).Detail.Effects.Add(new StatusBarEffect() { BackgroundColor = Color.FromHex("#000000") });
            }
        }

        public static List<PaginaColecao> MenuItensColecao
        {
            get
            {
                var Pagina = new PaginaColecao()
                {
                    new Pagina() { Nome = "ContentPage", Descricao = "Página de conteúdo", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeConteudo.Conteudo01), IsNavegacao = false },
                    new Pagina() { Nome = "NavigationPage", Descricao = "Estrutura de navegação", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01), IsNavegacao = false },
                    new Pagina() { Nome = "CarouselPage", Descricao = "Navegue entre páginas lado a lado", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeCarrossel.Carrossel), IsNavegacao = false },
                    new Pagina() { Nome = "TabbedPage", Descricao = "Navegação em abas", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeAbas.Abas), IsNavegacao = false },
                    new Pagina() { Nome = "MasterDetailPage", Descricao = "Navegue com menu lateral", ArquivoPagina = typeof(XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral), IsNavegacao = false },
                    new Pagina() { Nome = "Modal", Descricao = "", ArquivoPagina = typeof(XamarinForms.Paginas.Modal.PaginaDeModal), IsNavegacao = false },
                };

                Pagina.Nome = "Páginas";


                var Layout = new PaginaColecao()
                {
                    new Pagina() { Nome = "StackLayout", Descricao = "Organize o conteúdo em pilha", ArquivoPagina = typeof(XamarinForms.Leiout.PilhaLeiout.Pilha), IsNavegacao = false },
                    new Pagina() { Nome = "Grid", Descricao = "Organize o conteúdo em tabela", ArquivoPagina = typeof(XamarinForms.Leiout.GradeLeiout.Grade), IsNavegacao = false },
                    new Pagina() { Nome = "AbsoluteLayout", Descricao = "Posicione o conteúdo em qualuqer lugar", ArquivoPagina = typeof(XamarinForms.Leiout.AbsolutoLeiout.Absoluto), IsNavegacao = false },
                    new Pagina() { Nome = "RelativeLayout", Descricao = "Posicione o conteúdo em relação a outro elemento", ArquivoPagina = typeof(XamarinForms.Leiout.RelativoLeiout.Relativo), IsNavegacao = false },
                    new Pagina() { Nome = "FlexLayout", Descricao = "Posicione o conteúdo em caixar", ArquivoPagina = typeof(XamarinForms.Leiout.FlexivelLeiout.Flexivel), IsNavegacao = false },
                    new Pagina() { Nome = "ScrollView", Descricao = "Adicione barra de rolagem ao seu conteúdo", ArquivoPagina = typeof(XamarinForms.Leiout.BarraDeRolagemLeiout.BarraDeRolagem), IsNavegacao = false },
                    new Pagina() { Nome = "ContentView", Descricao = "Organize o conteúdo dentro de outro elemento", ArquivoPagina = typeof(XamarinForms.Leiout.ControleLeiout.Controle), IsNavegacao = false },
                    new Pagina() { Nome = "Frame", Descricao = "Quadrado de conteúdo", ArquivoPagina = typeof(XamarinForms.Leiout.QuadradoLeiout.Quadrado), IsNavegacao = false },
                };

                Layout.Nome = "Layouts";

                var Controle = new PaginaColecao()
                {
                    new Pagina() { Nome = "BoxView", Descricao = "Desenha um quadrado", ArquivoPagina = typeof(XamarinForms.CaixaControle.Caixa), IsNavegacao = false },
                    new Pagina() { Nome = "Label", Descricao = "Rótulo - Componente para apresentar texto", ArquivoPagina = typeof(XamarinForms.Controle.RadioControle.Rotulo), IsNavegacao = false },
                    new Pagina() { Nome = "Button", Descricao = "Exibe um botão com texto e ação", ArquivoPagina = typeof(XamarinForms.Controle.BotaoControle.Botao), IsNavegacao = false },
                    new Pagina() { Nome = "ImageButton", Descricao = "Exibe uma imagem com ação de botão", ArquivoPagina = typeof(XamarinForms.Controle.BotaoImagemControle.BotaoImagem), IsNavegacao = false },
                    new Pagina() { Nome = "Image", Descricao = "Componente para apresentar um bitmap(imagem)", ArquivoPagina = typeof(XamarinForms.Controle.ImagemControle.Imagem), IsNavegacao = false },
                    new Pagina() { Nome = "Entry", Descricao = "Controle de entrada de texto em uma única linha", ArquivoPagina = typeof(XamarinForms.Controle.CampoDeEntradaSimplesControle.CampoDeEntradaSimples), IsNavegacao = false },
                    new Pagina() { Nome = "Editor", Descricao = "Controle de entreada de texto em várias linhas", ArquivoPagina = typeof(XamarinForms.Controle.CampoDeEntradaMultiLineControle.CampoDeEntradaMultiLine), IsNavegacao = false },
                    new Pagina() { Nome = "CheckBox", Descricao = "Componente de valor booleano, permite marcar ou desmarcara opção", ArquivoPagina = typeof(XamarinForms.Controle.CaixaDeMarcacaoControle.CaixaDeMarcacao), IsNavegacao = false },
                    new Pagina() { Nome = "RadioButton", Descricao = "Controle do tipo botão de seleção única", ArquivoPagina = typeof(XamarinForms.Controle.CaixaDeRadioControle.CaixaDeRadio), IsNavegacao = false },
                    new Pagina() { Nome = "Switch", Descricao = "Controle em formato de chave com valor booleano", ArquivoPagina = typeof(XamarinForms.Controle.InterruptorControle.Interruptor), IsNavegacao = false },
                    new Pagina() { Nome = "Stepper", Descricao = "Controle passador de valores em double", ArquivoPagina = typeof(XamarinForms.Controle.PassadorControle.Passador), IsNavegacao = false },
                    new Pagina() { Nome = "Slider", Descricao = "Barra de rolagem com valores double", ArquivoPagina = typeof(XamarinForms.Controle.DeslizanteControle.Deslizante), IsNavegacao = false },
                    new Pagina() { Nome = "Picker", Descricao = "Exibe uma lista de opções para seleção", ArquivoPagina = typeof(XamarinForms.Controle.SelecaoControle.Selecao), IsNavegacao = false },
                    new Pagina() { Nome = "DatePicker", Descricao = "Controle de seleção de data", ArquivoPagina = typeof(XamarinForms.Controle.DataSelecaoControle.DataSelecao), IsNavegacao = false },
                    new Pagina() { Nome = "TimePicker", Descricao = "Controle de seleção de horas", ArquivoPagina = typeof(XamarinForms.Controle.TempoSelecaoControle.TempoSelecao), IsNavegacao = false },
                    new Pagina() { Nome = "ActivityIndicator", Descricao = "Exibe um indicador de atividade sem indicador de progresso", ArquivoPagina = typeof(XamarinForms.Controle.IndicadorDeAtividadeControle.IndicadorDeAtividades), IsNavegacao = false },
                    new Pagina() { Nome = "ProgressBar", Descricao = "Exibe um indicador de atividade com indicador de progresso", ArquivoPagina = typeof(XamarinForms.Controle.BarraDeProgressoControle.BarraDeProgresso), IsNavegacao = false },
                    new Pagina() { Nome = "SearchBar", Descricao = "Área de digitação com botão de pesquisa", ArquivoPagina = typeof(XamarinForms.Controle.BarraDePesquisa.BarraDePesquisa), IsNavegacao = false },
                    new Pagina() { Nome = "RefreshView", Descricao = "Componente com ação de pull utilizado para atualização de uma tela ou componente", ArquivoPagina = typeof(XamarinForms.Controle.AtualizarControle.Atualiza), IsNavegacao = false },
                    new Pagina() { Nome = "SwipeView", Descricao = "Componente de exibição de opções após realizar um gesto", ArquivoPagina = typeof(XamarinForms.Controle.ArrastoControle.Arrasto), IsNavegacao = false },
                    new Pagina() { Nome = "WebView", Descricao = "Browser - Exibe um conteúdo HTML", ArquivoPagina = typeof(XamarinForms.Controle.NavegadorControle.Navegador), IsNavegacao = false },
                    new Pagina() { Nome = "MediaElement", Descricao = "Player de música - não funcional", ArquivoPagina = typeof(XamarinForms.Controle.MediaControle.Midia), IsNavegacao = false },
                    new Pagina() { Nome = "Expansor", Descricao = "Controle que se expande para exibir o conteúdo (Community kit)", ArquivoPagina = typeof(XamarinForms.Controle.ExpansorControle.Expansor), IsNavegacao = false },
                };

                Controle.Nome = "Controle";

                var Listas = new PaginaColecao()
                {
                    new Pagina() { Nome = "TableView", Descricao = "Exibe uma lista de linhas com tipos de células", ArquivoPagina = typeof(XamarinForms.Listas.TabelaControle.Tabela), IsNavegacao = false },
                    new Pagina() { Nome = "ListView", Descricao = "Exibe elementos em lista", ArquivoPagina = typeof(XamarinForms.Listas.ListaControle.Lista), IsNavegacao = false },
                    new Pagina() { Nome = "CollectionView", Descricao = "Exibe elementos em lista.", ArquivoPagina = typeof(XamarinForms.Listas.ColecaoControle.Colecao), IsNavegacao = true },
                    new Pagina() { Nome = "CarouselView", Descricao = "Exibe elementos lado a lado", ArquivoPagina = typeof(XamarinForms.Listas.CarrosselControle.Carrossel), IsNavegacao = true },
                    new Pagina() { Nome = "IndicatorView", Descricao = "Exibe um indicador de posição", ArquivoPagina = typeof(XamarinForms.Listas.IndicadorControle.Indicador), IsNavegacao = true },
                    new Pagina() { Nome = "ObservableCollection", Descricao = "Classe que atualiza os controles de lista automaticamente", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspecias.ColecaoObservavel), IsNavegacao = true },
                    new Pagina() { Nome = "INotifyPropertyChanged", Descricao = "Classe que atualiza os controles de lista automaticamente", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspecias.NotificarMudançaPropriedade), IsNavegacao = true },
                    new Pagina() { Nome = "DataTemplateSelector", Descricao = "Classe que permite escolher o layout de cada linha da lista", ArquivoPagina = typeof(XamarinForms.Listas.ClassesEspecias.SeletorTemplate), IsNavegacao = true },
                };

                Listas.Nome = "Listas";

                var estilos = new PaginaColecao()
                {
                    new Pagina() { Nome = "ExplicitStyle", Descricao = "Forma explicita de adicionar estilo", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloExplicito.Explicito), IsNavegacao = true },
                    new Pagina() { Nome = "ImplicitStyle", Descricao = "Forma implicita de adicionar estilo", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloImplicito.Implicito), IsNavegacao = true },
                    new Pagina() { Nome = "GlobalStyle", Descricao = "Estilo global", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloGlobal.Global), IsNavegacao = true },
                    new Pagina() { Nome = "InheritStyle", Descricao = "Criar estilos a partir de outros", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloHerdado.Herdado), IsNavegacao = true },
                    new Pagina() { Nome = "DynamicStyle", Descricao = "Estilo que pode mudar em tempo de execução", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloDinamico.Dinaminco), IsNavegacao = true },
                    new Pagina() { Nome = "StyleClass", Descricao = "Forma de nomear estilos", ArquivoPagina = typeof(XamarinForms.Estilos.EstiloClasse.Classe), IsNavegacao = true },
                    new Pagina() { Nome = "VisualStateManager", Descricao = "Apresentação visual diferente em situações(state) do componente", ArquivoPagina = typeof(XamarinForms.Estilos.VSM.VSM), IsNavegacao = true },
                    new Pagina() { Nome = "MaterialDesign", Descricao = "Aplicar Google Material Design no app", ArquivoPagina = typeof(XamarinForms.Estilos.MaterialDesing.Material), IsNavegacao = true },
                    new Pagina() { Nome = "Font", Descricao = "Adicionar fonte personalizada", ArquivoPagina = typeof(XamarinForms.Estilos.FontePersonalizada.Fonte), IsNavegacao = true },
                    new Pagina() { Nome = "ChangeTheme", Descricao = "Mudar o tema do App", ArquivoPagina = typeof(XamarinForms.Estilos.TrocarTema.Tema), IsNavegacao = true },
                    new Pagina() { Nome = "LightDarkTheme", Descricao = "Reagir a mudança de Tema do Android", ArquivoPagina = typeof(XamarinForms.Estilos.TemaClaroEscuro.ClaroEscuro), IsNavegacao = true },
                };
                estilos.Nome = "Estilos";

                var animacao = new PaginaColecao()
                {
                    new Pagina() { Nome = "Animações simples", Descricao = "Anime quase tudo no Xamarin Forms, de leiautes a controles", ArquivoPagina = typeof(XamarinForms.Animacoes.Simples.Simples), IsNavegacao = true },
                };
                animacao.Nome = "Animação";

                var gestos = new PaginaColecao()
                {
                    new Pagina() { Nome = "Gestos simples", Descricao = "Detecte gestos feito pelo usuário", ArquivoPagina = typeof(XamarinForms.Gestos.Gestos), IsNavegacao = true },
                };
                gestos.Nome = "Gestos";

                var classesuteis = new PaginaColecao()
                {
                    new Pagina() { Nome = "Display", Descricao = "Apresente Pop-ups para o usuário", ArquivoPagina = typeof(XamarinForms.Classes.Alertas.Alerta), IsNavegacao = true },
                    new Pagina() { Nome = "Converter", Descricao = "Mude/Converte a informação da tela", ArquivoPagina = typeof(XamarinForms.Classes.Conversores.Conversor), IsNavegacao = true },
                    new Pagina() { Nome = "MessageCenter", Descricao = "Troque mensagens entre telas de forma elegante", ArquivoPagina = typeof(XamarinForms.Classes.CentroMensagem.Pagina01), IsNavegacao = true },
                    new Pagina() { Nome = "OnPlatform/OnIdiom", Descricao = "Detecte sistema operacional, dispositivo e personalize sua interface", ArquivoPagina = typeof(XamarinForms.Classes.Detectar.Detectar), IsNavegacao = true },
                };
                classesuteis.Nome = "Classes úteis";

                var xf47 = new PaginaColecao()
                {
                    new Pagina() { Nome = "Grid Rápida", Descricao = "Nova Forma de declarar colunas e linhas", ArquivoPagina = typeof(XamarinForms.XF47.GridRapida), IsNavegacao = true },
                    new Pagina() { Nome = "Multi-Bindings", Descricao = "Texto com vinculos multiplos", ArquivoPagina = typeof(XamarinForms.XF47.MultiplosVinculos), IsNavegacao = true },
                    new Pagina() { Nome = "Formas (Shapes)", Descricao = "Construa formas retângulares, elipse e linhas", ArquivoPagina = typeof(XamarinForms.XF47.Formas), IsNavegacao = true },
                    new Pagina() { Nome = "Paths", Descricao = "Desenhe Livremente", ArquivoPagina = typeof(XamarinForms.XF47.Caminhos), IsNavegacao = true },
                    
                };
                xf47.Nome = "Xamarin Forms 4.7";

                var shell = new PaginaColecao()
                {
                    new Pagina() { Nome = "Tabbar (Shell)", Descricao = "Uma nova forma de navegação baseada em abas com Shell", ArquivoPagina = typeof(XamarinForms.Concha.Abas.AppShellTabbar), SubstituirMainPage = true },                    
                };
                shell.Nome = "Shell";

                return new List<PaginaColecao>()
                {
                    Pagina,
                    Layout,
                    Controle,
                    Listas,
                    estilos,
                    animacao,
                    gestos,
                    classesuteis,
                    xf47,
                    shell
                };
            }
        }
        private void AbrirPagina(object sender, EventArgs e)
        {
            try
            {
                //Pegar o parametro (Pagina)
                TappedEventArgs eventArgs = (TappedEventArgs)e;
                Pagina parametro = (Pagina)eventArgs.Parameter;

                //Verificar se tem ou não navegação
                Page pagina = null;

                if(parametro.SubstituirMainPage)
                {
                    pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
                    App.Current.MainPage = pagina;
                }
                else
                {
                    if (parametro.IsNavegacao)
                    {

                        pagina = new NavigationPage((Page)Activator.CreateInstance(parametro.ArquivoPagina));

                    }
                    else
                    {
                        pagina = (Page)Activator.CreateInstance(parametro.ArquivoPagina);
                    }

                }
                //Abrir a tela e fechar o menu
                // var x = this.GetType();
                //var y = this;
                //var z = App.Current.MainPage;
                ((MasterDetailPage)App.Current.MainPage).Detail = pagina;
                ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

