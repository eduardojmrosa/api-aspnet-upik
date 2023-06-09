using Google.Cloud.Firestore;
using Products;

namespace WishLists
{
    [FirestoreData]
    public class WishList
    {

        [FirestoreProperty("user")]
        public string User { get; set; }

        [FirestoreProperty("products")]
        public List<Product> Products { get; set; }
    }
}
