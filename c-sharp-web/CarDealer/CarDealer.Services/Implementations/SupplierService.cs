﻿namespace CarDealer.Services.Implementations
{
    using CarDealer.Data;
    using CarDealer.Services.Models.Suppliers;
    using System.Collections.Generic;
    using System.Linq;

    public class SupplierService : ISupplierService
    {
        private readonly CarDealerDbContext db;

        public SupplierService(CarDealerDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<SupplierModel> All()
            => this.db
            .Suppliers
            .OrderBy(s => s.Name)
            .Select(s => new SupplierModel
            {
                Id = s.Id,
                Name = s.Name
            })
            .ToList();

        public IEnumerable<SupplierListingModel> AllListing(bool isImporter)
        {
            return this.db
                .Suppliers
                .OrderByDescending(s => s.Id)
                .Where(s => s.IsImporter == isImporter)
                .Select(s => new SupplierListingModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    TotalParts = s.Parts.Count
                })
                .ToList();
        }
    }
}
