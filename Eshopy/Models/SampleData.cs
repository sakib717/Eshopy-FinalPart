using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Eshopy.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EshopyContext>
    {
         protected override void Seed(EshopyContext context)
        {
            var types = new List<EshopyTypeModels>
            {
                new EshopyTypeModels { Name = "Cameras", Description="Capture the finest moments for the best", imageUrl="/Content/nikond500.jpg"},
                new EshopyTypeModels { Name = "Laptops", Description="The main Course", imageUrl="/Content/Asus.jpg"},
                new EshopyTypeModels { Name = "Tablets", Description="Something sweet that you have at the end.", imageUrl="/Content/Matebook.jpg" },
                new EshopyTypeModels { Name = "Phones", Description="Something to get your Appetite up", imageUrl="/Content/Cat.jpg"},
            };

            new List<EshopyItemModels>
            {
                new EshopyItemModels {Name = "Nikon D500",description="The Nikon D500 puts the company's finest autofocus system in a tough, compact SLR body that will please demanding enthusiasts and pros alike.", Price=1599M, EshopyType = types.Single(g => g.Name == "Cameras"), imgLink = "/Content/Images/nikond500.jpg" },
                new EshopyItemModels {Name = "Nikon D750", description="The Nikon D750 delivers pro-level performance at a reasonable asking price, making it our Editor's Choice for full-frame DSLRs under $2,500.", Price=1925M, EshopyType = types.Single(g => g.Name == "Cameras"), imgLink = "/Content/Images/nikond750.jpg" },
                new EshopyItemModels {Name = "Asus Chromebook Flip", description = "The Asus Chromebook Flip (C100PA-DB02) blends the best elements from other designs into a single Chrome-based laptop with a slick, convertible form factor, fast performance, all-day battery life, and an affordable price.", Price=799M, EshopyType= types.Single(g => g.Name == "Laptops"), imgLink = "/Content/Images/Acer.jpg" },
                new EshopyItemModels {Name = "Acer Aspire R 14", description ="The latest Acer Aspire R 14 convertible-hybrid laptop features a solid, versatile design, a 14-inch 1080p HD screen, strong performance, and excellent battery life.", Price=799M, EshopyType= types.Single(g => g.Name == "Laptops"), imgLink="/Content/Images/Asus.jpg" },
                new EshopyItemModels {Name = "Huawei Matebook", description="The Huawei MateBook (starts at $699; $999 as tested) is a midrange slate tablet that comes into its own once you snag a bevy of accessories.", Price=324M, EshopyType= types.Single(g => g.Name == "Tablets"), imgLink="/Content/Images/Matebook.png" },
                new EshopyItemModels {Name = "Cat 360", description="The unlocked Cat S60 ($599.99, 32GB) is one of the more unique rugged smartphones we've tested.", Price=599M, EshopyType= types.Single(g => g.Name == "Phones"), imgLink="/Content/Images/Cat.jpg" }

            }.ForEach(a => context.EshopyItems.Add(a));
    }
    }
}
