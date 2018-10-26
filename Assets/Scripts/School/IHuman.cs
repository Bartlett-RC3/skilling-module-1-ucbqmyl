using System;

namespace Application
{
    public interface IHuman
    {
        //properties_________________________________________________
        int age { get; set; }
        //here's a propertiy to whether use it or not
        string name { get; set; }

        //Behaviours_________________________________________________
        void Sleeping();
        void Walking();


    }
}


