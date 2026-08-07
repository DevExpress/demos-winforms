namespace DevExpress.DentalClinic.ViewModel {
    public class EditNotesViewModel {
        public virtual string Notes { get; set; }
        public virtual string Action { get; set; }
        public virtual bool SaveNote { get; set; }
        public virtual void Save() {
            SaveNote = true;
        }
    }
}
