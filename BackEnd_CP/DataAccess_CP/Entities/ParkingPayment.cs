namespace DataAccess_CP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParkingPayment")]
    public partial class ParkingPayment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parking_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string payment_per_time_unit { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int time_unit { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int currency { get; set; }

        public virtual ParkingPlace ParkingPlace { get; set; }
    }
}
