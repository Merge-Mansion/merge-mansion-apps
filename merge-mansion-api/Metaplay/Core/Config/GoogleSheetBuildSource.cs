using Metaplay.Core.Model;
using Metaplay.Core.Forms;
using System;

namespace Metaplay.Core.Config
{
    [MetaSerializableDerived(101)]
    public class GoogleSheetBuildSource : GameConfigBuildSource
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        [MetaFormDisplayProps("Google Spreadsheet Name", DisplayHint = "Name of the Google Spreadsheet to use as a data source.", DisplayPlaceholder = "Enter Google Spreadsheet Name")]
        public string Name { get; set; }

        [MetaFormFieldCustomValidator(typeof(GoogleSheetsIdValidator))]
        [MetaFormDisplayProps("Google Spreadsheet ID", DisplayHint = "ID of the Google Spreadsheet to use as a data source.", DisplayPlaceholder = "Enter Google Spreadsheet ID")]
        [MetaMember(2, (MetaMemberFlags)0)]
        public string SpreadsheetId { get; set; }
        public override string DisplayName { get; }

        private GoogleSheetBuildSource()
        {
        }

        public GoogleSheetBuildSource(string name, string spreadsheetId)
        {
        }
    }
}