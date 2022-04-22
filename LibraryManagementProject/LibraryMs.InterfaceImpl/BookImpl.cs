using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class BookImpl : IBookInterface
    {
        public List<BookResponseDo> getbookDetails()
        {
            List<BookResponseDo> bookDetailList = new List<BookResponseDo>();
            string path = @"C:\Users\Bhawna Rathor\Desktop\LibBookData.csv";
            string[] row=System.IO.File.ReadAllLines(path);
            foreach (string line in row)
            {
                String[] split = line.Split(",");
                foreach (string key in split)
                {
                    BookResponseDo bookResObjDo = new BookResponseDo();
                    bookResObjDo.BookId = Convert.ToInt32(split[0]);
                    bookResObjDo.BookName = split[1];
                    bookResObjDo.AuthorName = split[2];
                    bookResObjDo.IssuedDate = Convert.ToDateTime(split[3]);
                    bookResObjDo.ReturnDate = Convert.ToDateTime(split[4]);
                    bookResObjDo.ISBNNumber = Convert.ToInt32(split[5]);
                    bookResObjDo.BookType = split[6];
                    bookDetailList.Add(bookResObjDo);
                }
            }
           
            return bookDetailList;

        }
    }
}
