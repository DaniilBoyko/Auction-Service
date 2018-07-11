using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    /// <summary>
    /// Model represent auction.
    /// </summary>
    public class DalAuction
    {
        /// <summary>
        /// Gets or sets auction id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the auctioin.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets auction start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets auction end date.
        /// </summary>
        public DateTime EndDate { get; set; }
        
        /// <summary>
        /// Gets or sets auction lots.
        /// </summary>
        public List<DalLot> Lots { get; set; }
    }
}
