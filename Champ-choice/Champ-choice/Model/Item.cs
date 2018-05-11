using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Champ_choice.Model
{
    internal class Item : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _title;

        [JsonProperty("title")] //Map the element title to model
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(); //When update, notify
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}