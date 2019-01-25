using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Deluxes.Models
{
    public class DeluxesInitializer:DropCreateDatabaseAlways<DeluxesContext>
   {
        protected override void Seed(DeluxesContext context)
        {
            List<Category> kategorier = new List<Category>()
            {
                new Category(){Name="Soffor"},
                new Category(){Name="Bord"},
                new Category(){Name="Mattor"},
                new Category(){Name="Sängar"},
                new Category(){Name="Stolar"},
                new Category(){Name="Kök"},
            };

            foreach(var item in kategorier)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Product> producter = new List<Product>()
            {
                new Product(){Name="STI Stol",Image="stolar2.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=6500,CategoryId=1},
                new Product(){Name="STI Bord",Image="mabord2.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=2500,CategoryId=2},
                new Product(){Name="STI Sängar",Image="sang2.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=12500,CategoryId=4},
               
                new Product(){Name="STI Mattor",Image="carpet2.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=1500,CategoryId=3},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=6500,CategoryId=1},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,isHome=true,Price=6500,CategoryId=1},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=2},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=2},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=3},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=3},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=4},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=4},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=5},
                new Product(){Name="STI Soffa",Image="soffor1.jpg",Description="Ett riktigt blickfång med skräddade klädslar, med olika texturer, sydda med veck och kantband.",isApproved=true,isFeatured=true,Price=6500,CategoryId=5}


       };

            foreach (var item in producter)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}