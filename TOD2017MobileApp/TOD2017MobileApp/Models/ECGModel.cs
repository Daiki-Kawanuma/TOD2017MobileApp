using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using TOD2017MobileApp.Utils;

namespace TOD2017MobileApp.Models
{
    public class ECGModel
    {
        public IList<GraphDatum> GraphData { get; set; }
        public string AtentionText { get; set; }

        public static ECGModel GetECGModel(SemanticLink semanticLink)
        {
            var data = Realm.GetInstance()
                .All<GraphDatum>()
                .Where(v => v.SemanticLinkId == semanticLink.SemanticLinkId)
                .ToList();

            var quartilesEnergy = MathUtil.Quartiles(data.OrderBy(d => d.LostEnergy).Select(d => (double)d.LostEnergy).ToArray());
            var firstQuartileEnergy = quartilesEnergy.Item1;
            var thirdQuartileEnergy = quartilesEnergy.Item3;
            var iqrEnergy = thirdQuartileEnergy - firstQuartileEnergy;

            var quartilesTransitTime = MathUtil.Quartiles(data.OrderBy(d => d.TransitTime).Select(d => (double)d.TransitTime).ToArray());
            var firstQuartileTransitTime = quartilesTransitTime.Item1;
            var thirdQuartileTransitTime = quartilesTransitTime.Item3;
            var iqrTransitTime = thirdQuartileTransitTime - firstQuartileTransitTime;

            data = data.Where(d => d.LostEnergy > firstQuartileEnergy - 1.5 * iqrEnergy)
                .Where(d => d.LostEnergy < thirdQuartileEnergy + 1.5 * iqrEnergy)
                .ToList();

            data = data.Where(d => d.TransitTime > firstQuartileTransitTime - 1.5 * iqrTransitTime)
                .Where(d => d.TransitTime < thirdQuartileTransitTime + 1.5 * iqrTransitTime)
                .ToList();

            string atentionText = null;
            switch (semanticLink.SemanticLinkId)
            {
                case 191:
                    atentionText = "加減速を減らして！";
                    break;
                case 196:
                    atentionText = "回生ブレーキに注意！";
                    break;
                case 207:
                    atentionText = "加減速を減らして！";
                    break;
                case 209:
                    atentionText = "回生ブレーキに注意！";
                    break;
            }

            return new ECGModel{ GraphData = data, AtentionText = atentionText };
        }
    }
}
