using DungeonOrganizer.Items;
using DungeonOrganizer.World;

using InventoryItem = DungeonOrganizer.Items.Item;
using MapItem = DungeonOrganizer.World.Item;


using DungeonOrganizer.Characters;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
DungeonOrganizer.Items.Item item =
    new DungeonOrganizer.Items.Item("Mikstura", 15);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
DungeonOrganizer.Items.Weapon weapon =
    new DungeonOrganizer.Items.Weapon("Miecz", 8);

Console.WriteLine($"Miecz zadaje {weapon.Damage} obrażeń.");

InventoryItem inventoryItem = new InventoryItem("", 0);
MapItem mapItem = new MapItem("!");



