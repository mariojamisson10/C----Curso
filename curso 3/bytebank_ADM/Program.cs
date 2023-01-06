using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

Funcionario julio = new Funcionario();
julio.Nome = "Julinho Pernambucano";
julio.Cpf = "123456789";
julio.Salario = 1200;

Console.WriteLine(julio.Nome);
Console.WriteLine(julio.GetBonificacao());

Diretor rafa = new Diretor();
rafa.Nome = "Rafael Tupiniquim";
rafa.Cpf = "987456321";
rafa.Salario = 5200;

Console.WriteLine(rafa.Nome);
Console.WriteLine(rafa.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(julio);
gerenciador.Registrar(rafa);

Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonficacao);



