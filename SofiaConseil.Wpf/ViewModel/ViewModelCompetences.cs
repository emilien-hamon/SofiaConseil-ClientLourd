using SofiaConseil.DbLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaConseil.Wpf.ViewModel
{
    internal class ViewModelCompetences :ViewModelBase
    {
        public ObservableCollection<Competence> Competences { get; set; }

        public Competence? SelectedCompetence { get; set; }


        public ViewModelCompetences()
        {
            using (SofiaConseilContext context = new())
            {
                Competences = new ObservableCollection<Competence>(context.Competences);
            }
        }

        public void AddCompetence()
        {
            Competence competence = new();
            competence.Nom = "Nouvelle compétence";
            competence.Description = "Description de la nouvelle compétence";
            competence.CreatedAt = DateTime.Now;
            competence.UpdatedAt = DateTime.Now;

            using (SofiaConseilContext context = new())
            {
                context.Add(competence);
                context.SaveChanges();
                Competences.Add(competence);
            }
        }
    }
}
