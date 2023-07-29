using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubExampleCoreProject.Areas.Admin.Models
{
    public class BookingHotelSearchViewModel
    {
        public int count { get; set; }
        public MapPageFields mapPageFields { get; set; }
        public Results[] results { get; set; }


        public class MapPageFields
        {
            public BoundingBox boundingBox { get; set; }
            public PropertyAnnotations[] propertyAnnotations { get; set; }
        }

        public class BoundingBox
        {
            public double swLat { get; set; }
            public double swLon { get; set; }
            public double neLon { get; set; }
            public double neLat { get; set; }
        }

        public class PropertyAnnotations
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Results
        {
            public int id { get; set; }
            public string? name { get; set; }
            public int mainPhotoId { get; set; }
            public string? photoMainUrl { get; set; }
            public string[]? photoUrls { get; set; }
            public int position { get; set; }
            public int rankingPosition { get; set; }
            public string? countryCode { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public PriceBreakdown? priceBreakdown { get; set; }
            public string? currency { get; set; }
            public Checkin? checkin { get; set; }
            public Checkout? checkout { get; set; }
            public string? checkoutDate { get; set; }
            public string? checkinDate { get; set; }
            public double reviewScore { get; set; }
            public string? reviewScoreWord { get; set; }
            public int reviewCount { get; set; }
            public int qualityClass { get; set; }
            public bool isFirstPage { get; set; }
            public int accuratePropertyClass { get; set; }
            public int propertyClass { get; set; }
            public int ufi { get; set; }
            public string? wishlistName { get; set; }
            public int optOutFromGalleryChanges { get; set; }
        }

        public class PriceBreakdown
        {
            public StrikethroughPrice strikethroughPrice { get; set; }
            public GrossPrice grossPrice { get; set; }
            public object[] taxExceptions { get; set; }
            public BenefitBadges[] benefitBadges { get; set; }
        }

        public class StrikethroughPrice
        {
            public double value { get; set; }
            public string currency { get; set; }
        }

        public class GrossPrice
        {
            public string currency { get; set; }
            public double value { get; set; }
        }

        public class BenefitBadges
        {
            public string identifier { get; set; }
            public string text { get; set; }
            public string explanation { get; set; }
            public string variant { get; set; }
        }

        public class Checkin
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }

        public class Checkout
        {
            public string fromTime { get; set; }
            public string untilTime { get; set; }
        }
    }
}