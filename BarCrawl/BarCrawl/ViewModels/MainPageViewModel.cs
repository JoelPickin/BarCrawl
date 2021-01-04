using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarCrawl.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string TestLabel { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            InitialSetup();
        }

        private void InitialSetup()
        {
            Location = "Newcastle";
            Date = DateTime.Now;
            StartTime = TimeSpan.FromHours(12);
            EndTime = TimeSpan.FromHours(16);
        }
    }
}
