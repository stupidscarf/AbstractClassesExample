using System;

namespace _05._05._22
{
    abstract class Animal
    {
        protected string cry;
        public Animal(string someSound)
        { 
            cry = someSound;
        }
    }
    class Spider : Animal
    {
        private bool _poison;
        public Spider(bool poison, string someSound) : base(someSound)
        {
            _poison = poison;
        }
    }
}
