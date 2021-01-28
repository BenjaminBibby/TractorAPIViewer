using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TractorAPIViewer.Models.Tractor;
using TractorAPIViewer.Services.Interfaces;

namespace TractorAPIViewer.Services.Mock
{
    public class MockTractorService : ITractorService
    {
        public MockTractorService()
        {
        }

        public async Task<Tractor> GetTractorAsync(int id) => await Task.FromResult(new Tractor());

        public Task<IEnumerable<Brand>> GetTractorBrandsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tractor>> GetTractorsAsync(int brandId)
            => await Task.FromResult<IEnumerable<Tractor>>(
                new ItemCollection<Tractor>()
                    {
                        Items = new List<Tractor>()
                        { 
                            new Tractor(){ Brand = "Mercedes", Model = "U400", YearProduced = 1967, YearEnded = 1972, Engine = new Engine(){ Horsepower = 22 } },
                            new Tractor(){ Brand = "Mercedes", Model = "U400", YearProduced = 1967, YearEnded = 1972, Engine = new Engine(){ Horsepower = 22 } },
                            new Tractor(){ Brand = "Mercedes", Model = "U400", YearProduced = 1967, YearEnded = 1972, Engine = new Engine(){ Horsepower = 22 } },
                            new Tractor(){ Brand = "Mercedes", Model = "U400", YearProduced = 1967, YearEnded = 1972, Engine = new Engine(){ Horsepower = 22 } },
                            new Tractor(){ Brand = "Mercedes", Model = "U400", YearProduced = 1967, YearEnded = 1972, Engine = new Engine(){ Horsepower = 22 } }
                        }
                    }.Items
                );
    }
}