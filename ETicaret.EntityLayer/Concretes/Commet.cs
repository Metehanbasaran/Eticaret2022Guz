using ETicaret.EntityLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.EntityLayer.Concretes
{
    public class Commet:IEntity
    {
        public int CommetId {get; set; }
        public string commentingperson { get; set; }
        public string CommetSurName { get; set; }
        public bool CommetStatu { get; set; }
        public DateTime CommetDateTime { get; set; }
        public string CommetText { get; set; }


    }
}
