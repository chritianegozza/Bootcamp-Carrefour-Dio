using static System.Console;


Pessoa p1 = new Pessoa();

p1.Nome = "Christiane";
p1.Idade = 36;

p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua Calos Gomes",
    Numero = 350,
    CEP = "11000000",
    Cidade = "São Paulo",
};

WriteLine("Fim");