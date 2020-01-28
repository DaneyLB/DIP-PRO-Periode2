using System;

namespace KillAMonster
{
    class Program
    {


        public static void Main(string[] args)
        {
            Monster[] monsters = new Monster[5];
            bool isGameRunning = true;


            for(int i=0; i<monsters.Length; i++){
                monsters[i] = new Monster();
                monsters[i].SetLives(10);


            }

            
            Console.Clear();
            while ( isGameRunning ){
            Console.WriteLine("type 'run' or 'attack'");
            string choice = Console.ReadLine(); 
            Console.WriteLine("type the number of the monster to attack");
            int monsterToAttack = Int32.Parse(Console.ReadLine());
            


            if(choice == "attack"){
                
                if(monsterToAttack < monsters.Length){
                    int currentLives = monsters[monsterToAttack].GetLives();
                    if(currentLives == 10){
                monsters[monsterToAttack].SetLives(currentLives-10);
                Console.WriteLine("you killed monster" + monsterToAttack);
                    
                }
                else{
                        Console.WriteLine("this monster is already death");
                    }
                }
                else{
                    Console.WriteLine("There are not more then " + monsters.Length + " monsters");
                }
                
            }
            else{
                isGameRunning = false;
            }
            }

        }
         public void AttackMonster(){
            
        }

    }
}
