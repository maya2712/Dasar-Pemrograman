using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Player
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int attackPower { get; set; }
        public float Exp { get; set; }
        public bool isDead { get; set; }
        public bool isRunningAway { get; set; }
        public int Level { get; set; }
        public int JobPoint { get; set; }
        public int Stamina { get; set; }
        public Random rnd = new Random();

        public Player(){
            Health = 500;
            attackPower = 50;
            Exp = 0.0f;
            Stamina = 0;
            Level = 1;
            JobPoint = 0;
        }

        public virtual void Skill(Enemy enemy)
        {
            Console.WriteLine("Skill : Berserk");
            attackPower *= 2;
        }

        public virtual void Defend(){
            Console.WriteLine("Defend");
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name + " get hit by "+hitValue);
            Health -= hitValue;

            if(Health<=0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine("Your are dead, Game Over");
            isDead = true;
        }
        public virtual void Leveing()
        {
            while(Exp >= 5)
            {
                Level++;
                attackPower = attackPower +2;
                Console.WriteLine("you have level up to level"+Level);
                Console.WriteLine("you gain extra 2 attack Power");
                Exp = Exp - 5;
            }
        }
        public void ForceLevelling()
        {
            Level = 2;
            Console.WriteLine("you have leveled up to level");
            ChangeJob();
        }
        public void ChangeJob()
        {
            JobPoint++;
        }
    }
}