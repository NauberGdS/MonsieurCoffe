﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsieurCoffe.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set;}
        public double Preco { get; set;}
        public int Id_Categoria { get; set;}
        public int Id_RespCadastro { get; set;}

    }
}