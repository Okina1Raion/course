namespace DataAccess_CP.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParkingHistory")]
    public partial class ParkingHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parking_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int drone_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime date { get; set; }

        public TimeSpan? time_from { get; set; }

        public TimeSpan? time_to { get; set; }

        [Key]
        [Column(Order = 3)]
        public float total_cost { get; set; }

        public virtual Drone Drone { get; set; }

        public virtual ParkingPlace ParkingPlace { get; set; }
    }
}
