namespace DevExpress.MVVM.Demos.ViewModels {
    using DevExpress.MVVM.Demos.Model;

    class AmountMessage {
        public AmountMessage(Transaction t) {
            ID = t.AccountID;
        }
        public long ID { get; set; }
        public decimal Change { get; protected set; }
    }
    class AmountChangedMessage : AmountMessage {
        public AmountChangedMessage(Transaction t, Category category, decimal prevAmount)
            : base(t) {
            decimal sign = (category == null || category.Type == TransactionType.Expense) ? 1 : -1;
            Change = sign * (prevAmount - t.Amount);
        }
    }
    class AmountIncreasedMessage : AmountMessage {
        public AmountIncreasedMessage(Transaction t, Category category)
            : base(t) {
            decimal sign = (category == null || category.Type == TransactionType.Expense) ? -1 : 1;
            Change = t.Amount * sign;
        }
    }
    class AmountDecreasedMessage : AmountMessage {
        public AmountDecreasedMessage(Transaction t, Category category)
            : base(t) {
            decimal sign = (category == null || category.Type == TransactionType.Expense) ? 1 : -1;
            Change = t.Amount * sign;
        }
    }
}
