using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendApi.Data.Models
{
    [Table("Addresses")]
    [Index(nameof(Location))]
    [Index(nameof(Lat))]
    [Index(nameof(Lon))]
    public class Address
    {
        #region Properties
        /// <summary>
        /// The unique id and primary key for this address
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// location 
        /// </summary>
        public string Location { get; set; } = null!;

        /// <summary>
        /// address latitude
        /// </summary>
        
        public string Lat { get; set; } = null!;
        /// <summary>
        /// address longitude
        /// </summary>
        
        public string Lon { get; set; } = null!;

        #endregion

        #region Navigation Properties
        /// <summary>
        /// A collection of all the vehicles related to this address.
        /// </summary>
        public ICollection<Vehicle>? Vehicle { get; set; } = null!;
        #endregion
    }
}
