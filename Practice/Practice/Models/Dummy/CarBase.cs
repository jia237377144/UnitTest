using System;
namespace Practice.Models.Dummy
{
    public class CarBase:ICar
    {
        protected IEngine engine;
        protected string name;
        public CarBase(IEngine engine,string name)
        {
            this.engine = engine;
            this.name = name;
        }

        public string Start()
        {
            this.engine.Start();
            return this.name;
        }
    }
}
