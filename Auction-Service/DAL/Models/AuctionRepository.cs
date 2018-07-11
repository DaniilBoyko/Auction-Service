using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Models
{
    /// <summary>
    /// Represent auction repository.
    /// </summary>
    public class AuctionRepository : IAuctionRepository
    {
        /// <summary>
        /// Store auction context.
        /// </summary>
        private readonly AuctionContext _context;

        /// <summary>
        /// Constructor create new instance of the <see cref="AuctionRepository"/> class.
        /// </summary>
        /// <param name="context">Auction context.</param>
        public AuctionRepository(AuctionContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        /// <summary>
        /// Dispose auction repository.
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Gets all auctions.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DalAuction> GetAll()
        {
        }

        public DalAuction GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(DalAuction element)
        {
            throw new NotImplementedException();
        }

        public void InsertAll(IEnumerable<DalAuction> elements)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(DalAuction element)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
