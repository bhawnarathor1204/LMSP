using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class BookFilterImpl : IBookFilterInterface

    {
        public List<List<BookResponseDo>> bookFilter(List<string> filterType)
        {
            List<List<BookResponseDo>> bookResponseList = new List<List<BookResponseDo>>();  
            /*foreach (var book in filterType)
            {
                bookResponseList.Add(filterHelper(book));
            }*/
            return bookResponseList;
        }
        /*private List<BookResponseDo> filterHelper(string filterType)
        {
<<<<<<< HEAD
            List<BookResponseDo> bookDetails = getBooks();
=======
            BookImpl bookImpl = new BookImpl(); 
            List<BookResponseDo> bookDetails = bookImpl.getbookDetails();
>>>>>>> 96878cf (after rectifying error)
            List<BookResponseDo> filterBooks = new List<BookResponseDo>();
            foreach (var book in bookDetails)
            {
                if (book.BookType == filterType)
                {
                    filterBooks.Add(book);
                }
            }
            return filterBooks;
        }*/
    }
}
