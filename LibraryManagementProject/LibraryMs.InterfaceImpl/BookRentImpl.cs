using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class BookRentImpl : IBookRentInterface
    {
        public bool createBookRentDetails(BookRentRequestDo bookRentRequestDo)
        {
            Console.WriteLine(bookRentRequestDo.BookName);
            string fileName = @"C:\Users\Bhawna Rathor\Desktop\LibBookData.csv";
            string bookRentDetails = 2 + "," + bookRentRequestDo.BookName + "," + bookRentRequestDo.IssueDate + "," + bookRentRequestDo.ReturnDate+","+ bookRentRequestDo.Status;
            //File.AppendAllText(fileName, bookRentDetails);
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(bookRentDetails);
            }

            return true;
        }
    }
}
