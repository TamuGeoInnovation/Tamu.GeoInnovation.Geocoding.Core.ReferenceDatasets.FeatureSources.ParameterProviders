using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.GeoreferencedImages;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IImageProvider
    {
        GeoreferencedImage GetImage(StreetAddress address, int width, int height, double resolution);
    }
}
