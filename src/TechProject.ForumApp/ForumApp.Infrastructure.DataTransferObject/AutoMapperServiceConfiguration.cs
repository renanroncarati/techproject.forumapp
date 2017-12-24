using AutoMapper;
using ForumApp.Infrastructure.DataTransferObject.Mappings;
using System.Linq;

namespace ForumApp.Infrastructure.DataTransferObject
{
    public class AutoMapperServiceConfiguration
    {
        public static void Configure()
        {
            //var profiles = typeof(UserMapping).Assembly.GetTypes().Where(t => typeof(Profile).IsAssignableFrom(t));
            //Mapper.Initialize(m => m.AddProfiles(profiles));

            Mapper.Initialize(m =>
            {
                m.AddProfile<PostMapping>();
                m.AddProfile<UserMapping>();
                m.AddProfile<TopicMapping>();
            });
        }

        public static void AssertConfigurationIsValid()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}
