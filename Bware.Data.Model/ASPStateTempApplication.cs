namespace Bware.Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASPStateTempApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppId { get; set; }

        [Required]
        [StringLength(280)]
        public string AppName { get; set; }
    }
}
