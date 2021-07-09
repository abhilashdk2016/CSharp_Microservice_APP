using System;
namespace Catalog.API.Settings
{
    public class CatalogDBSettings : ICatalogDBSettings
    {
        public CatalogDBSettings()
        {
        }

        public string CollectionName { get; set; }
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
