using System;

namespace getterstters
{
    public class Player
    {
        private int _lives = 0;
        public int lives
        {
            get
            {
                return _lives;
            }
            
        }
        private int _points = 0;
        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                if(value >= 100)
                {
                    value %= 100;
                    _lives += 1;
                }
                else if(value <= 0)
                {
                     value = 0;
                }
                
                _points = value;
            }
        }
        private string _name = "John";
        public string  name
        {
            get
            {
                return name;
            }
        }


        private void jump()
        {
            Console.WriteLine("SPRINGEN");
        }
        private void walk()
        {   
            Console.WriteLine("LOPEN");
        }
    }
}
