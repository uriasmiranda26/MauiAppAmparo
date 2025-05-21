﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppAmparo.Models
{
    public class Idoso
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string ContatoEmergencia { get; set; }
    }
}
