using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Practices.ObjectBuilder2;
using PCLStorage;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Services;
using Reactive.Bindings;
using Realms;
using TOD2017MobileApp.Models;

namespace TOD2017MobileApp.ViewModels
{
    enum DataClass
    {
        AltitudeDarum,
        GraphDatum,
        SemanticLink,
        Efficiency,
        EfficiencyMax
    }

    public class DataInsertionPageViewModel : BindableBase
    {
        private static readonly string RootFolderPath = "/sdcard/Download";
        private readonly IPageDialogService _pageDialogService;

        public DelegateCommand InsertAltitudeDetumCommand { get; set; }
        public DelegateCommand InsertGraphDatumCommand { get; set; }
        public DelegateCommand InsertEfficienctyDatumCommand { get; set; }
        public DelegateCommand InsertEfficienctyMaxDatumCommand { get; set; }
        public DelegateCommand InsertSemanticLinkCommand { get; set; }
        public ReactiveProperty<string> FileName { get; set; }
        public ReactiveProperty<string> FilePath { get; set; }
        public ReactiveProperty<string> FileText { get; set; }
        public DataInsertionPageViewModel(IPageDialogService pageDialogService)
        {
            _pageDialogService = pageDialogService;
            FileName = new ReactiveProperty<string>();
            FilePath = new ReactiveProperty<string>();
            FileText = new ReactiveProperty<string>();

            InsertAltitudeDetumCommand = new DelegateCommand(async () =>
            {
                await CheckPermissionAsync();
                await InsertDataAsync(DataClass.AltitudeDarum);
            });

            InsertGraphDatumCommand = new DelegateCommand(async () =>
            {
                await CheckPermissionAsync();
                await InsertDataAsync(DataClass.GraphDatum);
            });

            InsertSemanticLinkCommand = new DelegateCommand(async () =>
            {
                await CheckPermissionAsync();
                await InsertDataAsync(DataClass.SemanticLink);
            });

            InsertEfficienctyDatumCommand = new DelegateCommand(async () =>
            {
                await CheckPermissionAsync();
                await InsertDataAsync(DataClass.Efficiency);
            });

            InsertEfficienctyMaxDatumCommand = new DelegateCommand(async () =>
            {
                await CheckPermissionAsync();
                await InsertDataAsync(DataClass.EfficiencyMax);
            });
        }

        private async Task CheckPermissionAsync()
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
            if (status != PermissionStatus.Granted)
            {
                if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Storage))
                {
                    await _pageDialogService.DisplayAlertAsync("Need storage accesss", "Gunna need that storage access", "OK");

                }
                await CrossPermissions.Current.RequestPermissionsAsync(Permission.Storage);
            }
        }

        private async Task InsertDataAsync(DataClass dataClass)
        {
            var rootFolder = await FileSystem.Current.GetFolderFromPathAsync(RootFolderPath);
            var file = await rootFolder.GetFileAsync(FileName.Value);

            FilePath.Value = file.Path;
            FileText.Value = "Start ...";

            using (var reader = new StreamReader(await file.OpenAsync(FileAccess.Read)))
            {
                using (var realm = Realm.GetInstance())
                {
                    realm.Write(() =>
                    {
                        while (!reader.EndOfStream)
                        {
                            var values = reader.ReadLine().Split(',');

                            switch (dataClass)
                            {
                                case DataClass.AltitudeDarum:

                                    realm.Add(new AltitudeDatum
                                    {
                                        LowerLatitude = double.Parse(values[0]),
                                        LowerLongitude = double.Parse(values[1]),
                                        UpperLatitude = double.Parse(values[2]),
                                        UpperLongitude = double.Parse(values[3]),
                                        Altitude = double.Parse(values[4])
                                    });

                                    break;
                                case DataClass.GraphDatum:

                                    realm.Add(new GraphDatum
                                    {
                                        SemanticLinkId = int.Parse(values[0]),
                                        TripId = int.Parse(values[1]),
                                        Date = DateTimeOffset.Parse(values[2]),
                                        TransitTime = int.Parse(values[3]),
                                        ConsumedElectricEnergy = float.Parse(values[4]),
                                        LostEnergy = float.Parse(values[5]),
                                        RegeneLoss = float.Parse(values[6]),
                                        ConvertLoss = float.Parse(values[7]),
                                        RollingResistance = float.Parse(values[8]),
                                        AirResistance = float.Parse(values[9])
                                    });
                                    break;
                                case DataClass.Efficiency:

                                    realm.Add(new EfficiencyDatum
                                    {
                                        Torque = int.Parse(values[0]),
                                        Rev = int.Parse(values[1]),
                                        Efficiency = int.Parse(values[2])
                                    });

                                    break;
                                case DataClass.EfficiencyMax:

                                    realm.Add(new EfficiencyMaxDatum
                                    {
                                        Torque = int.Parse(values[0]),
                                        Rev = int.Parse(values[1]),
                                        Efficiency = int.Parse(values[2])
                                    });

                                    break;
                            }
                        }
                    });
                }
            }
            FileText.Value = "Finish!!";
        }
    }
}
