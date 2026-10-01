var valorIngresso = 30.00; // Cria uma variável chamada "valorIngresso" e atribui o valor 30.00 a ela
var idade = 18; // Cria uma variável chamada "idade" e atribui o valor 18 a ela
var
    ehEstudante =
        true; // Cria uma variável chamada "ehEstudante" e atribui um valor que possibilite entender que o usuário é um estudante
var
    clienteVIP =
        true; // Cria uma variável chamada "clienteVIP" e atribui um valor que possibilite entender que o usuário é um cliente VIP

if (clienteVIP) // Verifica se o cliente é VIP
    // Caso seja cliente VIP
    valorIngresso *= 0.4; // Aplica 60% de desconto
else if (idade <= 7 || idade >= 60 || ehEstudante) // Verifica se é criança, idoso ou estudante
    // Caso seja criança, idoso ou estudante
    valorIngresso = valorIngresso * 0.5; // Aplica 50% de desconto

Console.WriteLine(
    $"O valor do ingresso a pagar é R$ {valorIngresso}!"); // Exibe a informação: "O valor do ingresso a pagar é R$ ??"