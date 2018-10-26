using System;
namespace Session2Class
{
    public class Dog
    {
        //properties
        public string name;
        public string ownerName;
        public string color;
        public int age;
        public int weight;

        //instruction
        public Dog(string _name,string _ownerName,string _color,int _age,int _weight)
        {
            name = _name;
            ownerName = _ownerName;
            color = _color;
            age = _age;
            weight = _weight;
            
        }

        //function
        public string GetDogName()
        {
            return "The dog's name is " + name;
        }

        public string GetDogOwnerName()
        {
            return "The dog's owner is " + ownerName;
        }

        public string GetDogColor()
        {
            return "The dog's color is " + color;
        }

        public string GetDogAge()
        {
            string ages = age.ToString();
            return "The dog's age is " + ages;
        }

        public string GetDogweight()
        {
            string weights = weight.ToString();
            return "The dog's weight is " + weights;
        }

    }
}
