using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZindanMaceracisi
{
    public abstract class Skill
    {
        public string Name { get; }
        public int MPCost { get; }

        protected Skill(string name, int mpCost)
        {
            Name = name;
            MPCost = mpCost;
        }

        public abstract int Use(Character user, ICharacter target);
        
    }
}
