Console.WriteLine("""
                  ----- JOKENPÔ -----
                  Escolha a sua jogada:
                  1 - Pedra
                  2 - Papel
                  3 - Tesoura
                  """);
Console.Write("Sua opção: ");

// Ler a opção da pessoa, converter para inteiro e salvar em algum lugar
// Crie uma variável > Atribuir valor > Converter para inteiro > Ler a proxima linha do console.
int opcaoUsuario = Convert.ToInt32(Console.ReadLine());

while (opcaoUsuario < 1 || opcaoUsuario > 3)
{
    Console.WriteLine("Opção inválida. Escolha um número entre 1 e 3.");
    opcaoUsuario = Convert.ToInt32(Console.ReadLine());
}

var aleatorio = new Random();
int opcaoComputador = aleatorio.Next(1, 4);

// Estrutura Switch-Case
string escolhaUsuarioTexto;
string escolhaComputadorTexto;

switch (opcaoUsuario)
{
    case 1:
        // Aqui vem os comandos do caso 1
        escolhaUsuarioTexto = "pedra";
        break;
    case 2:
        escolhaUsuarioTexto = "papel";
        break;
    case 3:
        escolhaUsuarioTexto = "tesoura";
        break;
    default:
        escolhaUsuarioTexto = "nenhum";
        break;
}

switch (opcaoComputador)
{
    case 1:
        escolhaComputadorTexto = "pedra";
        break;
    case 2:
        escolhaComputadorTexto = "papel";
        break;
    case 3:
        escolhaComputadorTexto = "tesoura";
        break;
    default:
        escolhaComputadorTexto = "nenhum";
        break;
}

Console.WriteLine($"O usuário escolheu {escolhaUsuarioTexto} e o computador escolheu {escolhaComputadorTexto}");