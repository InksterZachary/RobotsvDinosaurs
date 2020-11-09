using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_Vs_Dinosaurs
{
    class Fleet
    {
        List<Robot> roboTeam = new List<Robot>();
        Robot cyborg = new Robot("Cyborg",100,200,"Laser Rifle");
        Robot metalHead = new Robot("Metal Head", 200, 100, "Shot Gun");
        Robot terminator = new Robot("Terminator", 500, 250, "Gatling Gun");
    }
}
