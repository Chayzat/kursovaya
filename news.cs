//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kurs_proj
{
    using System;
    using System.Collections.Generic;
    
    public partial class news
    {
        public int ID_news { get; set; }
        public string name_news { get; set; }
        public Nullable<System.DateTime> date_news { get; set; }
        public string opic_news { get; set; }
        public byte[] photo_news { get; set; }
        public string categ_news { get; set; }
        public byte[] doc_news { get; set; }
    }
}
