using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NEWPROJECT.Model
{
    public class Book
    {
        private String name;
        private int ISBno;
        private String author_name;
        private String img_url;


        public Book(string name, int ISBno, string authorName, string img_url)
        {
            this.name = name;
            this.ISBno =ISBno;
            this.author_name = authorName;
            this.img_url = img_url;
        }
        public String getName(String name)
        {
            return this.name;
        }
        public int getISBno()
        {
            return this.ISBno;
        }   
        public String getAuthorName()
        {
            return this.author_name;
        }
        public String getImgUrl()
        {
            return this.img_url;
        }
       // public int setISBno() {
        //}

    }
   

   
}
