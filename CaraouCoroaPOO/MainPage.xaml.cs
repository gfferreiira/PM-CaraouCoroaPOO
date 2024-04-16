using CaraouCoroaPOO.Models;

namespace CaraouCoroaPOO
{
    public partial class MainPage : ContentPage
    {

        int escolhaResultado = 0;

        string escolha = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSpin_Clicked(object sender, EventArgs e)
        {
            // Armazena a escolha do picker e define o random para sortear o número
            escolha = SidesPicker.SelectedItem.ToString();

            int rnd = new CoinModel().Girar();
            //Compara oque o usuario escolhe com o número sorteado
            EscolhaResultado("Cara");

            //Exibe a mensagem de resultado do sorteio
            ExibirMensagem(rnd);

            //Troca a imagem de acordo com o número sorteado
            TrocarImagem(rnd);
        }

        private void ExibirMensagem(int rnd)
        {
            if (escolhaResultado == rnd)
            {
                ResultLabel.Text = $"Eba, deu {escolha}, você ganhou!";
            }
            else
            {
                ResultLabel.Text = $"Que pena, não deu {escolha}, você perdeu!";
            }
        }


        private void EscolhaResultado(string escolhaDoUsuario)
        {
            if (escolha == escolhaDoUsuario)
            {
                escolhaResultado = (int)CoinType.CARA;
            }
            else
            {
                escolhaResultado = (int)CoinType.COROA;
            }
        }

        private void TrocarImagem(int rnd)
        {
            switch (rnd)
            {
                case (int)CoinType.CARA:
                default:
                    CoinImage.Source = "cara.jpg";
                    break;
                case (int)CoinType.COROA:
                    CoinImage.Source = "coroa.jpg";
                    break;
            }
        }

    }

    }



