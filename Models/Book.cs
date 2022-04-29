using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbBooks.Models
{
    public class Book
    {
        [BsonId] //Makes this property primary key.
        [BsonRepresentation(BsonType.ObjectId)] //allows passing the Id as string instead of ObjectId
        public string Id { get; set; }
        [BsonElement("Name")] //This propery is represented as Name in Mongo Db, not Title.
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
