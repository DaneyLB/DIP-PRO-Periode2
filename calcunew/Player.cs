using System;

public class Player
{
    
    public int HP = 100;
    private string _name = "Jumpman";
    private int _id = 100;


    public Player( string newName = "Mario" )
    {
        // constructor functie
        _name = newName;
    }




    public void Jump ()
    {
        Console.WriteLine(_name + "Spring! :D");
    }
    public void Shoot(int amount)
    {
        Console.WriteLine(_name + "Schiet" + amount + "keer");
    }

}
