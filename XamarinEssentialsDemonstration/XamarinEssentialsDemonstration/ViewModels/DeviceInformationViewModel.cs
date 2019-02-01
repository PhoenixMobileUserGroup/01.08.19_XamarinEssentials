using System;
using Xamarin.Essentials;

namespace XamarinEssentialsDemonstration.ViewModels
{
    public class DeviceInformationViewModel : ViewModelBase
    {
        public string DeviceModel { get; set; }
        public string Manufacturer { get; set; }
        public string DeviceName { get; set; }
        public string Version { get; set; }
        public string Platform { get; set; }
        public string Idiom { get; set; }
        public string DeviceType { get; set; }

        public DeviceInformationViewModel()
        {
            DeviceModel = DeviceInfo.Model;
            Manufacturer = DeviceInfo.Manufacturer;
            DeviceName = DeviceInfo.Name;
            Version = DeviceInfo.VersionString;
            Platform = DeviceInfo.Platform.ToString();
            Idiom = DeviceInfo.Idiom.ToString();
            DeviceType = Enum.GetName(typeof(DeviceType), DeviceInfo.DeviceType);
        }
    }
}
