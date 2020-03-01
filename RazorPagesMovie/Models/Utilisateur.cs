using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
   public class Utilisateur
   {
      public int ID { get; set; }

      [StringLength(255)]
      public string Email { get; set; }

      [StringLength(255, MinimumLength = 12)]
      public string MotDePasse { get; set; }

      [StringLength(60, MinimumLength = 3)]
      public string Nom { get; set; }

      [StringLength(60, MinimumLength = 3)]
      public string Prenom { get; set; }
   }
}
