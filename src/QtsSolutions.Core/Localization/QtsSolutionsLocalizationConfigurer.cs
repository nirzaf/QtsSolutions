using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace QtsSolutions.Localization
{
    public static class QtsSolutionsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(QtsSolutionsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(QtsSolutionsLocalizationConfigurer).GetAssembly(),
                        "QtsSolutions.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
