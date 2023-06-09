using Microsoft.AspNetCore.Mvc;
using WishLists;
using Google.Cloud.Firestore;


namespace WishListsController
{
    [Route("app/wishlists")]
    [ApiController]
    public class WishlistsController : ControllerBase
    {
        //Listing Every Whishlist
        [HttpGet]
        [Consumes("application/json")]
        public async Task<ActionResult<IEnumerable<WishList>>> Get()
        {
            Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
            string projectId = "projeto-upik";
            FirestoreDb db = FirestoreDb.Create(projectId);

            Query wishListQuery = db.Collection("wishlists");
            QuerySnapshot snapshot = await wishListQuery.GetSnapshotAsync();

            List<WishList> wishlists = new List<WishList>();
            foreach (DocumentSnapshot documentSnapshot in snapshot.Documents)
            {
                WishList wishlist = documentSnapshot.ConvertTo<WishList>();
                wishlists.Add(wishlist);
            }

            return Ok(wishlists);
        }


    }

}
