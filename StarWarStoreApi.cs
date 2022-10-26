using Newtonsoft.Json;
using StarWar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWar.Services
{
    internal class StarWarStoreApi : IStarWarDataStore<People>
    {


        private static string API => "https://swapi.dev/api/people";
            public async Task<IEnumerable<People>> GetPeopleAsync(int count)
            {
                var service = DependencyService.Get<IWebClientService>();
                var json = await service.GetAsync($"{API}?result={count}");
                var persons = PeopleBuilder(json);
                return persons;
            }
            private List<People> PeopleBuilder(string json)

            {
                var response = JsonConvert.DeserializeObject<dynamic>(json);
                var people = response.results;

                var persons = new List<People>();
                foreach (var person in persons)
                {
                    var name = people.name.ToString();
                    var height = people.height.ToString();
                    var mass = people.Mass.ToString();
                    var gender = people.gender.ToString();
                    persons.Add(new People(name, height, mass, gender));
                }
                return persons;
            }


    }
}

