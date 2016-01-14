namespace Bware.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bridge
    {
        public int BridgeId { get; set; }

        public string BIN { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DbGeography BridgeLocation { get; set; }

        public string FeatureCarried { get; set; }

        public string FeatureCrossed { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public string Township { get; set; }

        public string Zip { get; set; }

        public double? Height { get; set; }

        public double? WeightStraight { get; set; }

        public double? WeightCombination { get; set; }

        public bool isRposted { get; set; }

        public string OtherPosting { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string UserCreated { get; set; }

        public string UserModified { get; set; }

        public int NumberOfVotes { get; set; }

        public bool isLocked { get; set; }

        public string LocationDescription { get; set; }

        public string Country { get; set; }

        public double? WeightDouble { get; set; }

        public string User1Verified { get; set; }

        public string User2Verified { get; set; }

        public string User3Verified { get; set; }

        public bool? User1Reason { get; set; }

        public bool? User2Reason { get; set; }

        public bool? User3Reason { get; set; }

        public bool isActive { get; set; }

        public double? WeightStraight_TriAxle { get; set; }
    }
}
