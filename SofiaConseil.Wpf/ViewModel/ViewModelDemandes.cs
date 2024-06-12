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

<<<<<<< Updated upstream
=======
        public ObservableCollection<Materiel> Materiels { get; set; } // Ajouter ces ligne pour charger les matériels
        public ObservableCollection<Materiel> SelectedMateriels { get; set; } = new ObservableCollection<Materiel>();


>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
=======
                Materiels = new ObservableCollection<Materiel>(context.Materiels); // Ligne ajouter
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
                    // Sauvegarder les modifications
=======
                    // Mettre à jour les matériels associés
                    demandeToUpdate.Materielsdemandes.Clear();
                    foreach (var materiel in SelectedMateriels)
                    {
                        demandeToUpdate.Materielsdemandes.Add(new Materielsdemande
                        {
                            IdDemandes = demandeToUpdate.Id,
                            IdMateriels = materiel.Id
                        });
                    }

>>>>>>> Stashed changes
                    context.SaveChanges();
                }
            }
        }


<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
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
