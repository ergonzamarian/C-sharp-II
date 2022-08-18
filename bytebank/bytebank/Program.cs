using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Ergon";
conta1.conta = "12345-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 80;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André";
conta2.conta = "12546-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 150;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agência: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agência: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("Saldo do Ergon: " + conta1.saldo);
Console.WriteLine("Saldo do André: " + conta2.saldo);

conta1.Transferir(50, conta2);

Console.WriteLine("Saldo do Ergon: " + conta1.saldo);
Console.WriteLine("Saldo do André: " + conta2.saldo);

Console.ReadKey();