using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.Geometries;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IGeometryProvider
    {
        Geometry GetGeometry(StreetAddress address, int width, int height);
    }
}
