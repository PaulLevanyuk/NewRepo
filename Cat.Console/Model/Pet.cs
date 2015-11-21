using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    
       
        public class Cat
        {
            private string _name=null;
            public string Age { get; }
            public CatColor Color { get ; set; } = new CatColor();
            private int _health = 5;
            public Cat(string age)
            {
                Age = age;
            }
        
        
        
            public string Name
            {
                get
                {
                    return _name;
                }

                set
                {
                    if (string.IsNullOrEmpty(_name))
                   
                    _name = value;
                    
                }
            }

            public string CurrentColor
            {
                get
                {
                    if (_health >= 5)
                    {
                        return Color.HealthyColor;
                    }
                    else
                    {
                        return Color.SickColor;
                    }
                }
            }

            
            
            public void Feed()
            {
                _health++;
            }

            public void Punish()
            {
                _health--;
            }

           

        }
    }

