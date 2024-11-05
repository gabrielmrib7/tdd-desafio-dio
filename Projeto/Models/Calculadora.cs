using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_desafio.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        
        public int Somar(int x, int y)
        {
            listaHistorico.Insert(0, $"{x} + {y} = {x+y}");
            return x+y;
        }
        public int Subtrair(int x, int y)
        {
            listaHistorico.Insert(0, $"{x} - {y} = {x-y}");
            return x-y;
        }
        public int Multiplicar(int x, int y)
        {
            listaHistorico.Insert(0, $"{x} * {y} = {x*y}");
            return x*y;
        }
        public int Dividir(int x, int y)
        {
            listaHistorico.Insert(0, $"{x} / {y} = {x/y}");
            return x/y;
        }

        public List<string> Historico()
        {            
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}