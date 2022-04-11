using System;
namespace Practice.Models.Dummy
{
    public class FutureCar:CarBase,ICar
    {
        public FutureCar(IEngine engine,string name):base(engine,name)
        {
        }

    }
}
