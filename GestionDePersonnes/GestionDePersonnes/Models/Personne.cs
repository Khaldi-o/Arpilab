using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GestionDePersonnes.Models
{
[ Table("personne")]

    public class Personne
    {

        [Key]
        public int Id_personne { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public int Num_tel { get; set; }
        public float Note { get; set; }
        public string Departement { get; set; }
        public string Date_naissance { get; set; }


    }
}
