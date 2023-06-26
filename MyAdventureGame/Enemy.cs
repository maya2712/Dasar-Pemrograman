using System;

namespace MyAdventureGame_DesiMayaSari
{
    class Enemy
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int attackPower { get; set; }
        public bool isDead { get; set; }
        public bool isStunned { get; set; }

        Random rnd = new Random();

        public void GetHit(int hitValue){
            Console.WriteLine(Name + " get hit by "+hitValue);
            Health -= hitValue;

            if(Health<=0){
                Health = 0;
                Die();
            }
        }

        public void Die(){
            Console.WriteLine("you have killed the enemy");
            isDead = true;
        }

        public virtual void Skill(Player player)
        {
            player.GetHit(2 * attackPower);
        }
        
        public virtual void BossSkill(Player player)
        {
            player.GetHit(3 * attackPower);
        }
    }
}