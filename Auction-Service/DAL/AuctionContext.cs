using System;
using System.Data.Entity;
using System.Linq;
using DAL.Models;


namespace DAL
{
    /// <summary>
    /// Model represet auction context.
    /// </summary>
    public class AuctionContext : DbContext
    {
        /// <summary>
        /// Constructr create new instance of the <see cref="AuctionContext"/> class.
        /// </summary>
        public AuctionContext(): base("name=AuctionContext")
        {
        }

        /// <summary>
        /// Gets or sets auction lots.
        /// </summary>
        public virtual DbSet<DalAuction> Auctions { get; set; }
    }
}