using System.Windows;
using System.Windows.Media.Imaging;

namespace Login;

public partial class Painel : Window
{
    private int tempoMaximo = 30;
    
    public Painel()
    {
        InitializeComponent();
    }

    private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
    {
        var nomeEstudante = tbEstudanteNome.Text;

        switch (nomeEstudante.ToLower())
        {
            case "rebeca spinola":
                imagemAluna.Source =
                    CriarImagem(
                        "https://ichef.bbci.co.uk/ace/ws/640/cpsprodpb/11F73/production/_120878537_4cfca0d7-2b27-474f-93b7-4c31269c5cdf.jpg.webp");
                break;

            case "sarah":
                imagemAluna.Source =
                    CriarImagem("https://adimax.com.br/wp-content/uploads/2022/05/cuidados-filhote-de-cachorro.jpg");
                break;

            case "yatra":
                imagemAluna.Source =
                    CriarImagem(
                        "https://blog-static.petlove.com.br/wp-content/uploads/2021/08/Gato-laranja-filhote.jpg");
                break;

            case "maria":
                imagemAluna.Source =
                    CriarImagem("https://www.adoropets.com.br/wp-content/uploads/2021/01/pinscher-906x1024.jpg");
                break;

            case "laura":
                imagemAluna.Source =
                    CriarImagem("https://mega.ibxk.com.br/2022/11/14/14133140341263.jpg?ims=fit-in/800x500");
                break;

            case "isabela":
                imagemAluna.Source =
                    CriarImagem(
                        "https://png.pngtree.com/thumb_back/fw800/background/20250908/pngtree-a-white-fox-with-glowing-eyes-stands-on-the-snow-image_19021513.webp");
                break;

            case "adriely":
                imagemAluna.Source = CriarImagem(
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Hydrochoeris_hydrochaeris_in_Brazil_in_Petr%C3%B3polis%2C_Rio_de_Janeiro%2C_Brazil_09.jpg/1280px-Hydrochoeris_hydrochaeris_in_Brazil_in_Petr%C3%B3polis%2C_Rio_de_Janeiro%2C_Brazil_09.jpg");
                break;

            case "rebeca dias":
                imagemAluna.Source = CriarImagem("https://upload.wikimedia.org/wikipedia/en/f/fd/Pusheen_the_Cat.png");
                break;

            case "joyce":
                imagemAluna.Source =
                    CriarImagem(
                        "https://w7.pngwing.com/pngs/189/183/png-transparent-smiley-the-snowman-lr-face-smiley-animal-thumbnail.png");
                break;

            default:
                imagemAluna.Source = CriarImagem("pack://application:,,,/Images/leao.jpg");
                break;
        }
    }

    private static BitmapImage CriarImagem(string url)
    {
        var imagemBitmap = new BitmapImage();
        imagemBitmap.BeginInit();
        imagemBitmap.UriSource = new Uri(url);
        imagemBitmap.EndInit();
        return imagemBitmap;
    }

    private async void GerenciarContagemRegressiva()
    {
        int contador = 0;

        while (contador < tempoMaximo)
        {
            await Task.Delay(1000);
            contador++;
            displayTemporizador.Text = $"Contagem Regressiva: {tempoMaximo - contador}s";
        }
        
        this.Close();
    }

    private void QuandoJanelaAbrir(object sender, RoutedEventArgs e)
    {
        GerenciarContagemRegressiva();
    }
}