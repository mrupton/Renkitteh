#region

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

#endregion
 namespace RustysKitteh
{
   class Program
    {

    private static Obj_AI_Hero Player { get { return ObjectManager.Player; } }

    
    private static Orbwalking.Orbwalker Orbwalker;

    // declare  list of spells
    private static Spell Q, W, E, R;


    private static Menu Menu;


    static void Main(string[] args)
    {
 
        CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
    }

  
    private static void Game_OnGameLoad(EventArgs args)
    {
        if (Player.ChampionName != "Rengar") 
            return;

        Q = new Spell(SpellSlot.Q, 125); 
        W = new Spell(SpellSlot.W, 500); 
        E = new Spell(SpellSlot.E, 1000);
     

  
        Menu = new Menu(Player.ChampionName, Player.ChampionName, true);

    
        Menu orbwalkerMenu = Menu.AddSubMenu(new Menu("Orbwalker", "Orbwalker"));

  
        Orbwalker = new Orbwalking.Orbwalker(orbwalkerMenu);

   
        Menu ts = Menu.AddSubMenu(new Menu("Target Selector", "Target Selector")); ;

  
        TargetSelector.AddToMenu(ts);

     
        Menu spellMenu = Menu.AddSubMenu(new Menu("Spells", "Spells"));

       
        spellMenu.AddItem(new MenuItem("useQ", "Use Q").SetValue(true));
        spellMenu.AddItem(new MenuItem("useW", "Use W").SetValue(true));
        spellMenu.AddItem(new MenuItem("useE", "Use E").SetValue(true));
     
        var 
            Menu.AddItem(new MenuItem("UsePacket", "Use Packet").SetValue(true));
    

        Menu.AddToMainMenu();

      
        Game.OnUpdate += Game_OnUpdate;

        // Creates a notification in the right-upper corner of the game (String message, int Milliseconds)
        Notifications.AddNotification("Welcome to Rengo Kitteh by Chadworth", 5000);
    }

private static void AddItem(MenuItem menuItem)
{
 	throw new NotImplementedException();
}

  
    private static void Game_OnUpdate(EventArgs args)
    {
        
        if (Player.IsDead)
            return;

    
           if (Orbwalker.ActiveMode != Orbwalking.OrbwalkingMode.Combo || Orbwalker.ActiveMode != Orbwalking.OrbwalkingMode.Mixed)
                return;

            {
           
            }
        }

      
        }

    private static void Combo()
    {
   
      if(!unitHero.IsValidTarget()) return;
   
        Q.CastCondition = (Obj_AI_Base unit) =>
            {
      

