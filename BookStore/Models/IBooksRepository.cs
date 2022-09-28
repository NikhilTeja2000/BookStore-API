using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public interface IBooksRepository
    {
        List<Books> GetAllBooks();
        Books AddBooks(Books books);
        int DeleteBooks(int bookid);
        Books GetAllBooksByBookId(int id);
        void UpdateBooks(Books books,int id);
        
    }
}
