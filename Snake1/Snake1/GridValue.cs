using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    public enum GridValue //enum for snake body
    {
        Empty, //fro empty grid
        Snake, //for snake body
        Food,//for snake food
        Outside//the border of game
    }
}
