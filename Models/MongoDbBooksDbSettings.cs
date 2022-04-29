namespace MongoDbBooks.Models
{
    public class MongoDbBooksDbSettings : IBooksDbSettings
    {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set;  }
        public string DatabaseName { get; set; }
    }
}
