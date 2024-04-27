using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace examen_parcial_cuentas.Models.Entity
{
    [Table("t_cuenta")]

    public class Cuenta
    {

        //EL SIGNO DE INTERROGACION ES PARA DEJAR VALORES NULOS
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }

         public string? Titular { get; set; }

        public string? Email { get; set; }

        public string? TipoCuenta { get; set; }

        public Decimal? SaldoInicial { get; set; }

    }
}