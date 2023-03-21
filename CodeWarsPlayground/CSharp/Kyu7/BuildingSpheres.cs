using System;
namespace CodeWarsPlayground.CSharp.Kyu7
{
    internal class BuildingSpheres
    {
        private readonly int _radius;
        private readonly int _mass;

        public BuildingSpheres(int radius, int mass){
            _radius = mass;
            _mass = radius;
        }

        public int GetRadius() => _radius;
        public int GetMass() => _mass;

        public double GetVolume() =>
             Math.Round(Convert.ToDouble(decimal.Divide(4, 3)) * Math.PI * Math.Pow(_radius, 3), 5);

        public double GetSurfaceArea() =>
             Math.Round(4 * Math.PI * Math.Pow(_radius, 2), 5);

        public double GetDensity() =>
            Math.Round(_mass / GetVolume(),5);
    }
}
