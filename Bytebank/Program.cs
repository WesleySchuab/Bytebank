﻿using Bytebank;
using Bytebank.bytebank;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "André Silva";
//contaDaMaria.numero_agencia = 15;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo =300;

//Console.WriteLine("Saldo da conta do Maria = " + contaDaMaria.saldo);


//contaDoAndre.Depositar(100);
//Console.WriteLine( "Saldo pos deposito "+contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}
//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine(  "Conta do andre pós transferência "+contaDoAndre.saldo+" Conta da maria "+contaDaMaria.saldo);
Cliente cliente = new Cliente();
cliente.nome = "Andre";
cliente.cpf = "12346789";
cliente.profissao = "Analista";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.numero_agencia = 15;
conta.conta = "1010-X";
conta.saldo = 100;
Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissao = " + conta.titular.profissao);
Console.WriteLine("Nº Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("Nº Agência = " + conta.numero_agencia);
