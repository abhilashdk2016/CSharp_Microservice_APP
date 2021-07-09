using System;
namespace Catalog.API.Settings
{
    public interface ICatalogDBSettings
    {
        string CollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
