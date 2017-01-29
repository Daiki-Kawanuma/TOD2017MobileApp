using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator.Abstractions;

namespace TOD2017MobileApp.Test
{
    class TestPosition
    {
        public static int Index { get; set; } = 0;

        public static List<Position> TestPositions =
            new List<Position>
            {
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:02"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:03"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:04"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:06"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:07"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:08"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:09"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:10"),
                    Latitude = 35.43143369,
                    Longitude = 139.4139452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:11"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:12"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:13"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:14"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:15"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:16"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:17"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:18"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:19"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:20"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:21"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:22"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:23"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:24"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:25"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:26"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:27"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:28"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:29"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:30"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:31"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:32"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:33"),
                    Latitude = 35.43153543,
                    Longitude = 139.4139386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:34"),
                    Latitude = 35.43144484,
                    Longitude = 139.4138711
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:35"),
                    Latitude = 35.43144385,
                    Longitude = 139.4138705
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:36"),
                    Latitude = 35.43144196,
                    Longitude = 139.4138697
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:37"),
                    Latitude = 35.43144013,
                    Longitude = 139.4138691
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:38"),
                    Latitude = 35.43143866,
                    Longitude = 139.4138687
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:39"),
                    Latitude = 35.43143805,
                    Longitude = 139.4138681
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:40"),
                    Latitude = 35.43143821,
                    Longitude = 139.4138675
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:41"),
                    Latitude = 35.43143736,
                    Longitude = 139.4138671
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:42"),
                    Latitude = 35.43143593,
                    Longitude = 139.4138667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:43"),
                    Latitude = 35.43143476,
                    Longitude = 139.4138666
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:44"),
                    Latitude = 35.43143352,
                    Longitude = 139.4138665
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:45"),
                    Latitude = 35.43143263,
                    Longitude = 139.4138665
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:46"),
                    Latitude = 35.43143211,
                    Longitude = 139.4138666
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:47"),
                    Latitude = 35.43143172,
                    Longitude = 139.4138667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:48"),
                    Latitude = 35.4314336,
                    Longitude = 139.4138667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:49"),
                    Latitude = 35.43143633,
                    Longitude = 139.4138666
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:50"),
                    Latitude = 35.43143657,
                    Longitude = 139.4138666
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:51"),
                    Latitude = 35.43143762,
                    Longitude = 139.4138666
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:52"),
                    Latitude = 35.43143952,
                    Longitude = 139.4138667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:53"),
                    Latitude = 35.43144189,
                    Longitude = 139.4138667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:54"),
                    Latitude = 35.43144502,
                    Longitude = 139.4138669
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:55"),
                    Latitude = 35.43144865,
                    Longitude = 139.4138673
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:56"),
                    Latitude = 35.4314526,
                    Longitude = 139.4138676
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:57"),
                    Latitude = 35.43145694,
                    Longitude = 139.4138678
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:58"),
                    Latitude = 35.43146141,
                    Longitude = 139.4138676
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:29:59"),
                    Latitude = 35.43146631,
                    Longitude = 139.4138673
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:00"),
                    Latitude = 35.43147151,
                    Longitude = 139.4138671
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:01"),
                    Latitude = 35.43148014,
                    Longitude = 139.413867
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:02"),
                    Latitude = 35.43148474,
                    Longitude = 139.413867
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:03"),
                    Latitude = 35.43148917,
                    Longitude = 139.4138671
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:04"),
                    Latitude = 35.43149324,
                    Longitude = 139.4138671
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:05"),
                    Latitude = 35.43149677,
                    Longitude = 139.4138668
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:06"),
                    Latitude = 35.43149987,
                    Longitude = 139.4138664
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:07"),
                    Latitude = 35.43150277,
                    Longitude = 139.413866
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:08"),
                    Latitude = 35.43150519,
                    Longitude = 139.4138655
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:09"),
                    Latitude = 35.43150744,
                    Longitude = 139.4138651
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:10"),
                    Latitude = 35.43151142,
                    Longitude = 139.413865
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:11"),
                    Latitude = 35.43151494,
                    Longitude = 139.4138652
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:12"),
                    Latitude = 35.43151921,
                    Longitude = 139.4138656
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:13"),
                    Latitude = 35.43152364,
                    Longitude = 139.4138661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:14"),
                    Latitude = 35.43152775,
                    Longitude = 139.4138668
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:15"),
                    Latitude = 35.43153152,
                    Longitude = 139.4138676
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:16"),
                    Latitude = 35.43153482,
                    Longitude = 139.4138685
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:17"),
                    Latitude = 35.43153739,
                    Longitude = 139.4138692
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:18"),
                    Latitude = 35.43153944,
                    Longitude = 139.4138699
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:19"),
                    Latitude = 35.43154086,
                    Longitude = 139.4138703
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:20"),
                    Latitude = 35.43154189,
                    Longitude = 139.4138706
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:21"),
                    Latitude = 35.43154284,
                    Longitude = 139.4138708
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:22"),
                    Latitude = 35.4315437,
                    Longitude = 139.4138709
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:23"),
                    Latitude = 35.43154414,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:24"),
                    Latitude = 35.43154451,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:25"),
                    Latitude = 35.43154463,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:26"),
                    Latitude = 35.43154474,
                    Longitude = 139.4138711
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:27"),
                    Latitude = 35.43154465,
                    Longitude = 139.4138711
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:28"),
                    Latitude = 35.43154447,
                    Longitude = 139.4138711
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:29"),
                    Latitude = 35.43154412,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:30"),
                    Latitude = 35.43154404,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:31"),
                    Latitude = 35.43154401,
                    Longitude = 139.413871
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:32"),
                    Latitude = 35.43154426,
                    Longitude = 139.4138716
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:33"),
                    Latitude = 35.43154372,
                    Longitude = 139.4138726
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:34"),
                    Latitude = 35.43154427,
                    Longitude = 139.4138733
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:35"),
                    Latitude = 35.4315419,
                    Longitude = 139.4138736
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:36"),
                    Latitude = 35.43153643,
                    Longitude = 139.4138739
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:37"),
                    Latitude = 35.43153016,
                    Longitude = 139.4138737
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:38"),
                    Latitude = 35.43152043,
                    Longitude = 139.4138734
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:39"),
                    Latitude = 35.43151275,
                    Longitude = 139.4138733
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:40"),
                    Latitude = 35.43150578,
                    Longitude = 139.4138728
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:41"),
                    Latitude = 35.43150218,
                    Longitude = 139.4138723
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:42"),
                    Latitude = 35.43149768,
                    Longitude = 139.4138712
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:43"),
                    Latitude = 35.43149451,
                    Longitude = 139.4138696
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:44"),
                    Latitude = 35.43149167,
                    Longitude = 139.4138678
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:45"),
                    Latitude = 35.43148907,
                    Longitude = 139.4138657
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:46"),
                    Latitude = 35.43148822,
                    Longitude = 139.4138632
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:47"),
                    Latitude = 35.43148744,
                    Longitude = 139.4138608
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:48"),
                    Latitude = 35.43148791,
                    Longitude = 139.4138588
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:49"),
                    Latitude = 35.43149018,
                    Longitude = 139.4138571
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:50"),
                    Latitude = 35.43149463,
                    Longitude = 139.4138554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:51"),
                    Latitude = 35.43149821,
                    Longitude = 139.4138534
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:52"),
                    Latitude = 35.43149678,
                    Longitude = 139.4138508
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:53"),
                    Latitude = 35.43150629,
                    Longitude = 139.4138493
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:54"),
                    Latitude = 35.43150046,
                    Longitude = 139.4138392
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:55"),
                    Latitude = 35.4315016,
                    Longitude = 139.413841
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:56"),
                    Latitude = 35.43150653,
                    Longitude = 139.4138629
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:57"),
                    Latitude = 35.43151597,
                    Longitude = 139.4138934
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:58"),
                    Latitude = 35.43153645,
                    Longitude = 139.4139224
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:30:59"),
                    Latitude = 35.4315675,
                    Longitude = 139.4139372
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:00"),
                    Latitude = 35.43158475,
                    Longitude = 139.4139322
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:01"),
                    Latitude = 35.43160385,
                    Longitude = 139.4139246
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:02"),
                    Latitude = 35.43163302,
                    Longitude = 139.4139186
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:03"),
                    Latitude = 35.43166533,
                    Longitude = 139.4139143
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:04"),
                    Latitude = 35.43168879,
                    Longitude = 139.4139127
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:05"),
                    Latitude = 35.43169824,
                    Longitude = 139.4139104
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:06"),
                    Latitude = 35.43170614,
                    Longitude = 139.4139091
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:07"),
                    Latitude = 35.43170795,
                    Longitude = 139.4139085
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:08"),
                    Latitude = 35.43170891,
                    Longitude = 139.4139087
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:09"),
                    Latitude = 35.43170726,
                    Longitude = 139.4139107
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:10"),
                    Latitude = 35.43170855,
                    Longitude = 139.4139118
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:11"),
                    Latitude = 35.43171173,
                    Longitude = 139.413915
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:12"),
                    Latitude = 35.43171514,
                    Longitude = 139.413918
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:13"),
                    Latitude = 35.43171712,
                    Longitude = 139.4139227
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:14"),
                    Latitude = 35.43171932,
                    Longitude = 139.4139256
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:15"),
                    Latitude = 35.43172101,
                    Longitude = 139.4139272
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:16"),
                    Latitude = 35.43172165,
                    Longitude = 139.4139279
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:17"),
                    Latitude = 35.43172513,
                    Longitude = 139.4139279
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:18"),
                    Latitude = 35.43174259,
                    Longitude = 139.4139318
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:19"),
                    Latitude = 35.43177121,
                    Longitude = 139.4139593
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:20"),
                    Latitude = 35.43179541,
                    Longitude = 139.4139896
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:21"),
                    Latitude = 35.4318136,
                    Longitude = 139.414048
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:22"),
                    Latitude = 35.43182762,
                    Longitude = 139.4141184
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:23"),
                    Latitude = 35.43183533,
                    Longitude = 139.4141803
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:24"),
                    Latitude = 35.43184486,
                    Longitude = 139.4142473
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:25"),
                    Latitude = 35.43185537,
                    Longitude = 139.4143127
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:26"),
                    Latitude = 35.43186609,
                    Longitude = 139.4143832
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:27"),
                    Latitude = 35.43187738,
                    Longitude = 139.4144529
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:28"),
                    Latitude = 35.43188634,
                    Longitude = 139.4145243
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:29"),
                    Latitude = 35.43189385,
                    Longitude = 139.4145921
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:30"),
                    Latitude = 35.43190242,
                    Longitude = 139.4146606
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:31"),
                    Latitude = 35.43191089,
                    Longitude = 139.4147363
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:32"),
                    Latitude = 35.43191955,
                    Longitude = 139.4148118
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:33"),
                    Latitude = 35.43192884,
                    Longitude = 139.414889
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:34"),
                    Latitude = 35.43193972,
                    Longitude = 139.4149672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:35"),
                    Latitude = 35.43194979,
                    Longitude = 139.4150481
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:36"),
                    Latitude = 35.43195978,
                    Longitude = 139.4151297
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:37"),
                    Latitude = 35.43197048,
                    Longitude = 139.4152146
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:38"),
                    Latitude = 35.43198253,
                    Longitude = 139.4153071
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:39"),
                    Latitude = 35.43199576,
                    Longitude = 139.4154046
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:40"),
                    Latitude = 35.43200959,
                    Longitude = 139.4155054
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:41"),
                    Latitude = 35.43202347,
                    Longitude = 139.4156052
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:42"),
                    Latitude = 35.43203734,
                    Longitude = 139.4157067
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:43"),
                    Latitude = 35.43205079,
                    Longitude = 139.4158076
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:44"),
                    Latitude = 35.43206368,
                    Longitude = 139.415911
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:45"),
                    Latitude = 35.43207664,
                    Longitude = 139.4160141
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:46"),
                    Latitude = 35.43208888,
                    Longitude = 139.4161142
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:47"),
                    Latitude = 35.4321002,
                    Longitude = 139.4162047
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:48"),
                    Latitude = 35.43211131,
                    Longitude = 139.416279
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:49"),
                    Latitude = 35.4321203,
                    Longitude = 139.416333
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:50"),
                    Latitude = 35.43212976,
                    Longitude = 139.416375
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:51"),
                    Latitude = 35.43214851,
                    Longitude = 139.4164033
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:52"),
                    Latitude = 35.43217168,
                    Longitude = 139.4164157
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:53"),
                    Latitude = 35.43219999,
                    Longitude = 139.4164213
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:54"),
                    Latitude = 35.43224172,
                    Longitude = 139.4164162
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:55"),
                    Latitude = 35.43229399,
                    Longitude = 139.4164085
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:56"),
                    Latitude = 35.43235336,
                    Longitude = 139.416398
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:57"),
                    Latitude = 35.43241354,
                    Longitude = 139.4163867
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:58"),
                    Latitude = 35.43248306,
                    Longitude = 139.4163683
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:31:59"),
                    Latitude = 35.43255205,
                    Longitude = 139.4163485
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:00"),
                    Latitude = 35.43262604,
                    Longitude = 139.4163276
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:01"),
                    Latitude = 35.4327006,
                    Longitude = 139.4163068
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:02"),
                    Latitude = 35.43277456,
                    Longitude = 139.4162867
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:03"),
                    Latitude = 35.43284759,
                    Longitude = 139.4162714
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:04"),
                    Latitude = 35.43291717,
                    Longitude = 139.416257
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:05"),
                    Latitude = 35.43298307,
                    Longitude = 139.4162431
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:06"),
                    Latitude = 35.43304742,
                    Longitude = 139.4162311
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:07"),
                    Latitude = 35.43311275,
                    Longitude = 139.4162199
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:08"),
                    Latitude = 35.43318183,
                    Longitude = 139.4162078
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:09"),
                    Latitude = 35.43326979,
                    Longitude = 139.4161912
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:10"),
                    Latitude = 35.43336185,
                    Longitude = 139.4161742
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:11"),
                    Latitude = 35.43345746,
                    Longitude = 139.4161596
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:12"),
                    Latitude = 35.43355347,
                    Longitude = 139.4161454
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:13"),
                    Latitude = 35.43364614,
                    Longitude = 139.41613
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:14"),
                    Latitude = 35.43372657,
                    Longitude = 139.4161156
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:15"),
                    Latitude = 35.43379546,
                    Longitude = 139.4161044
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:16"),
                    Latitude = 35.43384972,
                    Longitude = 139.4161055
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:17"),
                    Latitude = 35.4338932,
                    Longitude = 139.4161161
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:18"),
                    Latitude = 35.43392362,
                    Longitude = 139.4161415
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:19"),
                    Latitude = 35.43394835,
                    Longitude = 139.4161747
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:20"),
                    Latitude = 35.43396375,
                    Longitude = 139.4162205
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:21"),
                    Latitude = 35.43398628,
                    Longitude = 139.4162961
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:22"),
                    Latitude = 35.43400928,
                    Longitude = 139.4163829
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:23"),
                    Latitude = 35.43402994,
                    Longitude = 139.4164857
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:24"),
                    Latitude = 35.43404924,
                    Longitude = 139.4165832
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:25"),
                    Latitude = 35.43406746,
                    Longitude = 139.4166791
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:26"),
                    Latitude = 35.43408316,
                    Longitude = 139.4167673
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:27"),
                    Latitude = 35.43409551,
                    Longitude = 139.416852
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:28"),
                    Latitude = 35.43410901,
                    Longitude = 139.4169333
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:29"),
                    Latitude = 35.43411951,
                    Longitude = 139.4170098
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:30"),
                    Latitude = 35.43412859,
                    Longitude = 139.4170847
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:31"),
                    Latitude = 35.43413466,
                    Longitude = 139.417156
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:32"),
                    Latitude = 35.43414097,
                    Longitude = 139.4172241
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:33"),
                    Latitude = 35.4341455,
                    Longitude = 139.4172942
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:34"),
                    Latitude = 35.43415202,
                    Longitude = 139.4173625
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:35"),
                    Latitude = 35.43415503,
                    Longitude = 139.4174171
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:36"),
                    Latitude = 35.43415771,
                    Longitude = 139.4174589
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:37"),
                    Latitude = 35.43415936,
                    Longitude = 139.4174865
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:38"),
                    Latitude = 35.43416065,
                    Longitude = 139.417506
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:39"),
                    Latitude = 35.43416153,
                    Longitude = 139.4175209
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:40"),
                    Latitude = 35.4341608,
                    Longitude = 139.4175267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:41"),
                    Latitude = 35.43416079,
                    Longitude = 139.4175267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:42"),
                    Latitude = 35.43416079,
                    Longitude = 139.4175267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:43"),
                    Latitude = 35.43416079,
                    Longitude = 139.4175267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:44"),
                    Latitude = 35.43416119,
                    Longitude = 139.417531
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:45"),
                    Latitude = 35.43416119,
                    Longitude = 139.417531
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:46"),
                    Latitude = 35.43416119,
                    Longitude = 139.417531
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:47"),
                    Latitude = 35.43416119,
                    Longitude = 139.417531
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:48"),
                    Latitude = 35.43416119,
                    Longitude = 139.417531
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:49"),
                    Latitude = 35.43416158,
                    Longitude = 139.4175364
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:50"),
                    Latitude = 35.43416261,
                    Longitude = 139.4175494
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:51"),
                    Latitude = 35.43416393,
                    Longitude = 139.4175667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:52"),
                    Latitude = 35.43416727,
                    Longitude = 139.4176038
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:53"),
                    Latitude = 35.43417103,
                    Longitude = 139.4176538
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:54"),
                    Latitude = 35.43417852,
                    Longitude = 139.4177088
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:55"),
                    Latitude = 35.43418566,
                    Longitude = 139.4177687
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:56"),
                    Latitude = 35.43419417,
                    Longitude = 139.4178395
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:57"),
                    Latitude = 35.43420157,
                    Longitude = 139.4179172
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:58"),
                    Latitude = 35.43420805,
                    Longitude = 139.4179971
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:32:59"),
                    Latitude = 35.43421539,
                    Longitude = 139.4180779
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:00"),
                    Latitude = 35.43422419,
                    Longitude = 139.4181648
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:01"),
                    Latitude = 35.43423343,
                    Longitude = 139.4182646
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:02"),
                    Latitude = 35.43424139,
                    Longitude = 139.4183747
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:03"),
                    Latitude = 35.43425012,
                    Longitude = 139.4184936
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:04"),
                    Latitude = 35.43425821,
                    Longitude = 139.4186149
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:05"),
                    Latitude = 35.43426663,
                    Longitude = 139.4187386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:06"),
                    Latitude = 35.43427577,
                    Longitude = 139.418868
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:07"),
                    Latitude = 35.43428546,
                    Longitude = 139.4190015
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:08"),
                    Latitude = 35.43429494,
                    Longitude = 139.4191394
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:09"),
                    Latitude = 35.43430411,
                    Longitude = 139.419275
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:10"),
                    Latitude = 35.43431319,
                    Longitude = 139.4194107
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:11"),
                    Latitude = 35.43432548,
                    Longitude = 139.41955
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:12"),
                    Latitude = 35.43433778,
                    Longitude = 139.4196845
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:13"),
                    Latitude = 35.43434685,
                    Longitude = 139.4198125
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:14"),
                    Latitude = 35.43435558,
                    Longitude = 139.4199354
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:15"),
                    Latitude = 35.43436676,
                    Longitude = 139.4200605
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:16"),
                    Latitude = 35.43437788,
                    Longitude = 139.4201843
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:17"),
                    Latitude = 35.43438885,
                    Longitude = 139.4203104
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:18"),
                    Latitude = 35.43439738,
                    Longitude = 139.4204389
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:19"),
                    Latitude = 35.43441066,
                    Longitude = 139.4205741
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:20"),
                    Latitude = 35.43442527,
                    Longitude = 139.4207251
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:21"),
                    Latitude = 35.43444508,
                    Longitude = 139.4208754
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:22"),
                    Latitude = 35.43446686,
                    Longitude = 139.4210185
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:23"),
                    Latitude = 35.43448539,
                    Longitude = 139.4211504
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:24"),
                    Latitude = 35.43450197,
                    Longitude = 139.4212775
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:25"),
                    Latitude = 35.43451447,
                    Longitude = 139.4213748
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:26"),
                    Latitude = 35.43452354,
                    Longitude = 139.4214467
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:27"),
                    Latitude = 35.43453005,
                    Longitude = 139.4214872
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:28"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:29"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:30"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:31"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:32"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:33"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:34"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:35"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:36"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:37"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:38"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:39"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:40"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:41"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:42"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:43"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:44"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:45"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:46"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:47"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:48"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:49"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:50"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:51"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:52"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:53"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:54"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:55"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:56"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:57"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:58"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:33:59"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:00"),
                    Latitude = 35.43453238,
                    Longitude = 139.4215053
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:01"),
                    Latitude = 35.43453509,
                    Longitude = 139.4215272
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:02"),
                    Latitude = 35.43454031,
                    Longitude = 139.4215643
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:03"),
                    Latitude = 35.43455494,
                    Longitude = 139.421643
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:04"),
                    Latitude = 35.43457487,
                    Longitude = 139.4217444
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:05"),
                    Latitude = 35.43459713,
                    Longitude = 139.4218483
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:06"),
                    Latitude = 35.43462039,
                    Longitude = 139.4219583
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:07"),
                    Latitude = 35.43465068,
                    Longitude = 139.4220845
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:08"),
                    Latitude = 35.43468607,
                    Longitude = 139.4222224
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:09"),
                    Latitude = 35.43472105,
                    Longitude = 139.4223596
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:10"),
                    Latitude = 35.43475486,
                    Longitude = 139.422489
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:11"),
                    Latitude = 35.43479272,
                    Longitude = 139.4226166
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:12"),
                    Latitude = 35.43483314,
                    Longitude = 139.4227434
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:13"),
                    Latitude = 35.43487576,
                    Longitude = 139.42287
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:14"),
                    Latitude = 35.43491997,
                    Longitude = 139.4229968
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:15"),
                    Latitude = 35.43496503,
                    Longitude = 139.4231242
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:16"),
                    Latitude = 35.43501185,
                    Longitude = 139.4232497
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:17"),
                    Latitude = 35.43505606,
                    Longitude = 139.4233696
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:18"),
                    Latitude = 35.43509766,
                    Longitude = 139.4234827
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:19"),
                    Latitude = 35.4351373,
                    Longitude = 139.4235908
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:20"),
                    Latitude = 35.43517784,
                    Longitude = 139.4237022
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:21"),
                    Latitude = 35.43522266,
                    Longitude = 139.423817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:22"),
                    Latitude = 35.4352679,
                    Longitude = 139.4239328
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:23"),
                    Latitude = 35.43531379,
                    Longitude = 139.4240536
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:24"),
                    Latitude = 35.43535992,
                    Longitude = 139.4241766
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:25"),
                    Latitude = 35.43540623,
                    Longitude = 139.4243004
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:26"),
                    Latitude = 35.43545382,
                    Longitude = 139.4244267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:27"),
                    Latitude = 35.4355011,
                    Longitude = 139.4245538
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:28"),
                    Latitude = 35.43554867,
                    Longitude = 139.4246805
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:29"),
                    Latitude = 35.43559656,
                    Longitude = 139.4248076
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:30"),
                    Latitude = 35.43564422,
                    Longitude = 139.4249352
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:31"),
                    Latitude = 35.43569009,
                    Longitude = 139.4250592
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:32"),
                    Latitude = 35.43573514,
                    Longitude = 139.4251814
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:33"),
                    Latitude = 35.43577926,
                    Longitude = 139.425302
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:34"),
                    Latitude = 35.43582227,
                    Longitude = 139.4254188
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:35"),
                    Latitude = 35.43586554,
                    Longitude = 139.4255335
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:36"),
                    Latitude = 35.43590832,
                    Longitude = 139.4256458
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:37"),
                    Latitude = 35.43594945,
                    Longitude = 139.4257572
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:38"),
                    Latitude = 35.43598694,
                    Longitude = 139.4258607
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:39"),
                    Latitude = 35.43602516,
                    Longitude = 139.4259637
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:40"),
                    Latitude = 35.43606178,
                    Longitude = 139.426061
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:41"),
                    Latitude = 35.43609322,
                    Longitude = 139.426145
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:42"),
                    Latitude = 35.4361174,
                    Longitude = 139.4262137
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:43"),
                    Latitude = 35.43613812,
                    Longitude = 139.4262696
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:44"),
                    Latitude = 35.4361558,
                    Longitude = 139.4263125
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:45"),
                    Latitude = 35.43616708,
                    Longitude = 139.4263421
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:46"),
                    Latitude = 35.43617617,
                    Longitude = 139.4263635
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:47"),
                    Latitude = 35.43618559,
                    Longitude = 139.4263867
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:48"),
                    Latitude = 35.43620269,
                    Longitude = 139.4264314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:49"),
                    Latitude = 35.4362249,
                    Longitude = 139.4264877
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:50"),
                    Latitude = 35.43624958,
                    Longitude = 139.426554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:51"),
                    Latitude = 35.43627677,
                    Longitude = 139.4266248
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:52"),
                    Latitude = 35.43630536,
                    Longitude = 139.4266975
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:53"),
                    Latitude = 35.43633359,
                    Longitude = 139.4267694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:54"),
                    Latitude = 35.43636109,
                    Longitude = 139.4268405
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:55"),
                    Latitude = 35.43638963,
                    Longitude = 139.4269142
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:56"),
                    Latitude = 35.43641729,
                    Longitude = 139.4269859
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:57"),
                    Latitude = 35.43644403,
                    Longitude = 139.4270546
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:58"),
                    Latitude = 35.43647199,
                    Longitude = 139.4271214
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:34:59"),
                    Latitude = 35.43649906,
                    Longitude = 139.4271857
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:00"),
                    Latitude = 35.43652376,
                    Longitude = 139.4272445
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:01"),
                    Latitude = 35.43654573,
                    Longitude = 139.4272978
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:02"),
                    Latitude = 35.43656588,
                    Longitude = 139.4273459
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:03"),
                    Latitude = 35.43658481,
                    Longitude = 139.4273915
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:04"),
                    Latitude = 35.43660448,
                    Longitude = 139.4274372
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:05"),
                    Latitude = 35.43662528,
                    Longitude = 139.4274837
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:06"),
                    Latitude = 35.43666133,
                    Longitude = 139.4275525
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:07"),
                    Latitude = 35.43669509,
                    Longitude = 139.4276257
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:08"),
                    Latitude = 35.43672557,
                    Longitude = 139.4276911
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:09"),
                    Latitude = 35.43675962,
                    Longitude = 139.4277556
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:10"),
                    Latitude = 35.43679841,
                    Longitude = 139.4278209
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:11"),
                    Latitude = 35.43684115,
                    Longitude = 139.4278972
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:12"),
                    Latitude = 35.43688523,
                    Longitude = 139.4279703
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:13"),
                    Latitude = 35.43692761,
                    Longitude = 139.4280423
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:14"),
                    Latitude = 35.43696949,
                    Longitude = 139.4281164
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:15"),
                    Latitude = 35.43700793,
                    Longitude = 139.4281929
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:16"),
                    Latitude = 35.43704902,
                    Longitude = 139.4282668
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:17"),
                    Latitude = 35.43709138,
                    Longitude = 139.4283401
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:18"),
                    Latitude = 35.43712967,
                    Longitude = 139.4284149
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:19"),
                    Latitude = 35.4371643,
                    Longitude = 139.4284828
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:20"),
                    Latitude = 35.43719386,
                    Longitude = 139.4285421
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:21"),
                    Latitude = 35.4372239,
                    Longitude = 139.4285933
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:22"),
                    Latitude = 35.43725444,
                    Longitude = 139.4286444
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:23"),
                    Latitude = 35.43728614,
                    Longitude = 139.4286971
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:24"),
                    Latitude = 35.43731667,
                    Longitude = 139.4287463
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:25"),
                    Latitude = 35.43734456,
                    Longitude = 139.4287846
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:26"),
                    Latitude = 35.43736757,
                    Longitude = 139.4288199
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:27"),
                    Latitude = 35.43738789,
                    Longitude = 139.428848
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:28"),
                    Latitude = 35.43740755,
                    Longitude = 139.4288784
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:29"),
                    Latitude = 35.43742852,
                    Longitude = 139.4289115
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:30"),
                    Latitude = 35.43745334,
                    Longitude = 139.428948
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:31"),
                    Latitude = 35.4374776,
                    Longitude = 139.4289853
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:32"),
                    Latitude = 35.43750388,
                    Longitude = 139.4290277
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:33"),
                    Latitude = 35.43752775,
                    Longitude = 139.4290761
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:34"),
                    Latitude = 35.43755256,
                    Longitude = 139.4291245
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:35"),
                    Latitude = 35.43757389,
                    Longitude = 139.4291687
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:36"),
                    Latitude = 35.43758946,
                    Longitude = 139.4292033
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:37"),
                    Latitude = 35.43760382,
                    Longitude = 139.4292333
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:38"),
                    Latitude = 35.43761446,
                    Longitude = 139.4292528
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:39"),
                    Latitude = 35.43762113,
                    Longitude = 139.429264
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:40"),
                    Latitude = 35.43762362,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:41"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:42"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:43"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:44"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:45"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:46"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:47"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:48"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:49"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:50"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:51"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:52"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:53"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:54"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:55"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:56"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:57"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:58"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:35:59"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:00"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:01"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:02"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:03"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:04"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:05"),
                    Latitude = 35.43762363,
                    Longitude = 139.4292672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:06"),
                    Latitude = 35.4376235,
                    Longitude = 139.4292699
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:07"),
                    Latitude = 35.43762795,
                    Longitude = 139.4292799
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:08"),
                    Latitude = 35.43763646,
                    Longitude = 139.4292928
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:09"),
                    Latitude = 35.43764304,
                    Longitude = 139.4293027
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:10"),
                    Latitude = 35.43764497,
                    Longitude = 139.4293052
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:11"),
                    Latitude = 35.43764497,
                    Longitude = 139.4293052
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:12"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:13"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:14"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:15"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:16"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:17"),
                    Latitude = 35.43764652,
                    Longitude = 139.4293074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:18"),
                    Latitude = 35.43764889,
                    Longitude = 139.4293117
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:19"),
                    Latitude = 35.43765552,
                    Longitude = 139.429323
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:20"),
                    Latitude = 35.43766777,
                    Longitude = 139.4293437
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:21"),
                    Latitude = 35.43769319,
                    Longitude = 139.429386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:22"),
                    Latitude = 35.43772465,
                    Longitude = 139.4294373
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:23"),
                    Latitude = 35.43775888,
                    Longitude = 139.4294947
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:24"),
                    Latitude = 35.43779288,
                    Longitude = 139.4295516
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:25"),
                    Latitude = 35.43782066,
                    Longitude = 139.4295977
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:26"),
                    Latitude = 35.43784366,
                    Longitude = 139.4296335
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:27"),
                    Latitude = 35.43786127,
                    Longitude = 139.4296601
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:28"),
                    Latitude = 35.43787787,
                    Longitude = 139.4296852
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:29"),
                    Latitude = 35.43789511,
                    Longitude = 139.4297102
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:30"),
                    Latitude = 35.43791226,
                    Longitude = 139.4297323
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:31"),
                    Latitude = 35.43792634,
                    Longitude = 139.4297462
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:32"),
                    Latitude = 35.43793678,
                    Longitude = 139.4297596
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:33"),
                    Latitude = 35.43794604,
                    Longitude = 139.4297729
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:34"),
                    Latitude = 35.43795582,
                    Longitude = 139.4297878
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:35"),
                    Latitude = 35.43797218,
                    Longitude = 139.429816
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:36"),
                    Latitude = 35.43799609,
                    Longitude = 139.4298543
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:37"),
                    Latitude = 35.43802127,
                    Longitude = 139.4298913
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:38"),
                    Latitude = 35.43804883,
                    Longitude = 139.429938
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:39"),
                    Latitude = 35.43807375,
                    Longitude = 139.4299775
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:40"),
                    Latitude = 35.43809657,
                    Longitude = 139.4300137
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:41"),
                    Latitude = 35.43811649,
                    Longitude = 139.4300461
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:42"),
                    Latitude = 35.43813172,
                    Longitude = 139.43007
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:43"),
                    Latitude = 35.43814402,
                    Longitude = 139.4300866
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:44"),
                    Latitude = 35.43815408,
                    Longitude = 139.4300998
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:45"),
                    Latitude = 35.43816203,
                    Longitude = 139.4301093
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:46"),
                    Latitude = 35.43816868,
                    Longitude = 139.4301181
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:47"),
                    Latitude = 35.43817587,
                    Longitude = 139.4301298
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:48"),
                    Latitude = 35.43818757,
                    Longitude = 139.4301491
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:49"),
                    Latitude = 35.43819791,
                    Longitude = 139.4301677
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:50"),
                    Latitude = 35.43820403,
                    Longitude = 139.4301789
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:51"),
                    Latitude = 35.43820647,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:52"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:53"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:54"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:55"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:56"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:57"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:58"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:36:59"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:00"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:01"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:02"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:03"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:04"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:05"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:06"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:07"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:08"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:09"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:10"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:11"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:12"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:13"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:14"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:15"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:16"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:17"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:18"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:19"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:20"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:21"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:22"),
                    Latitude = 35.43820646,
                    Longitude = 139.4301842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:23"),
                    Latitude = 35.43821256,
                    Longitude = 139.4301979
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:24"),
                    Latitude = 35.43822649,
                    Longitude = 139.4302265
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:25"),
                    Latitude = 35.43824431,
                    Longitude = 139.4302618
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:26"),
                    Latitude = 35.43825971,
                    Longitude = 139.4302939
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:27"),
                    Latitude = 35.43827284,
                    Longitude = 139.4303253
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:28"),
                    Latitude = 35.43828248,
                    Longitude = 139.4303556
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:29"),
                    Latitude = 35.4382911,
                    Longitude = 139.4303762
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:30"),
                    Latitude = 35.43829568,
                    Longitude = 139.430391
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:31"),
                    Latitude = 35.43830216,
                    Longitude = 139.4304091
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:32"),
                    Latitude = 35.43831402,
                    Longitude = 139.430437
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:33"),
                    Latitude = 35.43832783,
                    Longitude = 139.4304646
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:34"),
                    Latitude = 35.43833848,
                    Longitude = 139.4304883
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:35"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:36"),
                    Latitude = 35.43834515,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:37"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:38"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:39"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:40"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:41"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:42"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:43"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:44"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:45"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:46"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:47"),
                    Latitude = 35.43834514,
                    Longitude = 139.4305064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:48"),
                    Latitude = 35.43835057,
                    Longitude = 139.4305172
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:49"),
                    Latitude = 35.43836484,
                    Longitude = 139.4305433
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:50"),
                    Latitude = 35.43839133,
                    Longitude = 139.4305862
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:51"),
                    Latitude = 35.43842326,
                    Longitude = 139.4306347
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:52"),
                    Latitude = 35.43845559,
                    Longitude = 139.4306852
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:53"),
                    Latitude = 35.43848796,
                    Longitude = 139.4307362
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:54"),
                    Latitude = 35.43852042,
                    Longitude = 139.4307856
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:55"),
                    Latitude = 35.43855448,
                    Longitude = 139.4308368
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:56"),
                    Latitude = 35.43858585,
                    Longitude = 139.4308863
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:57"),
                    Latitude = 35.43861564,
                    Longitude = 139.4309367
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:58"),
                    Latitude = 35.43864369,
                    Longitude = 139.4309864
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:37:59"),
                    Latitude = 35.43866772,
                    Longitude = 139.4310325
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:00"),
                    Latitude = 35.4386892,
                    Longitude = 139.4310768
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:01"),
                    Latitude = 35.4387075,
                    Longitude = 139.4311159
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:02"),
                    Latitude = 35.43872271,
                    Longitude = 139.4311515
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:03"),
                    Latitude = 35.43873463,
                    Longitude = 139.4311801
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:04"),
                    Latitude = 35.43874141,
                    Longitude = 139.4311988
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:05"),
                    Latitude = 35.43874634,
                    Longitude = 139.4312122
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:06"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:07"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:08"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:09"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:10"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:11"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:12"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:13"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:14"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:15"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:16"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:17"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:18"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:19"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:20"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:21"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:22"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:23"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:24"),
                    Latitude = 35.43874633,
                    Longitude = 139.4312123
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:25"),
                    Latitude = 35.4387464,
                    Longitude = 139.4312116
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:26"),
                    Latitude = 35.43875513,
                    Longitude = 139.4312271
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:27"),
                    Latitude = 35.43877044,
                    Longitude = 139.4312568
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:28"),
                    Latitude = 35.43878585,
                    Longitude = 139.4312858
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:29"),
                    Latitude = 35.43879952,
                    Longitude = 139.4313118
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:30"),
                    Latitude = 35.43881122,
                    Longitude = 139.4313325
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:31"),
                    Latitude = 35.43881975,
                    Longitude = 139.4313478
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:32"),
                    Latitude = 35.43882533,
                    Longitude = 139.4313594
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:33"),
                    Latitude = 35.43882919,
                    Longitude = 139.431366
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:34"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:35"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:36"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:37"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:38"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:39"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:40"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:41"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:42"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:43"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:44"),
                    Latitude = 35.43882921,
                    Longitude = 139.4313661
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:45"),
                    Latitude = 35.43883486,
                    Longitude = 139.431379
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:46"),
                    Latitude = 35.43884549,
                    Longitude = 139.4314044
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:47"),
                    Latitude = 35.43885518,
                    Longitude = 139.4314258
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:48"),
                    Latitude = 35.43886644,
                    Longitude = 139.4314516
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:49"),
                    Latitude = 35.43887648,
                    Longitude = 139.431476
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:50"),
                    Latitude = 35.43888585,
                    Longitude = 139.4315006
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:51"),
                    Latitude = 35.43889411,
                    Longitude = 139.4315222
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:52"),
                    Latitude = 35.43890169,
                    Longitude = 139.4315382
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:53"),
                    Latitude = 35.43890832,
                    Longitude = 139.4315508
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:54"),
                    Latitude = 35.43891392,
                    Longitude = 139.4315614
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:55"),
                    Latitude = 35.43892285,
                    Longitude = 139.4315779
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:56"),
                    Latitude = 35.43893626,
                    Longitude = 139.4316031
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:57"),
                    Latitude = 35.43895433,
                    Longitude = 139.4316407
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:58"),
                    Latitude = 35.43897116,
                    Longitude = 139.4316754
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:38:59"),
                    Latitude = 35.43898688,
                    Longitude = 139.4317099
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:00"),
                    Latitude = 35.43900391,
                    Longitude = 139.431748
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:01"),
                    Latitude = 35.43902414,
                    Longitude = 139.4317926
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:02"),
                    Latitude = 35.43904648,
                    Longitude = 139.4318379
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:03"),
                    Latitude = 35.43906834,
                    Longitude = 139.431882
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:04"),
                    Latitude = 35.4390825,
                    Longitude = 139.4319207
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:05"),
                    Latitude = 35.43909563,
                    Longitude = 139.4319593
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:06"),
                    Latitude = 35.43910854,
                    Longitude = 139.4319969
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:07"),
                    Latitude = 35.43912404,
                    Longitude = 139.4320372
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:08"),
                    Latitude = 35.43914199,
                    Longitude = 139.4320809
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:09"),
                    Latitude = 35.43915916,
                    Longitude = 139.4321243
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:10"),
                    Latitude = 35.4391738,
                    Longitude = 139.4321605
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:11"),
                    Latitude = 35.43918634,
                    Longitude = 139.4321879
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:12"),
                    Latitude = 35.43919639,
                    Longitude = 139.4322085
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:13"),
                    Latitude = 35.43920258,
                    Longitude = 139.4322213
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:14"),
                    Latitude = 35.43920936,
                    Longitude = 139.4322348
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:15"),
                    Latitude = 35.4392231,
                    Longitude = 139.4322635
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:16"),
                    Latitude = 35.4392344,
                    Longitude = 139.4322883
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:17"),
                    Latitude = 35.4392422,
                    Longitude = 139.4323056
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:18"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:19"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:20"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:21"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:22"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:23"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:24"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:25"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:26"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:27"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:28"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:29"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:30"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:31"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:32"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:33"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:34"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:35"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:36"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:37"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:38"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:39"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:40"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:41"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:42"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:43"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:44"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:45"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:46"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:47"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:48"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:49"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:50"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:51"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:52"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:53"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:54"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:55"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:56"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:57"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:58"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:39:59"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:00"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:01"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:02"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:03"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:04"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:05"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:06"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:07"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:08"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:09"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:10"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:11"),
                    Latitude = 35.4392464,
                    Longitude = 139.432314
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:12"),
                    Latitude = 35.43925411,
                    Longitude = 139.4323262
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:13"),
                    Latitude = 35.43927274,
                    Longitude = 139.4323609
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:14"),
                    Latitude = 35.43929941,
                    Longitude = 139.4324145
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:15"),
                    Latitude = 35.43933053,
                    Longitude = 139.4324749
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:16"),
                    Latitude = 35.4393609,
                    Longitude = 139.4325352
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:17"),
                    Latitude = 35.43939531,
                    Longitude = 139.4326038
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:18"),
                    Latitude = 35.43943409,
                    Longitude = 139.4326819
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:19"),
                    Latitude = 35.43947212,
                    Longitude = 139.4327636
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:20"),
                    Latitude = 35.43950814,
                    Longitude = 139.4328419
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:21"),
                    Latitude = 35.43954429,
                    Longitude = 139.4329172
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:22"),
                    Latitude = 35.43957662,
                    Longitude = 139.4329877
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:23"),
                    Latitude = 35.43960513,
                    Longitude = 139.4330449
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:24"),
                    Latitude = 35.43963084,
                    Longitude = 139.4331007
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:25"),
                    Latitude = 35.43965622,
                    Longitude = 139.4331528
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:26"),
                    Latitude = 35.43967758,
                    Longitude = 139.4332005
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:27"),
                    Latitude = 35.43969764,
                    Longitude = 139.4332511
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:28"),
                    Latitude = 35.43972062,
                    Longitude = 139.433306
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:29"),
                    Latitude = 35.43974867,
                    Longitude = 139.4333715
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:30"),
                    Latitude = 35.43978117,
                    Longitude = 139.4334498
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:31"),
                    Latitude = 35.4398129,
                    Longitude = 139.4335241
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:32"),
                    Latitude = 35.43984611,
                    Longitude = 139.4335974
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:33"),
                    Latitude = 35.43988082,
                    Longitude = 139.433678
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:34"),
                    Latitude = 35.43991682,
                    Longitude = 139.4337612
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:35"),
                    Latitude = 35.43995387,
                    Longitude = 139.4338493
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:36"),
                    Latitude = 35.43999632,
                    Longitude = 139.4339408
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:37"),
                    Latitude = 35.44004064,
                    Longitude = 139.4340365
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:38"),
                    Latitude = 35.44008751,
                    Longitude = 139.4341374
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:39"),
                    Latitude = 35.44013698,
                    Longitude = 139.434237
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:40"),
                    Latitude = 35.44018654,
                    Longitude = 139.4343415
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:41"),
                    Latitude = 35.44023775,
                    Longitude = 139.4344473
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:42"),
                    Latitude = 35.44029035,
                    Longitude = 139.4345567
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:43"),
                    Latitude = 35.44034332,
                    Longitude = 139.434667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:44"),
                    Latitude = 35.44039748,
                    Longitude = 139.43478
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:45"),
                    Latitude = 35.44045192,
                    Longitude = 139.4348987
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:46"),
                    Latitude = 35.4405069,
                    Longitude = 139.4350196
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:47"),
                    Latitude = 35.44056284,
                    Longitude = 139.4351438
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:48"),
                    Latitude = 35.44061751,
                    Longitude = 139.4352714
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:49"),
                    Latitude = 35.44066969,
                    Longitude = 139.4354058
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:50"),
                    Latitude = 35.4407211,
                    Longitude = 139.435535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:51"),
                    Latitude = 35.44076706,
                    Longitude = 139.4356672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:52"),
                    Latitude = 35.44080904,
                    Longitude = 139.4357982
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:53"),
                    Latitude = 35.44084505,
                    Longitude = 139.4359298
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:54"),
                    Latitude = 35.44087644,
                    Longitude = 139.4360577
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:55"),
                    Latitude = 35.44090429,
                    Longitude = 139.4361806
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:56"),
                    Latitude = 35.44093244,
                    Longitude = 139.436304
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:57"),
                    Latitude = 35.44095575,
                    Longitude = 139.4364291
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:58"),
                    Latitude = 35.44097403,
                    Longitude = 139.4365483
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:40:59"),
                    Latitude = 35.4409927,
                    Longitude = 139.436668
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:00"),
                    Latitude = 35.4410086,
                    Longitude = 139.4367918
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:01"),
                    Latitude = 35.44102018,
                    Longitude = 139.4369124
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:02"),
                    Latitude = 35.44102989,
                    Longitude = 139.4370319
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:03"),
                    Latitude = 35.44103789,
                    Longitude = 139.4371541
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:04"),
                    Latitude = 35.44104345,
                    Longitude = 139.4372781
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:05"),
                    Latitude = 35.44104906,
                    Longitude = 139.4373999
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:06"),
                    Latitude = 35.44105437,
                    Longitude = 139.4375222
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:07"),
                    Latitude = 35.44105911,
                    Longitude = 139.4376453
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:08"),
                    Latitude = 35.44106374,
                    Longitude = 139.4377635
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:09"),
                    Latitude = 35.44106531,
                    Longitude = 139.4378739
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:10"),
                    Latitude = 35.44106709,
                    Longitude = 139.437975
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:11"),
                    Latitude = 35.44106909,
                    Longitude = 139.4380717
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:12"),
                    Latitude = 35.44107115,
                    Longitude = 139.438164
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:13"),
                    Latitude = 35.44107334,
                    Longitude = 139.4382389
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:14"),
                    Latitude = 35.44107513,
                    Longitude = 139.4383019
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:15"),
                    Latitude = 35.44107624,
                    Longitude = 139.4383535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:16"),
                    Latitude = 35.44107809,
                    Longitude = 139.438394
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:17"),
                    Latitude = 35.44108032,
                    Longitude = 139.4384187
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:18"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:19"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:20"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:21"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:22"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:23"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:24"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:25"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:26"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:27"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:28"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:29"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:30"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:31"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:32"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:33"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:34"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:35"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:36"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:37"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:38"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:39"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:40"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:41"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:42"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:43"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:44"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:45"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:46"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:47"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:48"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:49"),
                    Latitude = 35.44108015,
                    Longitude = 139.4384281
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:50"),
                    Latitude = 35.44107796,
                    Longitude = 139.4384529
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:51"),
                    Latitude = 35.44107631,
                    Longitude = 139.438505
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:52"),
                    Latitude = 35.44107403,
                    Longitude = 139.438577
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:53"),
                    Latitude = 35.4410712,
                    Longitude = 139.4386518
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:54"),
                    Latitude = 35.44106922,
                    Longitude = 139.438727
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:55"),
                    Latitude = 35.44106512,
                    Longitude = 139.438809
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:56"),
                    Latitude = 35.4410606,
                    Longitude = 139.4388934
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:57"),
                    Latitude = 35.44105725,
                    Longitude = 139.4389767
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:58"),
                    Latitude = 35.44105366,
                    Longitude = 139.4390571
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:41:59"),
                    Latitude = 35.44104699,
                    Longitude = 139.4391324
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:00"),
                    Latitude = 35.44104273,
                    Longitude = 139.4392107
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:01"),
                    Latitude = 35.44103562,
                    Longitude = 139.4392877
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:02"),
                    Latitude = 35.44103149,
                    Longitude = 139.4393658
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:03"),
                    Latitude = 35.44102536,
                    Longitude = 139.4394389
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:04"),
                    Latitude = 35.44102236,
                    Longitude = 139.4395105
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:05"),
                    Latitude = 35.44101763,
                    Longitude = 139.4395811
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:06"),
                    Latitude = 35.44101278,
                    Longitude = 139.439654
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:07"),
                    Latitude = 35.44100839,
                    Longitude = 139.4397331
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:08"),
                    Latitude = 35.44100495,
                    Longitude = 139.4398148
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:09"),
                    Latitude = 35.44100272,
                    Longitude = 139.4398933
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:10"),
                    Latitude = 35.44100276,
                    Longitude = 139.4399635
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:11"),
                    Latitude = 35.44100213,
                    Longitude = 139.440031
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:12"),
                    Latitude = 35.44100366,
                    Longitude = 139.4400903
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:13"),
                    Latitude = 35.44100564,
                    Longitude = 139.4401463
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:14"),
                    Latitude = 35.44100695,
                    Longitude = 139.4401978
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:15"),
                    Latitude = 35.4410108,
                    Longitude = 139.440249
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:16"),
                    Latitude = 35.4410155,
                    Longitude = 139.4402996
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:17"),
                    Latitude = 35.4410193,
                    Longitude = 139.4403506
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:18"),
                    Latitude = 35.4410225,
                    Longitude = 139.4403963
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:19"),
                    Latitude = 35.44102505,
                    Longitude = 139.4404416
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:20"),
                    Latitude = 35.44102655,
                    Longitude = 139.4404834
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:21"),
                    Latitude = 35.44102671,
                    Longitude = 139.4405352
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:22"),
                    Latitude = 35.44102624,
                    Longitude = 139.4406004
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:23"),
                    Latitude = 35.44102731,
                    Longitude = 139.4406752
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:24"),
                    Latitude = 35.44102778,
                    Longitude = 139.4407525
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:25"),
                    Latitude = 35.44102832,
                    Longitude = 139.4408325
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:26"),
                    Latitude = 35.44102917,
                    Longitude = 139.440921
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:27"),
                    Latitude = 35.4410304,
                    Longitude = 139.4410169
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:28"),
                    Latitude = 35.44103001,
                    Longitude = 139.4411194
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:29"),
                    Latitude = 35.44102941,
                    Longitude = 139.4412229
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:30"),
                    Latitude = 35.4410302,
                    Longitude = 139.441327
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:31"),
                    Latitude = 35.44103164,
                    Longitude = 139.4414242
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:32"),
                    Latitude = 35.44103268,
                    Longitude = 139.4415217
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:33"),
                    Latitude = 35.44103406,
                    Longitude = 139.4416199
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:34"),
                    Latitude = 35.44103485,
                    Longitude = 139.4417155
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:35"),
                    Latitude = 35.44103578,
                    Longitude = 139.4418178
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:36"),
                    Latitude = 35.44103608,
                    Longitude = 139.4419252
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:37"),
                    Latitude = 35.44103415,
                    Longitude = 139.4420304
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:38"),
                    Latitude = 35.44103239,
                    Longitude = 139.4421372
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:39"),
                    Latitude = 35.44103017,
                    Longitude = 139.442241
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:40"),
                    Latitude = 35.44102743,
                    Longitude = 139.4423436
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:41"),
                    Latitude = 35.44102459,
                    Longitude = 139.4424489
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:42"),
                    Latitude = 35.44102336,
                    Longitude = 139.4425549
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:43"),
                    Latitude = 35.44102253,
                    Longitude = 139.4426635
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:44"),
                    Latitude = 35.44102249,
                    Longitude = 139.442772
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:45"),
                    Latitude = 35.44102236,
                    Longitude = 139.442885
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:46"),
                    Latitude = 35.4410221,
                    Longitude = 139.4430009
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:47"),
                    Latitude = 35.44102162,
                    Longitude = 139.4431208
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:48"),
                    Latitude = 35.44102115,
                    Longitude = 139.4432382
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:49"),
                    Latitude = 35.44102015,
                    Longitude = 139.4433545
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:50"),
                    Latitude = 35.44101698,
                    Longitude = 139.4434673
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:51"),
                    Latitude = 35.44101155,
                    Longitude = 139.4435783
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:52"),
                    Latitude = 35.44100324,
                    Longitude = 139.4436869
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:53"),
                    Latitude = 35.4409955,
                    Longitude = 139.4437931
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:54"),
                    Latitude = 35.44098404,
                    Longitude = 139.4438984
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:55"),
                    Latitude = 35.44097069,
                    Longitude = 139.4440021
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:56"),
                    Latitude = 35.44095687,
                    Longitude = 139.4441017
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:57"),
                    Latitude = 35.44094141,
                    Longitude = 139.4441997
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:58"),
                    Latitude = 35.44092634,
                    Longitude = 139.4442959
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:42:59"),
                    Latitude = 35.44090482,
                    Longitude = 139.4443961
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:00"),
                    Latitude = 35.4408802,
                    Longitude = 139.4444983
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:01"),
                    Latitude = 35.44085687,
                    Longitude = 139.4445937
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:02"),
                    Latitude = 35.44083032,
                    Longitude = 139.4446899
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:03"),
                    Latitude = 35.44080158,
                    Longitude = 139.4447866
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:04"),
                    Latitude = 35.44077147,
                    Longitude = 139.4448803
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:05"),
                    Latitude = 35.44073997,
                    Longitude = 139.4449731
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:06"),
                    Latitude = 35.44070648,
                    Longitude = 139.4450633
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:07"),
                    Latitude = 35.44067248,
                    Longitude = 139.4451492
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:08"),
                    Latitude = 35.44063621,
                    Longitude = 139.4452356
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:09"),
                    Latitude = 35.44059975,
                    Longitude = 139.445323
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:10"),
                    Latitude = 35.44056108,
                    Longitude = 139.445412
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:11"),
                    Latitude = 35.44051966,
                    Longitude = 139.4455043
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:12"),
                    Latitude = 35.44047649,
                    Longitude = 139.4456013
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:13"),
                    Latitude = 35.44043281,
                    Longitude = 139.4457013
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:14"),
                    Latitude = 35.44038813,
                    Longitude = 139.4458036
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:15"),
                    Latitude = 35.44034104,
                    Longitude = 139.4459111
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:16"),
                    Latitude = 35.44029462,
                    Longitude = 139.4460167
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:17"),
                    Latitude = 35.44025352,
                    Longitude = 139.4461161
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:18"),
                    Latitude = 35.44021724,
                    Longitude = 139.4462077
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:19"),
                    Latitude = 35.44018786,
                    Longitude = 139.4462879
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:20"),
                    Latitude = 35.44016137,
                    Longitude = 139.4463667
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:21"),
                    Latitude = 35.44013473,
                    Longitude = 139.4464536
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:22"),
                    Latitude = 35.44010986,
                    Longitude = 139.4465447
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:23"),
                    Latitude = 35.44008913,
                    Longitude = 139.4466358
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:24"),
                    Latitude = 35.44007165,
                    Longitude = 139.446717
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:25"),
                    Latitude = 35.44005706,
                    Longitude = 139.4467908
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:26"),
                    Latitude = 35.44004711,
                    Longitude = 139.4468611
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:27"),
                    Latitude = 35.44003751,
                    Longitude = 139.4469305
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:28"),
                    Latitude = 35.44002954,
                    Longitude = 139.4469926
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:29"),
                    Latitude = 35.44002466,
                    Longitude = 139.4470361
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:30"),
                    Latitude = 35.44002148,
                    Longitude = 139.4470619
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:31"),
                    Latitude = 35.44001974,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:32"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:33"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:34"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:35"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:36"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:37"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:38"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:39"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:40"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:41"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:42"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:43"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:44"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:45"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:46"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:47"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:48"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:49"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:50"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:51"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:52"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:53"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:54"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:55"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:56"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:57"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:58"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:43:59"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:00"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:01"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:02"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:03"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:04"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:05"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:06"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:07"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:08"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:09"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:10"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:11"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:12"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:13"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:14"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:15"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:16"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:17"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:18"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:19"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:20"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:21"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:22"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:23"),
                    Latitude = 35.44001975,
                    Longitude = 139.4470732
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:24"),
                    Latitude = 35.44001884,
                    Longitude = 139.4470866
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:25"),
                    Latitude = 35.44001587,
                    Longitude = 139.4471146
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:26"),
                    Latitude = 35.44000977,
                    Longitude = 139.4471938
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:27"),
                    Latitude = 35.44000151,
                    Longitude = 139.447294
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:28"),
                    Latitude = 35.43999666,
                    Longitude = 139.4473927
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:29"),
                    Latitude = 35.43999075,
                    Longitude = 139.4475011
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:30"),
                    Latitude = 35.43998466,
                    Longitude = 139.4476162
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:31"),
                    Latitude = 35.43997825,
                    Longitude = 139.4477327
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:32"),
                    Latitude = 35.43997141,
                    Longitude = 139.4478509
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:33"),
                    Latitude = 35.43996405,
                    Longitude = 139.44797
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:34"),
                    Latitude = 35.43995676,
                    Longitude = 139.4480854
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:35"),
                    Latitude = 35.43994935,
                    Longitude = 139.4481992
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:36"),
                    Latitude = 35.43994153,
                    Longitude = 139.4483148
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:37"),
                    Latitude = 35.43993345,
                    Longitude = 139.4484324
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:38"),
                    Latitude = 35.4399251,
                    Longitude = 139.4485523
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:39"),
                    Latitude = 35.43991681,
                    Longitude = 139.4486715
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:40"),
                    Latitude = 35.43990987,
                    Longitude = 139.4487845
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:41"),
                    Latitude = 35.43990274,
                    Longitude = 139.4488981
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:42"),
                    Latitude = 35.43989557,
                    Longitude = 139.4490098
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:43"),
                    Latitude = 35.43988852,
                    Longitude = 139.4491199
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:44"),
                    Latitude = 35.43988086,
                    Longitude = 139.4492293
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:45"),
                    Latitude = 35.43987319,
                    Longitude = 139.449334
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:46"),
                    Latitude = 35.43986556,
                    Longitude = 139.4494414
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:47"),
                    Latitude = 35.43985839,
                    Longitude = 139.4495506
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:48"),
                    Latitude = 35.43985121,
                    Longitude = 139.4496611
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:49"),
                    Latitude = 35.4398439,
                    Longitude = 139.4497746
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:50"),
                    Latitude = 35.43983573,
                    Longitude = 139.4498938
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:51"),
                    Latitude = 35.43982758,
                    Longitude = 139.4500136
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:52"),
                    Latitude = 35.43981992,
                    Longitude = 139.450132
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:53"),
                    Latitude = 35.43981509,
                    Longitude = 139.4502513
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:54"),
                    Latitude = 35.43981043,
                    Longitude = 139.4503721
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:55"),
                    Latitude = 35.43980587,
                    Longitude = 139.4504957
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:56"),
                    Latitude = 35.43980145,
                    Longitude = 139.4506254
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:57"),
                    Latitude = 35.4397969,
                    Longitude = 139.4507602
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:58"),
                    Latitude = 35.43979153,
                    Longitude = 139.4508916
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:44:59"),
                    Latitude = 35.4397872,
                    Longitude = 139.4510264
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:00"),
                    Latitude = 35.43978362,
                    Longitude = 139.4511611
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:01"),
                    Latitude = 35.43977848,
                    Longitude = 139.4513059
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:02"),
                    Latitude = 35.43977339,
                    Longitude = 139.4514552
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:03"),
                    Latitude = 35.43976976,
                    Longitude = 139.4515947
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:04"),
                    Latitude = 35.43976469,
                    Longitude = 139.4517305
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:05"),
                    Latitude = 35.43975632,
                    Longitude = 139.451857
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:06"),
                    Latitude = 35.4397464,
                    Longitude = 139.4519739
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:07"),
                    Latitude = 35.43973661,
                    Longitude = 139.4520859
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:08"),
                    Latitude = 35.43972684,
                    Longitude = 139.4522001
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:09"),
                    Latitude = 35.43971644,
                    Longitude = 139.4523204
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:10"),
                    Latitude = 35.43970766,
                    Longitude = 139.452445
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:11"),
                    Latitude = 35.43969723,
                    Longitude = 139.4525629
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:12"),
                    Latitude = 35.43968393,
                    Longitude = 139.4526707
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:13"),
                    Latitude = 35.43966719,
                    Longitude = 139.4527654
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:14"),
                    Latitude = 35.43964711,
                    Longitude = 139.4528514
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:15"),
                    Latitude = 35.43962936,
                    Longitude = 139.4529373
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:16"),
                    Latitude = 35.43963395,
                    Longitude = 139.4530173
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:17"),
                    Latitude = 35.43968256,
                    Longitude = 139.4530755
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:18"),
                    Latitude = 35.43974969,
                    Longitude = 139.4531139
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:19"),
                    Latitude = 35.4398364,
                    Longitude = 139.4531487
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:20"),
                    Latitude = 35.43993429,
                    Longitude = 139.4531833
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:21"),
                    Latitude = 35.44004072,
                    Longitude = 139.4532182
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:22"),
                    Latitude = 35.44014934,
                    Longitude = 139.4532516
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:23"),
                    Latitude = 35.44025915,
                    Longitude = 139.4532888
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:24"),
                    Latitude = 35.44036903,
                    Longitude = 139.4533226
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:25"),
                    Latitude = 35.44047579,
                    Longitude = 139.4533563
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:26"),
                    Latitude = 35.44058503,
                    Longitude = 139.4533895
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:27"),
                    Latitude = 35.44069922,
                    Longitude = 139.4534231
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:28"),
                    Latitude = 35.44081657,
                    Longitude = 139.453459
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:29"),
                    Latitude = 35.44093447,
                    Longitude = 139.4534899
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:30"),
                    Latitude = 35.44105222,
                    Longitude = 139.4535208
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:31"),
                    Latitude = 35.44117297,
                    Longitude = 139.4535478
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:32"),
                    Latitude = 35.44129474,
                    Longitude = 139.4535739
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:33"),
                    Latitude = 35.44141638,
                    Longitude = 139.4535972
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:34"),
                    Latitude = 35.44153993,
                    Longitude = 139.4536206
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:35"),
                    Latitude = 35.44165973,
                    Longitude = 139.4536442
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:36"),
                    Latitude = 35.44178272,
                    Longitude = 139.4536685
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:37"),
                    Latitude = 35.44190332,
                    Longitude = 139.4536912
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:38"),
                    Latitude = 35.44202315,
                    Longitude = 139.4537128
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:39"),
                    Latitude = 35.44214075,
                    Longitude = 139.453733
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:40"),
                    Latitude = 35.44225986,
                    Longitude = 139.4537542
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:41"),
                    Latitude = 35.44237844,
                    Longitude = 139.4537782
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:42"),
                    Latitude = 35.44249216,
                    Longitude = 139.4538097
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:43"),
                    Latitude = 35.44260108,
                    Longitude = 139.4538516
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:44"),
                    Latitude = 35.44270328,
                    Longitude = 139.4539151
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:45"),
                    Latitude = 35.44279073,
                    Longitude = 139.4539813
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:46"),
                    Latitude = 35.44286443,
                    Longitude = 139.4540556
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:47"),
                    Latitude = 35.44292668,
                    Longitude = 139.454138
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:48"),
                    Latitude = 35.44297188,
                    Longitude = 139.4542127
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:49"),
                    Latitude = 35.44300663,
                    Longitude = 139.4542693
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:50"),
                    Latitude = 35.44303147,
                    Longitude = 139.4543094
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:51"),
                    Latitude = 35.4430494,
                    Longitude = 139.4543369
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:52"),
                    Latitude = 35.4430613,
                    Longitude = 139.4543524
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:53"),
                    Latitude = 35.44306784,
                    Longitude = 139.4543555
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:54"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:55"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:56"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:57"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:58"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:45:59"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:00"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:01"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:02"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:03"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:04"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:05"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:06"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:07"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:08"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:09"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:10"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:11"),
                    Latitude = 35.44306788,
                    Longitude = 139.4543554
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:12"),
                    Latitude = 35.4430723,
                    Longitude = 139.454361
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:13"),
                    Latitude = 35.44308754,
                    Longitude = 139.4543877
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:14"),
                    Latitude = 35.44311149,
                    Longitude = 139.4544381
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:15"),
                    Latitude = 35.4431365,
                    Longitude = 139.4544873
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:16"),
                    Latitude = 35.44315406,
                    Longitude = 139.4545416
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:17"),
                    Latitude = 35.44315441,
                    Longitude = 139.4545843
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:18"),
                    Latitude = 35.44313479,
                    Longitude = 139.4546299
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:19"),
                    Latitude = 35.44309696,
                    Longitude = 139.4546743
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:20"),
                    Latitude = 35.44304693,
                    Longitude = 139.45472
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:21"),
                    Latitude = 35.44299461,
                    Longitude = 139.4547686
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:22"),
                    Latitude = 35.44293784,
                    Longitude = 139.4548198
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:23"),
                    Latitude = 35.44287575,
                    Longitude = 139.4548727
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:24"),
                    Latitude = 35.44280903,
                    Longitude = 139.4549298
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:25"),
                    Latitude = 35.44274683,
                    Longitude = 139.4549823
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:26"),
                    Latitude = 35.44269016,
                    Longitude = 139.4550308
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:27"),
                    Latitude = 35.44263142,
                    Longitude = 139.4550799
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:28"),
                    Latitude = 35.44257879,
                    Longitude = 139.4551242
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:29"),
                    Latitude = 35.44253492,
                    Longitude = 139.4551577
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:30"),
                    Latitude = 35.44249951,
                    Longitude = 139.4551861
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:31"),
                    Latitude = 35.44246576,
                    Longitude = 139.4552147
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:32"),
                    Latitude = 35.44243951,
                    Longitude = 139.4552364
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:33"),
                    Latitude = 35.44242162,
                    Longitude = 139.4552532
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:34"),
                    Latitude = 35.44240789,
                    Longitude = 139.4552641
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:35"),
                    Latitude = 35.44240249,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:36"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:37"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:38"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:39"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:40"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:41"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:42"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:43"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:44"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:45"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:46"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:47"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:48"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:49"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:50"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:51"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:52"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:53"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:54"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:55"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:56"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:57"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:58"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:46:59"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:00"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:01"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:02"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:03"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:04"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:05"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:06"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:07"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:08"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:09"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:10"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:11"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:12"),
                    Latitude = 35.44240247,
                    Longitude = 139.4552694
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:13"),
                    Latitude = 35.44238985,
                    Longitude = 139.4552758
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:14"),
                    Latitude = 35.44237655,
                    Longitude = 139.4552838
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:15"),
                    Latitude = 35.44234277,
                    Longitude = 139.4553084
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:16"),
                    Latitude = 35.44228625,
                    Longitude = 139.4553562
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:17"),
                    Latitude = 35.44222761,
                    Longitude = 139.4554026
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:18"),
                    Latitude = 35.44216586,
                    Longitude = 139.455453
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:19"),
                    Latitude = 35.44209583,
                    Longitude = 139.4555079
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:20"),
                    Latitude = 35.44202531,
                    Longitude = 139.4555665
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:21"),
                    Latitude = 35.44194735,
                    Longitude = 139.4556275
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:22"),
                    Latitude = 35.44186322,
                    Longitude = 139.4556943
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:23"),
                    Latitude = 35.44178398,
                    Longitude = 139.4557653
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:24"),
                    Latitude = 35.44171004,
                    Longitude = 139.455828
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:25"),
                    Latitude = 35.44162883,
                    Longitude = 139.4558904
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:26"),
                    Latitude = 35.44154962,
                    Longitude = 139.4559585
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:27"),
                    Latitude = 35.44146697,
                    Longitude = 139.4560238
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:28"),
                    Latitude = 35.44138122,
                    Longitude = 139.4560952
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:29"),
                    Latitude = 35.44129256,
                    Longitude = 139.4561645
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:30"),
                    Latitude = 35.44120556,
                    Longitude = 139.4562364
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:31"),
                    Latitude = 35.44111455,
                    Longitude = 139.4563105
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:32"),
                    Latitude = 35.44102277,
                    Longitude = 139.4563863
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:33"),
                    Latitude = 35.44093292,
                    Longitude = 139.4564603
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:34"),
                    Latitude = 35.44084868,
                    Longitude = 139.4565336
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:35"),
                    Latitude = 35.44076784,
                    Longitude = 139.4566108
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:36"),
                    Latitude = 35.44068465,
                    Longitude = 139.4566866
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:37"),
                    Latitude = 35.44059956,
                    Longitude = 139.4567648
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:38"),
                    Latitude = 35.44051293,
                    Longitude = 139.4568424
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:39"),
                    Latitude = 35.44042406,
                    Longitude = 139.4569219
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:40"),
                    Latitude = 35.44033311,
                    Longitude = 139.4570031
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:41"),
                    Latitude = 35.44023555,
                    Longitude = 139.4570874
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:42"),
                    Latitude = 35.44013677,
                    Longitude = 139.4571736
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:43"),
                    Latitude = 35.44003871,
                    Longitude = 139.4572604
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:44"),
                    Latitude = 35.43993498,
                    Longitude = 139.4573491
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:45"),
                    Latitude = 35.43983581,
                    Longitude = 139.4574357
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:46"),
                    Latitude = 35.43974841,
                    Longitude = 139.4575334
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:47"),
                    Latitude = 35.43967199,
                    Longitude = 139.4576271
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:48"),
                    Latitude = 35.43959596,
                    Longitude = 139.4577291
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:49"),
                    Latitude = 35.43952507,
                    Longitude = 139.4578352
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:50"),
                    Latitude = 35.43945868,
                    Longitude = 139.4579475
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:51"),
                    Latitude = 35.43939349,
                    Longitude = 139.4580614
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:52"),
                    Latitude = 35.43932636,
                    Longitude = 139.4581792
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:53"),
                    Latitude = 35.43925076,
                    Longitude = 139.4582862
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:54"),
                    Latitude = 35.43916299,
                    Longitude = 139.4583761
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:55"),
                    Latitude = 35.43906511,
                    Longitude = 139.4584465
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:56"),
                    Latitude = 35.43895843,
                    Longitude = 139.4585198
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:57"),
                    Latitude = 35.43884915,
                    Longitude = 139.4585971
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:58"),
                    Latitude = 35.43873786,
                    Longitude = 139.4586712
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:47:59"),
                    Latitude = 35.43862964,
                    Longitude = 139.4587434
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:00"),
                    Latitude = 35.43852358,
                    Longitude = 139.4588137
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:01"),
                    Latitude = 35.43841844,
                    Longitude = 139.458883
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:02"),
                    Latitude = 35.43831836,
                    Longitude = 139.4589496
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:03"),
                    Latitude = 35.43822646,
                    Longitude = 139.4590159
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:04"),
                    Latitude = 35.43814527,
                    Longitude = 139.459094
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:05"),
                    Latitude = 35.43807548,
                    Longitude = 139.4591697
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:06"),
                    Latitude = 35.43802694,
                    Longitude = 139.45923
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:07"),
                    Latitude = 35.43799589,
                    Longitude = 139.4592788
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:08"),
                    Latitude = 35.4379745,
                    Longitude = 139.4593098
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:09"),
                    Latitude = 35.43796037,
                    Longitude = 139.4593285
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:10"),
                    Latitude = 35.43795396,
                    Longitude = 139.4593386
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:11"),
                    Latitude = 35.43794893,
                    Longitude = 139.4593422
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:12"),
                    Latitude = 35.43794541,
                    Longitude = 139.4593429
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:13"),
                    Latitude = 35.43794539,
                    Longitude = 139.4593429
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:14"),
                    Latitude = 35.43794351,
                    Longitude = 139.4593452
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:15"),
                    Latitude = 35.43793526,
                    Longitude = 139.4593574
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:16"),
                    Latitude = 35.43791838,
                    Longitude = 139.4593891
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:17"),
                    Latitude = 35.43788592,
                    Longitude = 139.4594512
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:18"),
                    Latitude = 35.43785652,
                    Longitude = 139.4595243
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:19"),
                    Latitude = 35.43783233,
                    Longitude = 139.4595894
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:20"),
                    Latitude = 35.43780453,
                    Longitude = 139.4596725
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:21"),
                    Latitude = 35.4377742,
                    Longitude = 139.4597581
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:22"),
                    Latitude = 35.43774143,
                    Longitude = 139.4598467
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:23"),
                    Latitude = 35.4377048,
                    Longitude = 139.4599375
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:24"),
                    Latitude = 35.43766708,
                    Longitude = 139.4600304
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:25"),
                    Latitude = 35.43762735,
                    Longitude = 139.4601218
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:26"),
                    Latitude = 35.43758624,
                    Longitude = 139.4602269
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:27"),
                    Latitude = 35.43754079,
                    Longitude = 139.4603423
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:28"),
                    Latitude = 35.43749461,
                    Longitude = 139.4604623
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:29"),
                    Latitude = 35.43744911,
                    Longitude = 139.460579
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:30"),
                    Latitude = 35.43740366,
                    Longitude = 139.4606956
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:31"),
                    Latitude = 35.43735956,
                    Longitude = 139.4608097
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:32"),
                    Latitude = 35.43731387,
                    Longitude = 139.4609239
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:33"),
                    Latitude = 35.43727196,
                    Longitude = 139.4610283
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:34"),
                    Latitude = 35.43723522,
                    Longitude = 139.4611293
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:35"),
                    Latitude = 35.43719702,
                    Longitude = 139.4612331
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:36"),
                    Latitude = 35.43715823,
                    Longitude = 139.4613435
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:37"),
                    Latitude = 35.43711948,
                    Longitude = 139.4614524
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:38"),
                    Latitude = 35.43708164,
                    Longitude = 139.4615577
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:39"),
                    Latitude = 35.43704553,
                    Longitude = 139.4616555
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:40"),
                    Latitude = 35.43700566,
                    Longitude = 139.461757
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:41"),
                    Latitude = 35.43695721,
                    Longitude = 139.4618762
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:42"),
                    Latitude = 35.43690501,
                    Longitude = 139.4620074
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:43"),
                    Latitude = 35.43684853,
                    Longitude = 139.4621489
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:44"),
                    Latitude = 35.43679434,
                    Longitude = 139.462286
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:45"),
                    Latitude = 35.43673966,
                    Longitude = 139.4624263
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:46"),
                    Latitude = 35.43668776,
                    Longitude = 139.4625704
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:47"),
                    Latitude = 35.4366413,
                    Longitude = 139.4627162
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:48"),
                    Latitude = 35.43660277,
                    Longitude = 139.462863
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:49"),
                    Latitude = 35.43656648,
                    Longitude = 139.4630106
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:50"),
                    Latitude = 35.43653784,
                    Longitude = 139.4631676
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:51"),
                    Latitude = 35.43651604,
                    Longitude = 139.4633227
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:52"),
                    Latitude = 35.4365019,
                    Longitude = 139.4634889
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:53"),
                    Latitude = 35.43649264,
                    Longitude = 139.4636593
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:54"),
                    Latitude = 35.43648408,
                    Longitude = 139.463834
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:55"),
                    Latitude = 35.43647559,
                    Longitude = 139.4640065
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:56"),
                    Latitude = 35.43646905,
                    Longitude = 139.464181
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:57"),
                    Latitude = 35.4364622,
                    Longitude = 139.4643598
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:58"),
                    Latitude = 35.43645488,
                    Longitude = 139.4645385
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:48:59"),
                    Latitude = 35.43644473,
                    Longitude = 139.4647159
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:00"),
                    Latitude = 35.436436,
                    Longitude = 139.4648864
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:01"),
                    Latitude = 35.43643089,
                    Longitude = 139.465045
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:02"),
                    Latitude = 35.43642256,
                    Longitude = 139.4652197
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:03"),
                    Latitude = 35.43641679,
                    Longitude = 139.4653837
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:04"),
                    Latitude = 35.43641105,
                    Longitude = 139.4655329
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:05"),
                    Latitude = 35.43640386,
                    Longitude = 139.4656783
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:06"),
                    Latitude = 35.43639702,
                    Longitude = 139.4658191
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:07"),
                    Latitude = 35.43639071,
                    Longitude = 139.4659492
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:08"),
                    Latitude = 35.43638523,
                    Longitude = 139.4660713
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:09"),
                    Latitude = 35.43638261,
                    Longitude = 139.4661803
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:10"),
                    Latitude = 35.43638126,
                    Longitude = 139.4662638
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:11"),
                    Latitude = 35.43638067,
                    Longitude = 139.4663195
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:12"),
                    Latitude = 35.43638173,
                    Longitude = 139.4663536
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:13"),
                    Latitude = 35.43638246,
                    Longitude = 139.4663687
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:14"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:15"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:16"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:17"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:18"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:19"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:20"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:21"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:22"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:23"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:24"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:25"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:26"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:27"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:28"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:29"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:30"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:31"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:32"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:33"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:34"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:35"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:36"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:37"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:38"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:39"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:40"),
                    Latitude = 35.43638249,
                    Longitude = 139.4663688
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:41"),
                    Latitude = 35.43638181,
                    Longitude = 139.466389
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:42"),
                    Latitude = 35.43637959,
                    Longitude = 139.4664329
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:43"),
                    Latitude = 35.43637609,
                    Longitude = 139.4665062
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:44"),
                    Latitude = 35.43637353,
                    Longitude = 139.4665835
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:45"),
                    Latitude = 35.43637255,
                    Longitude = 139.4666578
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:46"),
                    Latitude = 35.43637122,
                    Longitude = 139.4667307
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:47"),
                    Latitude = 35.43637108,
                    Longitude = 139.4667986
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:48"),
                    Latitude = 35.43636872,
                    Longitude = 139.4668529
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:49"),
                    Latitude = 35.43635784,
                    Longitude = 139.4668938
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:50"),
                    Latitude = 35.43633103,
                    Longitude = 139.4669271
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:51"),
                    Latitude = 35.4363018,
                    Longitude = 139.4669498
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:52"),
                    Latitude = 35.43627491,
                    Longitude = 139.4669581
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:53"),
                    Latitude = 35.43625175,
                    Longitude = 139.4669575
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:54"),
                    Latitude = 35.43623961,
                    Longitude = 139.4669534
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:55"),
                    Latitude = 35.43623334,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:56"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:57"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:58"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:49:59"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:00"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:01"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:02"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:03"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:04"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:05"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:06"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:07"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:08"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:09"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:10"),
                    Latitude = 35.43623329,
                    Longitude = 139.4669535
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:11"),
                    Latitude = 35.43622509,
                    Longitude = 139.466954
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:12"),
                    Latitude = 35.43619803,
                    Longitude = 139.4669542
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:13"),
                    Latitude = 35.4361516,
                    Longitude = 139.4669538
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:14"),
                    Latitude = 35.43609472,
                    Longitude = 139.4669502
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:15"),
                    Latitude = 35.43603568,
                    Longitude = 139.4669464
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:16"),
                    Latitude = 35.43597616,
                    Longitude = 139.4669429
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:17"),
                    Latitude = 35.43590948,
                    Longitude = 139.4669425
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:18"),
                    Latitude = 35.43584077,
                    Longitude = 139.4669391
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:19"),
                    Latitude = 35.43576978,
                    Longitude = 139.466935
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:20"),
                    Latitude = 35.43569517,
                    Longitude = 139.4669339
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:21"),
                    Latitude = 35.43561486,
                    Longitude = 139.4669322
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:22"),
                    Latitude = 35.43553321,
                    Longitude = 139.4669247
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:23"),
                    Latitude = 35.43545304,
                    Longitude = 139.4669192
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:24"),
                    Latitude = 35.43537911,
                    Longitude = 139.4669139
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:25"),
                    Latitude = 35.43530502,
                    Longitude = 139.4669095
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:26"),
                    Latitude = 35.43523319,
                    Longitude = 139.4669051
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:27"),
                    Latitude = 35.43515407,
                    Longitude = 139.4669055
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:28"),
                    Latitude = 35.43507548,
                    Longitude = 139.4669046
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:29"),
                    Latitude = 35.43499089,
                    Longitude = 139.4669035
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:30"),
                    Latitude = 35.43490924,
                    Longitude = 139.4669035
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:31"),
                    Latitude = 35.43482831,
                    Longitude = 139.4669029
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:32"),
                    Latitude = 35.43474646,
                    Longitude = 139.4668979
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:33"),
                    Latitude = 35.43465623,
                    Longitude = 139.4668949
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:34"),
                    Latitude = 35.43456446,
                    Longitude = 139.4668987
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:35"),
                    Latitude = 35.43447247,
                    Longitude = 139.4669045
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:36"),
                    Latitude = 35.43438572,
                    Longitude = 139.4669068
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:37"),
                    Latitude = 35.43430529,
                    Longitude = 139.4669086
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:38"),
                    Latitude = 35.43422996,
                    Longitude = 139.4669152
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:39"),
                    Latitude = 35.43415741,
                    Longitude = 139.466922
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:40"),
                    Latitude = 35.43408036,
                    Longitude = 139.4669361
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:41"),
                    Latitude = 35.43399291,
                    Longitude = 139.4669655
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:42"),
                    Latitude = 35.43389747,
                    Longitude = 139.4670038
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:43"),
                    Latitude = 35.43379827,
                    Longitude = 139.4670459
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:44"),
                    Latitude = 35.43369399,
                    Longitude = 139.4670901
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:45"),
                    Latitude = 35.43358772,
                    Longitude = 139.4671351
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:46"),
                    Latitude = 35.43348272,
                    Longitude = 139.4671776
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:47"),
                    Latitude = 35.43337477,
                    Longitude = 139.4672211
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:48"),
                    Latitude = 35.43326822,
                    Longitude = 139.4672656
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:49"),
                    Latitude = 35.43315872,
                    Longitude = 139.4673113
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:50"),
                    Latitude = 35.43305255,
                    Longitude = 139.4673556
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:51"),
                    Latitude = 35.43295162,
                    Longitude = 139.4673973
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:52"),
                    Latitude = 35.43285116,
                    Longitude = 139.4674389
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:53"),
                    Latitude = 35.43275898,
                    Longitude = 139.4674781
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:54"),
                    Latitude = 35.43267889,
                    Longitude = 139.4675161
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:55"),
                    Latitude = 35.43260336,
                    Longitude = 139.4675516
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:56"),
                    Latitude = 35.432534,
                    Longitude = 139.4675829
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:57"),
                    Latitude = 35.4324663,
                    Longitude = 139.4676093
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:58"),
                    Latitude = 35.43241322,
                    Longitude = 139.4676326
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:50:59"),
                    Latitude = 35.43236941,
                    Longitude = 139.4676512
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:00"),
                    Latitude = 35.43232613,
                    Longitude = 139.467671
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:01"),
                    Latitude = 35.43228386,
                    Longitude = 139.4676884
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:02"),
                    Latitude = 35.43224164,
                    Longitude = 139.4677068
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:03"),
                    Latitude = 35.43219965,
                    Longitude = 139.4677249
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:04"),
                    Latitude = 35.43216122,
                    Longitude = 139.4677412
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:05"),
                    Latitude = 35.43211757,
                    Longitude = 139.4677601
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:06"),
                    Latitude = 35.43206529,
                    Longitude = 139.467781
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:07"),
                    Latitude = 35.43200162,
                    Longitude = 139.4678092
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:08"),
                    Latitude = 35.43193431,
                    Longitude = 139.4678379
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:09"),
                    Latitude = 35.43186412,
                    Longitude = 139.4678659
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:10"),
                    Latitude = 35.43179378,
                    Longitude = 139.4678957
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:11"),
                    Latitude = 35.43171659,
                    Longitude = 139.4679237
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:12"),
                    Latitude = 35.43163807,
                    Longitude = 139.4679557
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:13"),
                    Latitude = 35.43155869,
                    Longitude = 139.4679891
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:14"),
                    Latitude = 35.43148494,
                    Longitude = 139.4680236
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:15"),
                    Latitude = 35.43140421,
                    Longitude = 139.468051
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:16"),
                    Latitude = 35.43132231,
                    Longitude = 139.4680774
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:17"),
                    Latitude = 35.43124052,
                    Longitude = 139.4681047
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:18"),
                    Latitude = 35.43115095,
                    Longitude = 139.4681306
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:19"),
                    Latitude = 35.43106203,
                    Longitude = 139.4681527
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:20"),
                    Latitude = 35.4309725,
                    Longitude = 139.468171
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:21"),
                    Latitude = 35.43088118,
                    Longitude = 139.4681842
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:22"),
                    Latitude = 35.43079213,
                    Longitude = 139.4681936
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:23"),
                    Latitude = 35.4307012,
                    Longitude = 139.4682016
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:24"),
                    Latitude = 35.43061196,
                    Longitude = 139.4682065
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:25"),
                    Latitude = 35.43052124,
                    Longitude = 139.4682125
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:26"),
                    Latitude = 35.43042984,
                    Longitude = 139.4682128
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:27"),
                    Latitude = 35.43033671,
                    Longitude = 139.4682077
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:28"),
                    Latitude = 35.43024991,
                    Longitude = 139.4682006
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:29"),
                    Latitude = 35.43016665,
                    Longitude = 139.4681927
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:30"),
                    Latitude = 35.43008768,
                    Longitude = 139.4681836
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:31"),
                    Latitude = 35.43001312,
                    Longitude = 139.4681735
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:32"),
                    Latitude = 35.42994713,
                    Longitude = 139.4681649
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:33"),
                    Latitude = 35.42988617,
                    Longitude = 139.4681565
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:34"),
                    Latitude = 35.42982816,
                    Longitude = 139.4681477
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:35"),
                    Latitude = 35.42977665,
                    Longitude = 139.4681404
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:36"),
                    Latitude = 35.42974244,
                    Longitude = 139.4681347
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:37"),
                    Latitude = 35.42972122,
                    Longitude = 139.4681318
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:38"),
                    Latitude = 35.42970613,
                    Longitude = 139.46813
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:39"),
                    Latitude = 35.42969083,
                    Longitude = 139.4681295
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:40"),
                    Latitude = 35.4296771,
                    Longitude = 139.4681272
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:41"),
                    Latitude = 35.42965735,
                    Longitude = 139.4681269
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:42"),
                    Latitude = 35.4296337,
                    Longitude = 139.4681257
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:43"),
                    Latitude = 35.42959649,
                    Longitude = 139.4681202
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:44"),
                    Latitude = 35.42955292,
                    Longitude = 139.4681183
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:45"),
                    Latitude = 35.4295006,
                    Longitude = 139.4681118
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:46"),
                    Latitude = 35.42943878,
                    Longitude = 139.4681049
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:47"),
                    Latitude = 35.4293709,
                    Longitude = 139.4681001
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:48"),
                    Latitude = 35.42930407,
                    Longitude = 139.4680911
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:49"),
                    Latitude = 35.4292348,
                    Longitude = 139.4680821
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:50"),
                    Latitude = 35.42916412,
                    Longitude = 139.4680742
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:51"),
                    Latitude = 35.42909222,
                    Longitude = 139.4680664
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:52"),
                    Latitude = 35.42901748,
                    Longitude = 139.4680584
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:53"),
                    Latitude = 35.42893897,
                    Longitude = 139.4680491
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:54"),
                    Latitude = 35.42885604,
                    Longitude = 139.46804
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:55"),
                    Latitude = 35.42877353,
                    Longitude = 139.4680309
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:56"),
                    Latitude = 35.42868914,
                    Longitude = 139.4680208
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:57"),
                    Latitude = 35.42860079,
                    Longitude = 139.4680118
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:58"),
                    Latitude = 35.42851032,
                    Longitude = 139.468002
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:51:59"),
                    Latitude = 35.42842156,
                    Longitude = 139.4679967
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:00"),
                    Latitude = 35.4283335,
                    Longitude = 139.4679915
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:01"),
                    Latitude = 35.428249,
                    Longitude = 139.4679914
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:02"),
                    Latitude = 35.42816613,
                    Longitude = 139.4679914
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:03"),
                    Latitude = 35.42808457,
                    Longitude = 139.4679941
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:04"),
                    Latitude = 35.42800493,
                    Longitude = 139.4679989
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:05"),
                    Latitude = 35.42792556,
                    Longitude = 139.4680033
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:06"),
                    Latitude = 35.42784843,
                    Longitude = 139.4680106
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:07"),
                    Latitude = 35.42777188,
                    Longitude = 139.4680192
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:08"),
                    Latitude = 35.42769305,
                    Longitude = 139.4680268
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:09"),
                    Latitude = 35.42761432,
                    Longitude = 139.4680379
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:10"),
                    Latitude = 35.42753233,
                    Longitude = 139.4680521
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:11"),
                    Latitude = 35.42744664,
                    Longitude = 139.4680656
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:12"),
                    Latitude = 35.42735956,
                    Longitude = 139.4680817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:13"),
                    Latitude = 35.42727269,
                    Longitude = 139.4680972
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:14"),
                    Latitude = 35.42719102,
                    Longitude = 139.4681134
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:15"),
                    Latitude = 35.42710917,
                    Longitude = 139.4681285
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:16"),
                    Latitude = 35.42703601,
                    Longitude = 139.4681467
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:17"),
                    Latitude = 35.42696687,
                    Longitude = 139.468164
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:18"),
                    Latitude = 35.42690017,
                    Longitude = 139.4681765
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:19"),
                    Latitude = 35.42683335,
                    Longitude = 139.468191
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:20"),
                    Latitude = 35.4267656,
                    Longitude = 139.4682064
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:21"),
                    Latitude = 35.42669502,
                    Longitude = 139.468222
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:22"),
                    Latitude = 35.42662105,
                    Longitude = 139.4682381
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:23"),
                    Latitude = 35.42654067,
                    Longitude = 139.4682532
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:24"),
                    Latitude = 35.426456,
                    Longitude = 139.4682686
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:25"),
                    Latitude = 35.42636775,
                    Longitude = 139.4682858
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:26"),
                    Latitude = 35.42627796,
                    Longitude = 139.468301
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:27"),
                    Latitude = 35.42618771,
                    Longitude = 139.4683168
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:28"),
                    Latitude = 35.42610162,
                    Longitude = 139.468335
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:29"),
                    Latitude = 35.42601491,
                    Longitude = 139.4683529
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:30"),
                    Latitude = 35.42592968,
                    Longitude = 139.4683691
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:31"),
                    Latitude = 35.42584511,
                    Longitude = 139.4683818
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:32"),
                    Latitude = 35.42576299,
                    Longitude = 139.468396
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:33"),
                    Latitude = 35.42568264,
                    Longitude = 139.4684105
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:34"),
                    Latitude = 35.42560392,
                    Longitude = 139.4684267
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:35"),
                    Latitude = 35.42552952,
                    Longitude = 139.4684382
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:36"),
                    Latitude = 35.4254547,
                    Longitude = 139.4684521
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:37"),
                    Latitude = 35.42539272,
                    Longitude = 139.4684672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:38"),
                    Latitude = 35.42535145,
                    Longitude = 139.4684953
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:39"),
                    Latitude = 35.4253255,
                    Longitude = 139.4685259
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:40"),
                    Latitude = 35.42530615,
                    Longitude = 139.4685615
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:41"),
                    Latitude = 35.42529205,
                    Longitude = 139.4685916
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:42"),
                    Latitude = 35.42528358,
                    Longitude = 139.4686208
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:43"),
                    Latitude = 35.42527655,
                    Longitude = 139.4686505
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:44"),
                    Latitude = 35.42527256,
                    Longitude = 139.4686904
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:45"),
                    Latitude = 35.42526919,
                    Longitude = 139.4687339
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:46"),
                    Latitude = 35.42526727,
                    Longitude = 139.4687672
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:47"),
                    Latitude = 35.42526546,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:48"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:49"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:50"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:51"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:52"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:53"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:54"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:55"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:56"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:57"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:58"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:52:59"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:00"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:01"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:02"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:03"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:04"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:05"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:06"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:07"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:08"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:09"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:10"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:11"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:12"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:13"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:14"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:15"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:16"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:17"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:18"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:19"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:20"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:21"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:22"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:23"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:24"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:25"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:26"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:27"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:28"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:29"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:30"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:31"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:32"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:33"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:34"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:35"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:36"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:37"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:38"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:39"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:40"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:41"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:42"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:43"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:44"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:45"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:46"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:47"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:48"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:49"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:50"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:51"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:52"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:53"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:54"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:55"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:56"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:57"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:58"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:53:59"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:00"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:01"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:02"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:03"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:04"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:05"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:06"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:07"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:08"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:09"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:10"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:11"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:12"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:13"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
                new Position
                {
                    Timestamp = DateTimeOffset.Parse(",2017-01-25 08:54:14"),
                    Latitude = 35.42526545,
                    Longitude = 139.4687817
                },
            };
    }
}