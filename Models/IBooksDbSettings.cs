namespace MongoDbBooks.Models
{
    public interface IBooksDbSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
