using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao(); 

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor robyson = new Diretor("999.999.999-99");
            robyson.Nome = "Robyson";
            robyson.Senha = "123";

            GerenteDeConta agatha = new GerenteDeConta("999.999.999-98");
            agatha.Nome = "Agatha";
            agatha.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(robyson, "123");
            sistemaInterno.Logar(agatha, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario roger = new Designer("999.999.999-97");
            roger.Nome = "Roger";

            Funcionario robyson = new Diretor("999.999.999-99");
            robyson.Nome = "Robyson";

            Funcionario erika = new Auxiliar("999.999.999-96");
            erika.Nome = "Erika";

            Funcionario agatha = new GerenteDeConta("999.999.999-98");
            agatha.Nome = "Agatha";

            Desenvolvedor guilherme = new Desenvolvedor("999.999.999-95");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(guilherme);
            gerenciadorBonificacao.Registrar(roger);
            gerenciadorBonificacao.Registrar(robyson);
            gerenciadorBonificacao.Registrar(erika);
            gerenciadorBonificacao.Registrar(agatha);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
