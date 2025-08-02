using Microsoft.AspNetCore.Mvc;
using backend.Data;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly LibraryContext _context;

        public LoanController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoans()
        {
            return await _context.Loans
                .Include(l => l.Book)
                .Include(l => l.User)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Loan>> GetLoan(int id)
        {
            var loan = await _context.Loans
                .Include(l => l.Book)
                .Include(l => l.User)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (loan == null) return NotFound();
            return loan;
        }

        [HttpPost]
        public async Task<ActionResult<Loan>> CreateLoan(Loan loan)
        {
            // Validate User
            var user = await _context.Users.FindAsync(loan.UserId);
            if (user == null)
                return BadRequest("User does not exist.");

            // Validate Book
            var book = await _context.Books.FindAsync(loan.BookId);
            if (book == null)
                return BadRequest("Book does not exist.");

            // Check if Book is available
            if (!book.isAvailable)
                return BadRequest("Book is not available for loan.");

            // Validate LoanDate
            if (loan.LoanDate > DateTime.UtcNow)
                return BadRequest("Loan date cannot be in the future.");

            // Mark book as unavailable
            book.isAvailable = false;
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLoan), new { id = loan.Id }, loan);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLoan(int id, Loan loan)
        {
            if (id != loan.Id) return BadRequest();

            // Validate User
            var user = await _context.Users.FindAsync(loan.UserId);
            if (user == null)
                return BadRequest("User does not exist.");

            // Validate Book
            var book = await _context.Books.FindAsync(loan.BookId);
            if (book == null)
                return BadRequest("Book does not exist.");

            // Validate LoanDate
            if (loan.LoanDate > DateTime.UtcNow)
                return BadRequest("Loan date cannot be in the future.");

            _context.Entry(loan).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan == null) return NotFound();

            // Mark book as available again
            var book = await _context.Books.FindAsync(loan.BookId);
            if (book != null)
                book.isAvailable = true;

            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}