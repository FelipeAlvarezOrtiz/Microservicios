﻿namespace AuctionService.Entities
{
    public sealed class Item
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImageUrl { get; set; }

        //nav prop
        public Auction Auction { get; set; }
        public Guid AuctionId { get; set; } 
    }
}
