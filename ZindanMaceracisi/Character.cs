using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZindanMaceracisi
{
    public abstract class Character : ICharacter
    {
        public string Name { get; }

        public int HP { get; set; }

        public int MaxHP { get; protected set; }

        public int MP { get; set; }

        public int MaxMP { get; protected set; }

        public int Level { get; protected set; }
        protected Random Random { get; } = new Random();

        public List<Skill> Skills { get; } = new List<Skill>();

        protected Character(string name, int maxHP, int maxMP, int level)
        {
            Name = name;
            MaxHP = maxHP;
            MaxMP = maxMP;
            Level = level;
        }

        public virtual void Attact(ICharacter target)
        {
            int damage = Random.Next(Level, Level * 2);
            ConsoleHelper.WriteLineColored($"SALDIRI:{Name},{target.Name}'e {damage} hasar veriyor...BAM!", ConsoleColor.Yellow);
            target.TakeDamage(damage);
        }

        public virtual void TakeDamage(int damage)
        {
            HP = HP - damage;
            ConsoleHelper.WriteLineColored($"HASAR:{Name} {damage} hasar alıyor.Ayyyyyyy. Kalan HP:{HP}", ConsoleColor.Red);
        }

        public virtual void UseSkill(Skill skill, ICharacter target)
        {
            if (MP >= skill.MPCost)
            {
                MP -= skill.MPCost;
                int damage = skill.Use(this, target);
                ConsoleHelper.WriteLineColored($"BECERİ {Name},{target.Name}'e karşı {skill.Name} becerisini kullanıyor {damage} hasar!", ConsoleColor.Cyan);

                if (damage > 0)
                {
                    target.TakeDamage(damage);
                }
                else
                {
                    ConsoleHelper.WriteLineColored($"HATA oops. {Name}'in {skill.Name} beceirisni kullanmak için yeterli MP'si yok", ConsoleColor.DarkRed);
                }
            }
        }
    }
}
