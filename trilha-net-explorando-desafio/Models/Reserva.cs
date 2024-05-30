using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso
            Suite suite101 = new Suite
            {
                Numero = 101,
                Capacidade = 2, // Exemplo, capacidade para 2 pessoas
                ValorDiaria = 150 // Exemplo, valor da diária R$150
            };

            Reserva reserva = new Reserva(7); // Reserva por 7 dias
            reserva.CadastrarSuite(suite101);

            List<Pessoa> hospedes = new List<Pessoa>
            {
                new Pessoa { Nome = "João", Idade = 30 },
                new Pessoa { Nome = "Maria", Idade = 25 }
            };

            try
            {
                reserva.CadastrarHospedes(hospedes);

                Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
                Console.WriteLine($"Valor total da reserva: R${reserva.CalcularValorDiaria():F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar hospedes: {ex.Message}");
            }
        }
    }
}
