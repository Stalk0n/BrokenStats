using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace BrokenStats.ViewModels
{
    public class ChartViewModel : ObservableObject
    {
        public ISeries[] Series { get; set; } =
        {
            new LineSeries<double>
            {
                Values = new double[] { 5, 0, 5, 0, 5, 0 },
                Fill = null,
                GeometrySize = 0,
                LineSmoothness = 0 
            },
        };
    }
}
