using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    abstract class ArtPiece
    {
        public string Title;
        public string Artist;
        public int YearCreated;
        public abstract void Describe();
      
    }
    class Painting:ArtPiece
    {
        public int CanvasSize;
        public override void Describe()
        {
           Console.WriteLine("Painting: {0} by {1}, created in {2}, size:{3}" , Title, Artist, YearCreated, CanvasSize);
        }
    }
    class Sculpture:ArtPiece
    {
        public string material;
        public override void Describe()
        {
            Console.WriteLine("Sculpture: {0} by {1}, created in {2}, made of {3}" , Title, Artist, YearCreated, material);
        }
    }
}