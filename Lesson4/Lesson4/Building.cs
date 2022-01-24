using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Building
    {
        private int _id;
        private double _height;
        private int _floors;
        private int _apartments;
        private int _entrances;
        static public int number = 1;
        public int Id { get { return _id; } }
        public double Height { get { return _height;} set { _height = value; } }
        public int Floors { get { return _floors; } set { _floors = value; } }
        public int Apartments { get { return _apartments; } set { _apartments = value; } }
        public int Entrances { get { return _entrances; } set { _entrances = value; } }

        public Building()
        {
            _id = number;
            number++;
        }

        public Building(double height,int floor,int apartments, int entrances)
        {
            _height = height;
            _floors = floor;
            _apartments = apartments;
            _entrances = entrances;
            _id = number;
            number++;
        }

        public double GetHeightFloor(double height , int floors)
        {
            return height/floors;
        }
        public int CountApartmentsInEntrance(int entrances, int apartments)
        {            
           return apartments/entrances;
        }
        public double CountApartmentsToFloor(int apartments, int floors)
        {
            return apartments/floors;
        }
    }
}
