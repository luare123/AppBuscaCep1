﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppBuscaCep1.Model
{
    public class Cidade
    {
        public int id_cidade { get; set; }
        public string descricao { get; set; }
        public string uf { get; set; }
        public int codigo_ibge { get; set; }
        public int ddd { get; set; }
    }
}