using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace TOD2017MobileApp.Models
{
    public class SemanticLink : RealmObject
    {
        public static IList<SemanticLink> TargetSemanticLinks = new List<SemanticLink>
        {
            new SemanticLink
            {
                SemanticLinkId = 191,
                Semantics = "None",
                MinLatitude = 35.42603918,
                MaxLatitude = 35.43633438,
                MinLongitude = 139.4668446,
                MaxLongitude = 139.4683016
            },
            new SemanticLink
            {
                SemanticLinkId = 196,
                Semantics = "None",
                MinLatitude = 35.45074488,
                MaxLatitude = 35.45429267,
                MinLongitude = 139.5206251,
                MaxLongitude = 139.5331955
            },
            new SemanticLink
            {
                SemanticLinkId = 207,
                Semantics = "None",
                MinLatitude = 35.46304083,
                MaxLatitude = 35.46913823,
                MinLongitude = 139.533574,
                MaxLongitude = 139.5415328
            },
            new SemanticLink
            {
                SemanticLinkId = 209,
                Semantics = "None",
                MinLatitude = 35.47433081,
                MaxLatitude = 35.48207426,
                MinLongitude = 139.5010665,
                MaxLongitude = 139.5132386
            },
        };

        public int SemanticLinkId { get; set; }
        public string Semantics { get; set; }
        public double MinLatitude { get; set; }
        public double MaxLatitude { get; set; }
        public double MinLongitude { get; set; }
        public double MaxLongitude { get; set; }
    }
}
