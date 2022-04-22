using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class CommonFeatureImpl : ICommonFeatureInterface
    {
        public BookResponseDo searchBar(string str)
        {
            BookResponseDo bookResponse = new BookResponseDo();
<<<<<<< HEAD
<<<<<<< HEAD
            /*List<BookResponseDo> allBooks = getBooks();   
           foreach (BookResponseDo bookResponseDo in allBooks)
=======
            BookImpl bookImpl = new BookImpl();
            List<BookResponseDo> allBooks = bookImpl.getbookDetails();
            foreach (BookResponseDo bookResponseDo in allBooks)
>>>>>>> 96878cf (after rectifying error)
=======
            BookImpl bookImpl = new BookImpl();
            List<BookResponseDo> allBooks = bookImpl.getbookDetails();
            foreach (BookResponseDo bookResponseDo in allBooks)
>>>>>>> 96878cf (after rectifying error)
            {
                if (str.ToLower() == bookResponseDo.BookName.ToLower())
                {
                    return bookResponseDo;
                }
            }
<<<<<<< HEAD
<<<<<<< HEAD
           bookResponse.BookName = "book not found";*/
=======
            bookResponse.BookName = "book not found";
>>>>>>> 96878cf (after rectifying error)
=======
            bookResponse.BookName = "book not found";
>>>>>>> 96878cf (after rectifying error)
            return bookResponse;
        }
        
    }
}
