using Google.Cloud.Firestore;

namespace Products
{
    [FirestoreData]
    public class Product
    {
        [FirestoreProperty("uuid")]
        public string Uuid { get; set; }

        [FirestoreProperty("title")]
        public string Title { get; set; }

        [FirestoreProperty("url")]
        public string Url { get; set; }
    }
}
