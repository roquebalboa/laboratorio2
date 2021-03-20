using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
		//Clientes
			ContaCorrente cliente0 = new ContaCorrente("Teste", 147855, 0);
			ContaCorrente cliente1 = new ContaCorrente("Bob Nelson", 123456, 0);
			ContaPoupanca cliente2 = new ContaPoupanca("Testolfo Rocha", 717171, 0);
			ContaCorrente cliente3 = new ContaCorrente("Lisa Leite", 654321, 0);

        //Depositos
			cliente0.DepositarDinheiro(500);
			Console.ReadLine();
			cliente1.DepositarDinheiro(5000);
			Console.ReadLine();
			cliente2.DepositarDinheiro(1500);
			Console.ReadLine();
			cliente3.DepositarDinheiro(2000);
			Console.ReadLine();
			cliente3.DepositarDinheiro(100);
			Console.ReadLine();

		//Saques
			cliente0.SacarDinheiro(500);
			Console.ReadLine();
			cliente0.SacarDinheiro(100);
			Console.ReadLine();
			cliente1.SacarDinheiro(900);
			Console.ReadLine();
			cliente1.SacarDinheiro(2000);
			Console.ReadLine();
			cliente3.SacarDinheiro(250);
			Console.ReadLine(); 

		//Transferencia
			cliente0.TransferirDinheiro(300, "Bob Nelson");
			cliente1.TransferirDinheiro(1500, "Testolfo Rocha");
			cliente1.TransferirDinheiro(1500, "Lisa Leite");
			cliente2.TransferirDinheiro(1000, "Bob Nelson");
			cliente2.TransferirDinheiro(1200, "Lisa Leite");
			cliente2.TransferirDinheiro(700, "Bob Nelson");
			cliente3.TransferirDinheiro(400, "Testolfo Rocha");
			cliente1.DinheiroTransferido(1000, "Testolfo Rocha");
			cliente1.DinheiroTransferido(700, "Testolfo Rocha");
			cliente2.DinheiroTransferido(1500, "Bob Nelson");
			cliente2.DinheiroTransferido(400, "Lisa Leite");
			cliente3.DinheiroTransferido(1500, "Bob Nelson");

		//Verificar saldo
			cliente0.VerificarSaldo();
			Console.ReadLine();
			cliente1.VerificarSaldo();
			Console.ReadLine();
			cliente2.VerificarSaldo();
			Console.ReadLine();
			cliente3.VerificarSaldo();
			Console.ReadLine();

		}
	}
}