using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data.Items;
using Sitecore.ExperienceForms.Mvc.Constants;

namespace Sitecore.Support.ContentSearch.ComputedFields
{
  public class FormName : AbstractComputedIndexField
  {
    public override object ComputeFieldValue(IIndexable indexable)
    {
      Item item = indexable as SitecoreIndexableItem;
      if (item != null && item.TemplateID == TemplateIds.FormTemplateId)
      {
        return item.Name.ToLower();
      }
      return null;
    }
  }
}