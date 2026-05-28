using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace DevExpress.DentalClinic.ViewModel {
    public class EditNotesViewModel  {
        public virtual string Notes { get; set; }
        public virtual string Action { get; set; }
        public virtual bool SaveNote { get; set; }
        public virtual void Save() {
            SaveNote = true;
        }
    }
}
