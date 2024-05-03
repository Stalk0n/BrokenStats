 using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers; // Dodaj using dla przestrzeni nazw Timer
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using BrokenStats.Tables;

namespace BrokenStats.ViewModels
{
    public class ChartViewModel : ObservableObject
    {
        private List<double> _xpValues = new List<double>();
        private LogsContext _dbContext;
        private System.Timers.Timer _timer; // Użyj System.Timers.Timer

        public ISeries[] Series { get; set; }

        public ChartViewModel()
        {
            _dbContext = new LogsContext();
            InitializeSeries();
            InitializeTimer();
        }

        private void InitializeSeries()
        {
            // Początkowo tworzymy pusty szereg danych
            _xpValues = Enumerable.Repeat(0.0, 20).ToList(); // 20 punktów, początkowo ustawionych na 0

            Series = new ISeries[]
            {
                new LineSeries<double>
                {fe
                    Values = _xpValues,
                    GeometrySize = 0,
                    LineSmoothness = 0
                }
            };
        }

        private void InitializeTimer()
        {
            _timer = new System.Timers.Timer(); // Użyj pełnej nazwy klasy
            _timer.Interval = 3000; // Czasomierz uruchamiany co 3 sekundy
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = true;
            _timer.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Pobierz nowe dane z bazy danych i zaktualizuj wykres
            var xpData = _dbContext.XPtable.OrderBy(x => x.LogId).Select(x => (double)x.Experience).ToList();
            UpdateData(xpData);
        }

        public void UpdateData(IEnumerable<double> xpValues)
        {
            // Aktualizujemy dane na wykresie
            _xpValues = xpValues.ToList();
            Series[0].Values = _xpValues;
        }
    }
}