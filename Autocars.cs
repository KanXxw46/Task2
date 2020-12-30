using System;
using System.Collections.Generic;
using System.Text;

namespace AutoWashingCar
{
    public interface ICars
    {
        ICars Clone();
        void getInfo();
    }
    public class Boks1 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks1(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks1(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks1 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }

    public class Boks2 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks2(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks2(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks2 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }
    public class Boks3 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks3(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks3(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks3 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }
    public class Boks4 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks4(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks4(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks4 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }
    public class Boks5 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks5(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks5(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks5 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }
    public class Boks6 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks6(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks6(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks6 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("A")}");
        }
    }
    public class Boks7 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks7(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks7(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks7 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("Б")}");
        }
    }
    public class Boks8 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks8(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks8(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks8 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("Б")}");
        }
    }
    public class Boks9 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks9(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks9(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks9 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("Б")}");
        }
    }
    public class Boks10 : ICars
    {
        int Namber;
        int Name;
        int Surname;
        int Category;
        public Boks10(int namber, int name, int surname, int category)
        {
            Namber = namber;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public ICars Clone()
        {

            return new Boks10(Namber, Name, Surname, Category);
        }

        public void getInfo()
        {
            Console.WriteLine($"Boks10 : {Namber.ToString()},Name :{Name.ToString()},Surname: {Surname.ToString()},Category: {Category.ToString("Б")}");
        }
    }
}
