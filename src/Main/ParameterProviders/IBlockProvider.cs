using USC.GISResearchLab.Common.Addresses;
using USC.GISResearchLab.Common.GeographicFeatures.Streets;

namespace USC.GISResearchLab.Common.Geocoders.InterpolationAlgorithms.ParameterProviders
{
    public interface IBlockProvider
    {

        //IFeatureSource FeatureSource
        //{
        //    get;
        //    set;
        //}

        ParcelCombination CalculateError(int comboId, Street street1, Street street2, Street street3, Street street4, int corner1Facing, int corner2Facing, int corner3Facing, int corner4Facing);

        Block GetBlock(string polyline, int sourceId, string source, ValidateableStreetAddress address, AddressRange addressRange, string fromAddressLeft, string toAddressLeft, string fromAddressRight, string toAddressRight, string parcelDirectionstring);

        bool IsRectangular(string polyline, int sourceId, string source, string fromAddressLeft, string toAddressLeft, string fromAddressRight, string toAddressRight, ValidateableStreetAddress address);

        ParcelCombination GetBestCombination(ParcelCombination[] parcelCombinations);

        ParcelCombination ComputeBestCombination(string polyLinestring, string source, string sourceId, string fromAddressLeft, string toAddressLeft, string fromAddressRight, string toAddressRight, double roadWidth, string street1Info, string street1addressParcels, string street2Info, string street2addressParcels, string street3Info, string street3addressParcels, string street4Info, string street4addressParcels, ValidateableStreetAddress address);

        ParcelCombination ComputeBestCombination();
    }
}
