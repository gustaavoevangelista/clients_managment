using System;
using System.Collections.Generic;
using System.IO;

namespace Final_Project{
    public class Movimentos{
        private string Ficheiro_Mov = @$"{Environment.CurrentDirectory}\movimentos.csv";

        private List<Movimento> lista_movimentos = new List<Movimento>();

        internal Movimentos(){}

        internal int ContagemMov()
        {
            return lista_movimentos.Count;
        }

        internal void ListarCarregamentos(int i){



        }

 
        


    }

}