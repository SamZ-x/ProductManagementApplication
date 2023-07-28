/*
 * Automapper configuration 
 * File: MappingConfiguration.cs
 * Author: Sam
 */

namespace ProductManagementApp.DataUtility
{
    using AutoMapper;

    public class MappingConfiguration
    {
        public static MapperConfiguration Configuration()
        {
            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<RegisterProfile>();
                config.AddProfile<UserProfile>();
            });

            return configuration;
        }
    }
}
