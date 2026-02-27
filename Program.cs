using Game;

var menu = new Menu();
var date = DateTime.UtcNow;

string name = Helpers.GetName();

Menu.ShowMenu(name, date);