using System;
using System.Collections.Generic;
using System.IO;

namespace Final_Project{
    public class Movimento{


        public Movimento(int numero_cliente, DateTime data_mov, float valor){
            this.numero_cliente = numero_cliente;
            //this.nome = nome;
            this.data_mov = data_mov;
            this.valor = valor;
        }

/*         public Movimento(int numero_cliente,string nome, float valor, DateTime data_mov){
            this.numero_cliente = numero_cliente;
            this.nome = nome;
            this.data_mov = data_mov;
            this.valor = valor;
        } */

        public Movimento(){} 

        public int numero_cliente{get; set;}
        public string nome{get; set;}
        public DateTime data_mov{get; set;}
        public float valor {get; set;}

    }

}