using System;

namespace Daspro_Kelas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this challenging Game!!");
            Console.WriteLine("What is your name??");
            Wizard player = new Wizard();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi "+player.Name+"!! Are you ready to play this game???[y/n]");
            string bReady = Console.ReadLine();
            if(bReady=="yes"){
                Console.WriteLine("Hi, "+player.Name+"!! is entering the world...");
                Console.WriteLine("You and Mellky are exploring The Forest.....");
                Console.WriteLine(".............");
                Console.WriteLine(".............");
                Console.WriteLine(".............");
                Enemy1 Enemy1 = new Enemy1("Monster SEIJIN");
                Enemy2 Enemy2 = new Enemy2("Monster CHOU-JUU");
                Enemy3 Enemy3 = new Enemy3("Monster MAOH-JUU");
                MonsterLord WorldBoss = new MonsterLord("Lord");
                Console.WriteLine(player.Name+" is encountering "+Enemy1.Name);
                Console.WriteLine(Enemy1.Name+" attacking you...");
                Console.WriteLine("Mellky : WHATC OUT");
                Console.WriteLine("Choose your action :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !Enemy1.IsDead && !player.IsRunningAway)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        player.normalAttack();
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        Enemy1.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        Enemy1.Attack(Enemy1.AttackPower);
                        player.GetHit(Enemy1.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy1.Name+" : "+Enemy1.Health+"\n");
                        break;
                        case "2" :
                        player.Lightningbold();
                        player.Experience += 03f;
                        Enemy1.GetHit(player.AttackPower);
                        Enemy1.GetHit(player.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy1.Name+" : "+Enemy1.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored..");
                        Enemy1.Attack(Enemy1.AttackPower);
                        player.GetHit(Enemy1.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy1.Name+" : "+Enemy1.Health+"\n");
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        player.RunningAway();
                        break;
                    }
                }
                while (!player.IsDead && !Enemy2.IsDead && !player.IsRunningAway && Enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        player.normalAttack();
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        Enemy2.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        Enemy2.Attack(Enemy2.AttackPower);
                        player.GetHit(Enemy2.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy2.Name+" : "+Enemy2.Health+"\n");
                        break;
                        case "2" :
                        player.Lightningbold();
                        player.Experience += 03f;
                        Enemy2.GetHit(player.AttackPower);
                        Enemy2.GetHit(player.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy2.Name+" : "+Enemy2.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored..");
                        Enemy2.Attack(Enemy2.AttackPower);
                        player.GetHit(Enemy2.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy2.Name+" : "+Enemy2.Health+"\n");
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        player.RunningAway();
                        break;
                    }
                }
                 while (!player.IsDead && !Enemy3.IsDead && !player.IsRunningAway && Enemy1.IsDead && Enemy2.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        player.normalAttack();
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        Enemy3.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        Enemy3.Attack(Enemy3.AttackPower);
                        player.GetHit(Enemy3.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy3.Name+" : "+Enemy3.Health+"\n");
                        break;
                        case "2" :
                        player.Lightningbold();
                        player.Experience += 03f;
                        Enemy3.GetHit(player.AttackPower);
                         Enemy3.GetHit(player.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy3.Name+" : "+Enemy3.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored..");
                        Enemy3.Attack(Enemy3.AttackPower);
                        player.GetHit(Enemy2.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+Enemy3.Name+" : "+Enemy3.Health+"\n");
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        player.RunningAway();
                        break;
                    }
                }
                 while (!player.IsDead && !WorldBoss.IsDead && !player.IsRunningAway && Enemy1.IsDead && Enemy2.IsDead && Enemy3.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction){
                        case "1" :
                        Console.WriteLine(player.Name+" is doing Single Attack");
                        WorldBoss.GetHit(player.AttackPower);
                        player.Experience += 0.3f;
                        WorldBoss.Attack(WorldBoss.AttackPower);
                        player.GetHit(WorldBoss.AttackPower = player.Health*3);
                        player.GetHit(WorldBoss.AttackPower = player.AttackPower*3);
                        Console.Write("Player Health : "+player.Health+" | "+WorldBoss.Name+" : "+WorldBoss.Health+"\n");
                        break;
                        case "2" :
                        player.Lightningbold();
                        player.Experience += 03f;
                        WorldBoss.GetHit(player.AttackPower);
                        player.GetHit(WorldBoss.AttackPower = player.Health*3/100);
                        Console.Write("Player Health : "+player.Health+" | "+WorldBoss.Name+" : "+WorldBoss.Health+"\n");
                        break;
                        case "3" :
                        player.Rest();
                        Console.WriteLine("Energy is being restored..");
                        WorldBoss.Attack(WorldBoss.AttackPower);
                        player.GetHit(WorldBoss.AttackPower);
                        Console.Write("Player Health : "+player.Health+" | "+WorldBoss.Name+" : "+WorldBoss.Health+"\n");
                        break;
                        case "4" :
                        Console.WriteLine(player.Name+" is running away...");
                        player.RunningAway();
                        break;
                    }
                }
                Console.WriteLine(player.Name+" get "+player.Experience+" experience point.");
            }else{
                Console.WriteLine("Goodbye...");
            }
        }
     }

    class Wizard
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Mana { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rnd = new Random();

        public Wizard(){
            Health = 200;
            Mana = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
            IsRunningAway = false;
        }
        public void normalAttack(){
            reset();
            AttackPower = AttackPower + rnd.Next(5,15);
        }

        public void Lightningbold(){
            if(Mana >0){
                reset();
                Console.WriteLine("SWINGG!!!");
                AttackPower = AttackPower + rnd.Next(15,25);
                Mana = Mana-30;
            }else{
                Console.WriteLine("You do not have energy!");
                AttackPower = 0;
            }
        }
        public void reset(){
            AttackPower = 1;
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by"+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();}
        }

        public void Rest(){
            Mana = Mana - 30;
            AttackPower = 1;
        }

        public void Die(){
            Console.WriteLine(Name +"You are dead. Game Over");
            IsDead = true;
        }

        public void RunningAway(){
            IsRunningAway = true;
        }
    }

    class Enemy1
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy1(string name){
            Health = 50;
            Name = name;
        }

        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name +" is dead");
            IsDead = true;
        }
    }
    class Enemy2
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy2(string name){
            Health = 70;
            Name = name;
        }
        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name +" is dead");
            IsDead = true;
        }
    }
    class Enemy3
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy3(string name){
            Health = 80;
            Name = name;
        }
        public void Attack(int damage){
            AttackPower = rnd.Next(1,10);
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name +" is dead");
            IsDead = true;
             }
    }
    class MonsterLord
    {
        public int power { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        public int autodead; 
        Random rnd = new Random();

        public MonsterLord(string name){
            Health = 1000;
            Name = name;
        }
        public void Attack(int damage){
            if(power >=5 ){
                Instandead();

        }else{
            AttackPower = 8;
            power = power + 5;
        }
        }

        public void GetHit(int hitValue){
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <=0){
                Health = 0;
                Die();
            }
        }
        public void Die(){
            Console.WriteLine(Name +" is dead");
            IsDead = true;
        }
        public void Instandead(){
            autodead = rnd.Next(1,1000);
            if(autodead == 1){
                AttackPower = 1000;
                 Console.WriteLine(" Experiment ");
        
            }else{
              AttackPower = 33;
              Console.WriteLine(" Experiment one "); 
            }
        }
    }
}
