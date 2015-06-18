using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.GeographicFeatures.Streets;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IAddressRangeProvider
    {
        AddressRange GetAddresses(StreetAddress address, int from, int to);
    }
}
