using System;

namespace Final_Project{
    internal class Cliente{

        public int numero_cliente { set; get;}
        public bool estado_cliente {set; get; }
        public string nome{ set; get;}
        public string morada{ set; get;}
        public string codigo_postal{ set; get;}
        public string localidade{ set; get;}
        public int telefone{ set; get;}
        public string email{ set; get;}
        public string contribuinte{ set; get;}
        public float saldo_disponivel{ set; get;}
        public DateTime validade_saldo{ set; get;}

        public Cliente(){}



    }
}