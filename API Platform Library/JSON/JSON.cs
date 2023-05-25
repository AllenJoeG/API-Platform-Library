using Newtonsoft.Json;
using JsonNet.ContractResolvers;
using API_Platform_Library.Models.Tarot;
using Microsoft.EntityFrameworkCore;
using API_Platform_Library.DAL;

namespace API_Platform_Library.JSON
{
    public class JSON
    {

        public static string ReadJsonToString(string filepath)
        {
            filepath = Path.GetFullPath(filepath);

            var jsonData = File.ReadAllText(filepath);

            return jsonData;
        }

        public static void SeedJsonToContext(string jsonData, IServiceProvider serviceProvider)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new PrivateSetterContractResolver()
            };

            List<EkelenSchema> ekelen =
            JsonConvert.DeserializeObject<List<EkelenSchema>>(jsonData, settings);

            using (var serviceScope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<ApiPlatformContext>();

                if (!context.Ekelen.Any())
                {
                    context.AddRange(ekelen);
                    context.SaveChanges();
                }
            }
        }
    }
}
