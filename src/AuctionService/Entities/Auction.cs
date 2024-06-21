using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
    [Table("Auctions")]
    public sealed class Auction
    {
        public Guid Id { get; set; }
        public int ReservePrice { get; set; } = 0;
        public string Seller { get; set; }
        public string? Winner { get; set; } = string.Empty;
        public int? SoldAmount { get; set; }
        public int? CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; }
        public Item Item { get; set; }
    }
}
