using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWar.Models
{
    internal class People
    {
    public String Name { get; set; }
    public int Height { get; set; }
    public int Mass { get; set; }
    public String Gender { get; set; }

    public People (String name, int height, int mass, String gender)
    {
        Name = name;
       Height = height;
        Mass = mass;
        Gender = gender;
    }
}
}
