using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HvadStemmerDe.backend.Application.DTOs
{
    // Minimal information required to identify an aktør
    public class ActorDto
    {
        public int Id {get; set;}
        
        // Only actors of type Person has a name
        public string? FirstName {get; set;} 

        public string? LastName {get; set;}

        public DateTime LastUpdate {get; set;}

        //References the type of actor: [Intern, udvalg, Parlamentarisk forsamling, Anden gruppe, folketingsgruppe, kommission, ministerområde, ministertitel]
        // Enables lookup in the "Aktørtype" table
        public int TypeId {get; set;}
    }
}