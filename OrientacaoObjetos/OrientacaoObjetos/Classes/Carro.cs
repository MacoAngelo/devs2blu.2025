using OrientacaoObjetos.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Classes
{
    public class Carro : IMotorizado
    {
        private static int _ID = 1;
        public int ID { get; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public double Temperatura { get; set; }

        public Carro(string marca, string modelo, string cor, int ano)
        {
            ID = _ID;
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;

            _ID++;
        }

        public void Acelerar()
        {
            // Teste
            Console.WriteLine($"O {Modelo} está acelerando normalmente :)");
        }

        public void Acelerar(int pedal)
        {
            // Teste
            if (pedal <= 5)
            {
                Console.WriteLine($"O {Modelo} está acelerando lentamente");
            }
            else if (pedal <= 100)
            {
                Acelerar();
            }
            else
            {
                Console.WriteLine($"O {Modelo} está acelerando loucamente :P");
            }
        }

        public bool Desligar()
        {
            Console.WriteLine("O carro desligou!");
            return true;
        }

        public bool Ligar()
        {
            Console.WriteLine("O carro ligou!");
            return true;
        }
    }
}