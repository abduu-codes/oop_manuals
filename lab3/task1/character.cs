using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class character
{
            public string name;
            public int health;
            public int damage;
            public character(character c)
            {
            this.name = c.name; 
            this.health = c.health;
            this.damage = c.damage;
            }
    public character(string name, int health, int damage)
            {
                this.name = name;
                this.health = health;
                this.damage = damage;
            }
    public void attack()
    {

    }        
}

    
