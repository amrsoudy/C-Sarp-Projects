using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Books
    {

        public List<Book> getListBooks() {

            return new List<Book> {

                new Book() {Title ="title 1",Price = 5 },
                new Book() {Title = "title 2",Price = 7},
                new Book() { Title = "title 3",Price = 17}

            };


        }


    }
}
