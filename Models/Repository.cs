using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {

        private static List<Listing> listings = new List<Listing>();

        private static int id = 0;

        public static IEnumerable<Listing> Listings {
            get {
                return listings;
            }
        }

        public static void updateId() {
            //increment the id by 1 
            id += 1;
        }

        public static void AddListing(Listing listing) {

            //update the id of the listing 
            updateId();
            listing.Id = id;
            listings.Add(listing);
        }
        
    }
}

