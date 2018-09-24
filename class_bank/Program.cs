using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.Display();
            Console.Read();
        }
    }
  
    class Building
    {

        private int  number = 5;
        private double height = 20; //высота
        private int floor = 9; // кол-во этажей
        private int apartment = 180; //кол-во квартир 
        private int entrance = 4; //кол-во подъездов
        
        public double Floorheight() // метод вычисления высоты этажа
        {
            double floorheight = height / floor; 
            return floorheight;
        }
        public int ApartmentNumber() // метод вычисления кол-ва квартир в подъезде
        {
        int apartmentNumber = apartment / entrance;
        return apartmentNumber;
        }
        public int ApartmentFloorNumber() // метод вычисления кол-ва квартир на этаже
        {
            int apartmentFloorNumber = ApartmentNumber() / floor;
            return apartmentFloorNumber;
        }
        public void Number() // метод генерации номера дома
        {
            number = number++;
        }
        public void Display()
        {
            Console.WriteLine($"высота = {height} м,\nколичество этажей = {floor}\nвысота одного этажа = {Floorheight()} м,\n{ApartmentNumber()} квартир в подъезде," +
                $"\n{ApartmentFloorNumber()} квартир на этаже\nномер дома {number}"); 
        } 
    }
}
