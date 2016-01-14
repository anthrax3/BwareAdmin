namespace Bware.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Message
    {
        public int MessageId { get; set; }

        public DbGeography MessageLocation { get; set; }

        public string MessageText { get; set; }

        public string UserCreated { get; set; }

        public DateTime DateCreated { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
