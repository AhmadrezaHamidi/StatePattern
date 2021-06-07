#region snippet_BookServiceClass
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using vestaabnerMonqo.Models;

namespace vestaabnerMonqo.Services
{
    public class BookService
    {

        // public string  { get ; set ; }
        // public string  { get ; set ; }
        private readonly IMongoCollection<Book> _books;
        private readonly IMongoCollection<Shelve> _Shelves;
        private readonly IMongoCollection<Librery> _Librerys;
        private readonly IMongoCollection<User> _Users;


        #region snippet_BookServiceConstructor
        public BookService(IBookDataBaseSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _books = database.GetCollection<Book>(settings?.BookCollectionName);
            _Shelves = database.GetCollection<Shelve>(settings.ShelveCollectionName);
            _Librerys = database.GetCollection<Librery>(settings.LibreryCollectionName);
            _Users = database.GetCollection<User>(settings.UserCollectionName);

        }
        #endregion

        public List<Book> GetBooks() =>
            _books.Find(book => true).ToList();
        public List<Shelve> GetShelves() =>
                   _Shelves.Find(Shelve => true).ToList();
        public List<Librery> GetLibrerys() =>
                   _Librerys.Find(Librery => true).ToList();
        public List<User> GetUsers() =>
                   _Users.Find(User => true).ToList();

        public Book GetBookByItemId(string id) =>
            _books.Find<Book>(book => book._id.ToString() == id).FirstOrDefault();
        public Shelve GetShelveByItemId(string id) =>
            _Shelves.Find<Shelve>(Sh => Sh._id.ToString() == id).FirstOrDefault();
        public Librery GetLibreryByItemId(string id) =>
            _Librerys.Find<Librery>(Librery => Librery._id.ToString() == id).FirstOrDefault();
        public User GetUserBuItemId(string id) =>
            _Users.Find<User>(User => User._id.ToString() == id).FirstOrDefault();

        public Book CreateBook(Book book)
        {
            _books.InsertOne(book);
            return book;
        }
        public Shelve CreateShelve(Shelve Shelve)
        {
            _Shelves.InsertOne(Shelve);
            return Shelve;
        }
        public Librery CreateLibrery(Librery Librery)
        {
            _Librerys.InsertOne(Librery);
            return Librery;
        }
        public User CreateUser(User User)
        {
            _Users.InsertOne(User);
            return User;
        }

        public void UpdateBook(string id, Book bookIn) =>
            _books.ReplaceOne(book => book._id.ToString() == id, bookIn);
        public void UpdateShelve(string id, Shelve ShelveIn) =>
                    _Shelves.ReplaceOne(Shelve => Shelve._id.ToString() == id, ShelveIn);
        public void UpdateLibrery(string id, Librery LibreryIn) =>
                    _Librerys.ReplaceOne(Librery => Librery._id.ToString() == id, LibreryIn);
        public void UpdateUser(string id, User UserIn) =>
                    _Users.ReplaceOne(User => User._id.ToString() == id, UserIn);

        public void RemoveBook(Book bookIn) =>
            _books.DeleteOne(book => book._id == bookIn._id);
        public void RemoveShelve(Shelve ShelveIn) =>
                  _Shelves.DeleteOne(Shelve => Shelve._id == ShelveIn._id);
        public void RemoveLibrery(Librery LibreryIn) =>
                  _Librerys.DeleteOne(Librery => Librery._id == LibreryIn._id);
        public void RemoveUser(User UserIn) =>
                  _Users.DeleteOne(User => User._id == UserIn._id);

    }
}
#endregion
