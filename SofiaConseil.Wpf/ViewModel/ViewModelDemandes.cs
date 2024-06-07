using SofiaConseil.DbLib.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SofiaConseil.Wpf.ViewModel
{
    internal class ViewModelDemandes : ViewModelBase
    {
        public ObservableCollection<Demande> Demandes { get; set; }
        public ObservableCollection<Freelance> Freelances { get; set; }

        public ObservableCollection<Statut> Statuts { get; set; }


        private Demande? _selectedDemande;
        public Demande? SelectedDemande 
        { 
            get => _selectedDemande; 
            set 
            { 
                _selectedDemande = value; 
                OnPropertyChanged();
                UpdateSelectedFreelance();
            }
        }

        private Freelance? _selectedFreelance;
        public Freelance? SelectedFreelance 
        { 
            get => _selectedFreelance; 
            set 
            { 
                _selectedFreelance = value; 
                OnPropertyChanged();
            }
        }

        public ViewModelDemandes()
        {
            using (SofiaConseilContext context = new())
            {
                Demandes = new ObservableCollection<Demande>(context.Demandes);
                Freelances = new ObservableCollection<Freelance>(context.Freelances);
                Statuts = new ObservableCollection<Statut>(context.Statuts);
            }
        }

        public void UpdateDemande()
        {
            using (SofiaConseilContext context = new())
            {
                if (SelectedDemande is not null)
                {
                    // Récupérer l'objet Demande dans le contexte de la base de données
                    var demandeToUpdate = context.Demandes.Find(SelectedDemande.Id);

                    // Mettre à jour les propriétés de l'objet Demande avec les valeurs de l'objet SelectedDemande
                    context.Entry(demandeToUpdate).CurrentValues.SetValues(SelectedDemande);

                    // Sauvegarder les modifications
                    context.SaveChanges();
                }
            }
        }


        private void UpdateSelectedFreelance()
        {
            if (SelectedDemande != null && SelectedDemande.IdFreelances.HasValue)
            {
                SelectedFreelance = Freelances.FirstOrDefault(f => f.Id == SelectedDemande.IdFreelances.Value);
            }
            else
            {
                SelectedFreelance = null;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
