using Orchard.ContentManagement.Metadata.Settings;
using Orchard.ContentManagement.MetaData;
using Orchard.Data.Migration;

namespace Orchard.Media
{
    public class Migrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public Migrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterTypeDefinition("Image", builder => builder
                .Creatable()
                .Listable(false)
                .Draftable(false)
                .WithPart("TitlePart")
                .WithPart("ImagePart")
                .Stereotype("Media"));

            return 1;
        }
    }
}