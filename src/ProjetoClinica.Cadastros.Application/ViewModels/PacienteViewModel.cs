﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClinica.Business.ViewModels
{
    public class PacienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Telefone { get; set; }
        public string ProfissaoAtual { get; set; }
        public string ProfissaoAnterior { get; set; }
        public string? Diagnostico { get; set; }
        public string? TratamentosAnteriores { get; set; }
        public string? Descricao { get; set; }
        public byte[]? Foto { get; set; }
        public int FisioterapeutaId { get; set; }

        public PacienteViewModel()
        {            
        }
    }
}
