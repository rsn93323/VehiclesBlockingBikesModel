using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace BackendApi.Data.Models
{
    [Table("Vehicles")]
    [Index(nameof(Type))]
    [Index(nameof(State))]
    [Index(nameof(VehicleMovement))]
    public class Vehicle
    {
        #region Properties
        /// <summary>
        /// The unique id and primary key for this vehicle
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// vehicle_type (in UTF8 format)
        /// </summary>
        public string Type { get; set; } = null!;

        /// <summary>
        ///  plate_state
        /// </summary>
        public string State { get; set; } = null!;


        /// <summary>
        /// vehicle_movement
        /// </summary>
        public string VehicleMovement { get; set; } = null!;


        /// <summary>
        /// Address Id (foreign key)
        /// </summary>
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        #endregion

        #region Navigation Properties
        /// <summary>
        /// The address related to this vehicle.
        /// </summary>
        public Address? Address { get; set; } = null!;
        #endregion
    }
}
