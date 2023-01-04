using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;
Console.WriteLine("Saldo da conta do André =" + contaDoAndre.saldo);

//Depositando dinheiro
Console.WriteLine("////////////////////// Depositando Dinheiro //////////////////////");
contaDoAndre.Depositar(100);
Console.WriteLine("Saldo apos deposito: "+ contaDoAndre.saldo);

//Sacando Dinheiro
Console.WriteLine("////////////////////// Sacando Dinheiro //////////////////////");  
contaDoAndre.Sacar(200);
Console.WriteLine("Saldo após o saque: "+ contaDoAndre.saldo);

//Transferindo Dinheiro
Console.WriteLine("///////////////////// Transferindo Dinheiro //////////////////////");
ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);




