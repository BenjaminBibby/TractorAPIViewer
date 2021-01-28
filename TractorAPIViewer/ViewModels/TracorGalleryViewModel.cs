using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ninject;
using TractorAPIViewer.Interfaces.Holders;
using TractorAPIViewer.Models.Tractor;
using TractorAPIViewer.Services.Interfaces;

namespace TractorAPIViewer.ViewModels
{
    public class TracorGalleryViewModel : BaseViewModel, ITractorHolder
    {
        [Inject] public ITractorService TractorService;

        public IEnumerable<Tractor> Tractors { get; set; }
        public IEnumerable<Tractor> VisibleTractors { get; set; }

        public event Action<Tractor> OnTractorFetched;

        // Fetch events
        public event Action<Tractor> OnTractorClicked;
        public event Action<IEnumerable<Tractor>> OnTractorsFetched;

        public TracorGalleryViewModel()
        {
            if (this.TractorService == null)
                this.TractorService = App.Container.Get<ITractorService>();
        }

        public async Task<Tractor> GetTractorAsync(int id)
        {
            try
            {
                if (this.TractorService == null)
                    return null;

                var tractor = await this.TractorService.GetTractorAsync(id);
                OnTractorFetched?.Invoke(tractor);
                return tractor;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Tractor>> GetTractorsAsync(int brandId)
        {
            try
            {
                StartSpinner();

                if (this.TractorService == null)
                    return null;

                var tractors = await this.TractorService.GetTractorsAsync(brandId);
                OnTractorsFetched(tractors);
                return tractors;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                StopSpinner();
            }
        }

        public void TractorClicked(Tractor tractor) 
            => OnTractorClicked?.Invoke(tractor);
    }
}