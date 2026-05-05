using System.Windows;

namespace Login;

public partial class MainWindow : Window
{
    const string USUARIO_PADRAO = "admin";
    const string SENHA_PADRAO = "admin";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("Usuário e senha precisam ser informados", "Informação pendente");
            return;
        }

        if (usuarioDigitado != USUARIO_PADRAO || senhaDigitada != SENHA_PADRAO)
        {
            MessageBox.Show("Usuário e/ou senha incorretos.", "Erro");
            return;
        }

        MessageBox.Show("Boas vindas, Admin");

        var novaJanela = new Painel();
        novaJanela.Show();
    }

    private void BotaoCadastro(object sender, RoutedEventArgs e)
    {
        var janelaCadastro = new Cadastro();
        janelaCadastro.Show();
    }
}