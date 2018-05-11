using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Champ_choice
{
    public class Image
    {
        public string Name { get; set; }
        public string Caption { get; set; }

        public Command TapCommand { get; set; }

        public EventHandler TapClickEventHandler;

        public Image()
        {
            TapCommand = new Command(() => OnImageClicked());
        }

        public void OnImageClicked()
        {
            TapClickEventHandler?.Invoke(this, EventArgs.Empty);
        }
    }
}