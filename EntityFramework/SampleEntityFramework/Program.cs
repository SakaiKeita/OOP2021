using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //using(var db = new BooksDbContext()) {
            //    var count = db.Books.Count();
            //    Console.WriteLine(count);
            //    db.Database.Log = sql => { Debug.Write(sql); };  
            //  Exercise13_1_1();
             // Exercise13_1_2_2();
           Exercise13_1_2();
             // Exercise13_1_3();
         //     Exercise13_1_4();
          //   Exercise13_1_5();

        }

        private static void Exercise13_1_2() {
            using(var db = new BooksDbContext()) {
                var eiei = db.Books.Include(nameof(Author)).ToList();
                foreach(var item in eiei) {

                    Console.WriteLine($"{item.Title}{item.PublishedYear}{item.Author.Name}{item.Author.Birthday:yyyy/MM/dd}");


                }


            }

        }

        private static void Exercise13_1_5() {
            using(var db = new BooksDbContext()) {

                var books = db.Books.OrderByDescending(a => a.Author.Birthday);
                var groups=books.GroupBy(b => b.Author.Name);
                foreach(var group in groups) {
                    Console.WriteLine(group.Key);



                    foreach(var items in group) {

                        Console.WriteLine($"{items.Title}{items.PublishedYear}");

                    }
                }
            }
        }
        private static void Exercise13_1_4() {

            using(var db = new BooksDbContext()) {

                var books = db.Books.OrderBy(a => a.PublishedYear).Take(3);
                foreach(var items in books) {
                    Console.WriteLine($"{items.Title}{items.Author.Name}");
                }

            }

        }

        private static void Exercise13_1_3() {
            using(var db = new BooksDbContext()) {

                var books = db.Books.Where(a => a.Title.Length == db.Books.Max(x => x.Title.Length));
                foreach(var items in books) {
                    Console.WriteLine($"{items.Title}{items.PublishedYear}{items.Author.Name}");
                }

            }
        }

        static void Exercise13_1_2_2() {
            using(var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1992,
                    Author = author1,
               
                };
                db.Books.Add(book1);




                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);



                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book3);


                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();


            }
        }
        private static void Exercise13_1_1() {
            using(var db = new BooksDbContext()) {

                var Auhtor1 = new Author {

                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "男性",
                    Name = "川端康成",

                };

                db.Authors.Add(Auhtor1);


                var Author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "男性",
                    Name = "菊池寛",

                };

                db.Authors.Add(Author2);
                db.SaveChanges();//データべースの更新

            }

        }




        //データーの追加

        //  AddAuthors();
        //  AddBooks();
        //DisplayAllBooks();     
        // UpdateBook();
        // DeleteBook();

        //using(var db = new BooksDbContext()) {
        //    var authors = db.Authors.Where(a => a.Books.Count() >= 2)
        //   foreach(var author in authors) {
        //        ($"{book.Title}{author.Gender} {author.Birthday }");

        //    }

        //}


        //using(var db = new BooksDbContext()) {
        //    var books = db.Books.OrderBy(b => b.PublishedYear)
        //    .ThenBy(b => b.Author.Name).ToList();
        //    foreach(var book in books) {
        //        Console.WriteLine($"{book.Title}{book.PublishedYear } {book.Author.Name }");
        //    }
        //        //}
        //        using(var db = new BooksDbContext()) {
        //        var groups = db.Books.GroupBy(b => b.PublishedYear).Select(g => new {
        //            Year = g.Key,
        //            Count = g.Count()
        //        });
        //        foreach(var g in groups) {
        //            Console.WriteLine($"{g.Year}{g.Count} ");
        //        }
        //    }
        //}

        private static void DeleteBook() {
            using(var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if(book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }


            }
        }


        //13_11
        private static void UpdateBook() {
            using(var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }

        }
        //13_5








        //13_7
        static IEnumerable<Book> GetBooks() {

            using(var db = new BooksDbContext()) {
                return db.Books.Where(book => book.Author.Name.StartsWith("夏目")).ToList();




            }
        }
        static void DisplayAllBooks() {
            var books = GetBooks();
            foreach(var book in books) {
                Console.WriteLine($"{book.Title}{book.PublishedYear}");
            }

            Console.WriteLine();//F5で実行後、一時停止させる


        }

    }
}

