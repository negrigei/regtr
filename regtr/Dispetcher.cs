//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace regtr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dispetcher
    {
        public Dispetcher()
        {
            this.Perevozka = new HashSet<Perevozka>();
        }
    
        public int ID_Dispetcher { get; set; }
        public string Ф_И_О { get; set; }
        public System.DateTime Дата_рождения { get; set; }
        public string Адрес { get; set; }
    
        public virtual ICollection<Perevozka> Perevozka { get; set; }
    }
}