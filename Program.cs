using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if (var_tipo == "f")
            {
                // --- Pessoa Física ----
                PessoaFisica pf = new PessoaFisica();
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;

                Console.WriteLine("Informar CPF:");
                pf.CPF = Console.ReadLine();

                Console.WriteLine("Informar RG:");
                pf.RG = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pf.PagarImposto(val_pag);

                Console.WriteLine("-------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.Nome);
                Console.WriteLine("Endereço ......: " + pf.Endereco);
                Console.WriteLine("CPF ...........: " + pf.CPF);
                Console.WriteLine("RG ............: " + pf.RG);
                Console.WriteLine("Valor de Compra: " + pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pf.Total.ToString("C"));
            }
            else if (var_tipo == "j")
            {
                // --- Pessoa Jurídica ----
                PessoaJuridica pj = new PessoaJuridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;

                Console.WriteLine("Informar CNPJ:");
                pj.CNPJ = Console.ReadLine();

                Console.WriteLine("Informar IE:");
                pj.IE = Console.ReadLine();

                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());

                pj.PagarImposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.Nome);
                Console.WriteLine("Endereço ......: " + pj.Endereco);
                Console.WriteLine("CNPJ ..........: " + pj.CNPJ);
                Console.WriteLine("IE ............: " + pj.IE);
                Console.WriteLine("Valor de Compra: " + pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pj.Total.ToString("C"));
            }
        }
    }
}
