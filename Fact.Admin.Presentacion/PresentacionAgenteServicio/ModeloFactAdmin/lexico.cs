//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentacionAgenteServicio.ModeloFactAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class lexico
    {
        public int idlexico { get; set; }
        public string lxvc_tabla { get; set; }
        public string lxvc_tema { get; set; }
        public string lxvc_valor { get; set; }
        public string lxvc_desc { get; set; }
        public string lxvc_desc_larga { get; set; }
        public Nullable<System.DateTime> lxdt_fecha_insert { get; set; }
        public string lxvc_user_insert { get; set; }
        public Nullable<System.DateTime> lxdt_fecha_modif { get; set; }
        public string lxvc_user_modif { get; set; }
        public Nullable<bool> lxbt_activo { get; set; }
    }
}
