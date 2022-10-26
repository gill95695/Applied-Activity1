using StarWar.Models;
using StarWar.Services;
using System;
using StarWar.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace StarWar.ViewModels
{
    internal class StarWarViewModel 
    {
       
            public IStarWarDataStore<People> DataStore =>
                        DependencyService.Get<IStarWarDataStore<People>>();
            public ObservableRangeCollection<People> Persons { get; set; }
            public AsyncCommand PageAppearingCommand { get; }

            public StarWarViewModel()
            {
              Persons = new ObservableRangeCollection<People>();
                PageAppearingCommand = new AsyncCommand(PageAppearing);

            }
            public async Task Refresh()
            {
                var persons = await DataStore.GetPeopleAsync(20);
                Persons.AddRange(persons);
            }
            async Task PageAppearing()
            {
                await Refresh();
            }
        }
    }


