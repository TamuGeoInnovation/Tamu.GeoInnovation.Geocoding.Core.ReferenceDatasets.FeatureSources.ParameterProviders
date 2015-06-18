using USC.GISResearchLab.Common.Addresses;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IFeatureIdProvider
    {
        string GetFeatureId(StreetAddress address);
    }
}
