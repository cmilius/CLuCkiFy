using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CLuCkiFy.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        public MainPageViewModel()
        {
            Cluckify = new Command(async () => await CluckifyText());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Title { get; set; } = "CLuCkiFy";
        public string Directions { get; set; } = "Enter in some text and hit cluckify";
        public string CLuCk { get; set; }

        public Command Cluckify { get; }    

        async Task CluckifyText()
        {
            var cLucKEd = "";

            foreach(char c in CLuCk)
            {
                var r = new Random();
                int rInt = r.Next(0, 2);

                cLucKEd +=  rInt==0 ? c.ToString().ToLower() : c.ToString().ToUpper();
            }

            CLuCk = cLucKEd;

            OnPropertyChanged(nameof(CLuCk));
            
        }
    }
}
