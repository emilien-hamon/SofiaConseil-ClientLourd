using SofiaConseil.DbLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SofiaConseil.Wpf.ViewModel
{
    internal class ViewModelMateriels
    {
        public ObservableCollection<Materiel> Materiels { get; set; }

        public Materiel? SelectedMateriel { get; set; }


        public ViewModelMateriels()
        {
            using (SofiaConseilContext context = new())
            {
                Materiels = new ObservableCollection<Materiel>(context.Materiels);
            }
        }

        public void AddMateriel()
        {
            Materiel materiel = new();
            materiel.Nom = "Nom";
            materiel.Description = "Description";
            materiel.AdMac = "Adresse MAC";
            materiel.CreatedAt = DateTime.Now;
            materiel.UpdatedAt = DateTime.Now;

            using (SofiaConseilContext context = new())
            {
                context.Add(materiel);
                context.SaveChanges();
                Materiels.Add(materiel);
            }
        }

        public void RemoveMateriel()
        {
            if (SelectedMateriel is not null)
            {
                using (SofiaConseilContext context = new())
                {
                    context.Materiels.Remove(SelectedMateriel);
                    context.SaveChanges();
                    Materiels.Remove(SelectedMateriel);
                }
            }
        }

        /*public void UpdateMateriel()
        {
            if (Selectednce is not null)
            {
                using (SofiaConseilContext context = new())
                {
                    context.Competences.Update(SelectedMateriel);
                    context.SaveChanges();
                }
            }
        }*/
    }
}
