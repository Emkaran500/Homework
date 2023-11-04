using menu;
using rest;
using System.Collections;
class Program
{
    public string Property { get; set; } = "";

    static void Main()
    {
        RestaurantApp app = new RestaurantApp(true);

        char choice = '0';
        char oldChoice = choice;

        while (true)
        {
            Console.Clear();
            if ((MENULISTDATA)((int)oldChoice - 48) == MENULISTDATA.Main_Menu)
            {
                if ((MENULISTDATA)((int)choice - 48) == MENULISTDATA.Exit)
                    System.Environment.Exit(0);
            }
            if ((MENULISTDATA)((int)choice - 48) != MENULISTDATA.Main_Menu && (MENULISTDATA)((int)oldChoice - 48) != MENULISTDATA.Main_Menu)
            {
                if (app.lengthOfMenu[(int)oldChoice - 48] != 0)
                    choice += (char)(app.lengthOfMenu[(int)oldChoice - 48] - 1);
                else
                    choice = oldChoice;
            }

            app.AddOrder((MENULISTDATA)((int)choice - 48));
            app.CheckStages();
            app.ShowMenus((MENULISTDATA)((int)choice - 48), (MENULISTDATA)((int)oldChoice - 48));

            if (char.IsDigit(choice))
            {
                oldChoice = choice;
            }
            else
            {
                choice = oldChoice;
            }
            choice = System.Console.ReadKey(true).KeyChar;
        }
    }
}