using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.MaoNaMassa
{
    public class Animal
    {
        private const int TAMANHO_BARRIGA = 5;

        public int _Saciedade = 0;

        private string _Nome = null;
        public string Nome
        {
            get
            {
                return _Nome.ToUpper();
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _Nome = value;
                }
            }
        }

        public string NomeCientifico { get; set; }
        public int Idade { get; set; }

        public void Comer()
        {
            if (_Saciedade == TAMANHO_BARRIGA)
            {
                Console.WriteLine($"O {Nome} não está mais com fome!");
            }
            else
            {
                Console.WriteLine($"O {Nome} está comendo :)");

                _Saciedade++;
            }
        }
    }
}
