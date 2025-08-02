namespace backend.Models
{
    public class Loan
    {
        public int Id {get;set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }


        // Navigation properties
        public Book? Book { get; set; }
        public User? User { get; set; }     
    }
}
