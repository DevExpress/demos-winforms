namespace DevExpress.MVVM.Demos.Model {
    using System.ComponentModel.DataAnnotations;
    
    public class Account {
        [Key, Display(AutoGenerateField = false)]
        public long ID { get; set; }
        [Required, StringLength(30, MinimumLength = 4)]
        [Display(Name = "ACCOUNT")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "AMOUNT")]
        public decimal Amount { get; set; }
        public override string ToString() {
            return Name + " (" + Amount.ToString("C") + ")";
        }
    }
}
