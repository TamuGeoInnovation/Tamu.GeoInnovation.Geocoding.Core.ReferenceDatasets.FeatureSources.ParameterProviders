using USC.GISResearchLab.Common.Addresses;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface ILotNumberProvider
    {
        int GetLotNumber(StreetAddress address, int from, int to);
    }
}
