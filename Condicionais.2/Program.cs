// Crie uma variável chamada "idade" e atribua o valor 18 a ela
int idade = 70;
// Crie uma variável chamada "valorIngresso" e atribua o valor 30.00 a ela
double valorIngresso = 30.00;
// Criar um bloco de condição testando se a idade é menor ou igual à 7
if (idade <= 7 || idade >= 60)
// if (idade is <= 7 or >= 60 )
{
    // Dentro do bloco da condição, você terá que calcular a metade do valor do ingresso e atribui-lo novamente à variável "valorIngresso"
    valorIngresso = valorIngresso / 2;
}
// Exiba a informação abaixo:
// "O valor do ingresso a pagar é R$ ??"
Console.WriteLine($"O valor do ingresso a pagar é R$ {valorIngresso}!");