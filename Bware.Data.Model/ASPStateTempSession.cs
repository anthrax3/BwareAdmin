namespace Bware.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASPStateTempSession
    {
        [Key]
        [StringLength(88)]
        public string SessionId { get; set; }

        public DateTime Created { get; set; }

        public DateTime Expires { get; set; }

        public DateTime LockDate { get; set; }

        public DateTime LockDateLocal { get; set; }

        public int LockCookie { get; set; }

        public int Timeout { get; set; }

        public bool Locked { get; set; }

        [MaxLength(7000)]
        public byte[] SessionItemShort { get; set; }

        [Column(TypeName = "image")]
        public byte[] SessionItemLong { get; set; }

        public int Flags { get; set; }
    }
}
