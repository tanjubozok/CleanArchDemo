using Bogus;
using CleanArchDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchDemo.Infrastructure.Seeds;

public class VillaSeed : IEntityTypeConfiguration<Villa>
{
    public void Configure(EntityTypeBuilder<Villa> builder)
    {
        var villaFaker = new Faker<Villa>()
            .RuleFor(v => v.Id, f => f.IndexFaker + 1)
            .RuleFor(v => v.Name, f => f.Company.CompanyName() + " Villa")
            .RuleFor(v => v.Description, f => f.Lorem.Sentence())
            .RuleFor(v => v.Price, f => f.Random.Double(100, 5000))
            .RuleFor(v => v.Sqft, f => f.Random.Int(500, 5000))
            .RuleFor(v => v.Occupancy, f => f.Random.Int(1, 10))
            .RuleFor(v => v.ImageUrl, f => f.Image.PicsumUrl())
            .RuleFor(v => v.CreatedDate, f => f.Date.Past(2))
            .RuleFor(v => v.UpdatedDate, (f, v) => v.CreatedDate?.AddDays(f.Random.Int(1, 30)));

        List<Villa> villas = villaFaker.Generate(10);

        builder.HasData(villas);
    }
}
