using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.Linq;
using WEBAPI.Domain.Entities;
using WEBAPI.Infra.Data;

namespace WEBAPI.Infra
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDBContext>());
            }
        }

        public static void SeedData(AppDBContext dbContext)
        {
            System.Console.WriteLine("Appling Migrations");
            dbContext.Database.Migrate();

        }
    }
}
