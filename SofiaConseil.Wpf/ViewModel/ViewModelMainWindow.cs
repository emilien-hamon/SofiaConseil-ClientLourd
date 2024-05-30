using SofiaConseil.DbLib.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaConseil.Wpf.ViewModel
{
    internal class ViewModelMainWindow : ViewModelBase
    {
        public string Email { get; set; }


        public ViewModelMainWindow()
        {
            using (SofiaConseilContext context = new())
            {
                Email = context.Users.First().Email;
            }
        }

    }
}
