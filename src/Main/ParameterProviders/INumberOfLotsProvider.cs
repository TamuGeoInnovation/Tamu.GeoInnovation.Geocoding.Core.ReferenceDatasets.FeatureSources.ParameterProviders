using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.GeographicFeatures.Streets;

namespace USC.GISResearchLab.Geocoding.Algorithms.FeatureInterpolationMethods.Interfaces
{
    public interface INumberOfLotsProvider
    {
        int GetNumberOfLots(StreetAddress address, Street street);
    }
}
