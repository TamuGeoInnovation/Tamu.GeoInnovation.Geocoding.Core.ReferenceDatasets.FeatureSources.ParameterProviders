using USC.GISResearchLab.Common.Addresses;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IAddressValidationProvider
    {
        bool ValidateAddress(StreetAddress address);
    }
}
