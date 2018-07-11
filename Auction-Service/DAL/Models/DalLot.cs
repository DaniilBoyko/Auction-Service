using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    /// <summary>
    /// Model represet lot on the auction.
    /// </summary>
    public class DalLot
    {
        /// <summary>
        /// Gets or sets lot id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets lot name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets lot description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets start lot price.
        /// </summary>
        public double StartPrice { get; set; }
    }
}
