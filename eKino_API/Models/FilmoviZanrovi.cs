//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eKino_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FilmoviZanrovi
    {
        public int FilmZanrID { get; set; }
        public int FilmID { get; set; }
        public int ZanrID { get; set; }
    
        public virtual Filmovi Filmovi { get; set; }
        public virtual Zanrovi Zanrovi { get; set; }
    }
}
