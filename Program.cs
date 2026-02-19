using Game;

var menu = new Menu();

var date = DateTime.UtcNow;

var games = new List<string>();

string name = Helpers.getName();

menu.showMenu(name, date);



