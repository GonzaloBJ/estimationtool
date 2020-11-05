using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Api.Entities;
using Microsoft.Extensions.Logging;

namespace Api.Data
{
    public class EstimationToolContextSeed
    {
        public static async System.Threading.Tasks.Task SeedAsync(EstimationToolContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.PartType.Any())
                {
                    var partTypesData = 
                        File.ReadAllText("../Data/SeedData/PartType.json");

                    var types = JsonSerializer.Deserialize<List<PartType>>(partTypesData);

                    foreach (var item in types)
                    {
                        var newType = new PartType(){Name = item.Name};
                        context.PartType.Add(newType);
                    }

                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<EstimationToolContextSeed>();
                logger.LogError(ex.InnerException.Message);
            }
        }
    }
}