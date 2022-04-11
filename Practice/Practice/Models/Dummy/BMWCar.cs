using System;
namespace Practice.Models.Dummy
{
    public class BMWCar:CarBase,ICar
    {
        public BMWCar(IEngine engine,string name):base(engine,name)
        {
        }

        
    }
}
