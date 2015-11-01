using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
       
        public class Cat
        {
           public  CatColor catcolor = new CatColor();
            private string _name;
            public readonly string Age;
         
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
                        return catcolor.HealthyColor;
                    }
                    else
                    {
                        return catcolor.SickColor;
                    }
                }
            }
            public CatColor Color { get ; set; }
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

