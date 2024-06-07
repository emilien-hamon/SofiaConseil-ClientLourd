using SofiaConseil.DbLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaConseil.Wpf.ViewModel
{
    internal class ViewModelFreelances : ViewModelBase
    {
        public ObservableCollection<Freelance> Freelances { get; set; }

        public Freelance? SelectedFreelance { get; set; }

        public ViewModelFreelances()
        {
            using (SofiaConseilContext context = new())
            {
                Freelances = new ObservableCollection<Freelance>(context.Freelances);
            }
        }

        public void AddFreelance()
        {
            Freelance freelance = new();
            freelance.Nom = "Nouveau collaborateur";
            freelance.Description = "Description du nouveau collaborateur";
            freelance.Experience = "Experience du nouveau collaborateur";
            freelance.CreatedAt = DateTime.Now;
            freelance.UpdatedAt = DateTime.Now;

            using (SofiaConseilContext context = new())
            {
                context.Add(freelance);
                context.SaveChanges();
                Freelances.Add(freelance);
            }
        }
        public void RemoveFreelance()
        {
            if (SelectedFreelance is not null)
            {
                using (SofiaConseilContext context = new())
                {
                    context.Freelances.Remove(SelectedFreelance);
                    context.SaveChanges();
                    Freelances.Remove(SelectedFreelance);
                }
            }
        }

        public void UpdateFreelance()
        {
            if (SelectedFreelance is not null)
            {
                using (SofiaConseilContext context = new())
                {
                    context.Freelances.Update(SelectedFreelance);
                    context.SaveChanges();
                }
            }
        }

    }
}
