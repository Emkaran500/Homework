namespace menu
{
    using System.Collections;
    public enum MENULISTDATA : int
    {
        Main_Menu = 0,
        Order_food = 1,
        Order_list = 2,
        Exit = 3,
        Pizza = 4,
        Soup = 5,
        Wine = 6,
        Cola = 7,
    }
    public enum FLOURSTAGES
    {
        Making_Dough = 1,
        Making_Form = 2,
        Baking = 3,
        Bringing = 4
    }
    public enum HOTLIQUIDSTAGES
    {
        Cutting_Ingredients = 1,
        Boiling_in_Water = 2,
        Bringing = 3
    }
    public enum COLDLIQUIDSTAGES
    {
        Going_To_Fridge = 1,
        Bringing = 2
    }
    public interface IFlouring
    {
        FLOURSTAGES MakingDough();
        FLOURSTAGES MakingForm();
        FLOURSTAGES Baking();
        FLOURSTAGES Bringing();
    }
    public interface ISouping
    {
        HOTLIQUIDSTAGES CuttingIngredients();
        HOTLIQUIDSTAGES BoilingInWater();
        HOTLIQUIDSTAGES Bringing();
    }
    public interface IDrinking
    {
        COLDLIQUIDSTAGES GoingToFridge();
        COLDLIQUIDSTAGES Bringing();
    }

    public abstract class Food
    {
        public MENULISTDATA name;
        public TimeOnly timeToCook = new TimeOnly();
    }

    public class Pizza : Food, IFlouring
    {
        public FLOURSTAGES currentStage = FLOURSTAGES.Making_Dough;
        public Pizza()
        {
            this.name = MENULISTDATA.Pizza;
            this.timeToCook = new TimeOnly();
        }
        public Pizza(FLOURSTAGES currentStage)
        {
            this.name = MENULISTDATA.Pizza;
            this.timeToCook = new TimeOnly();
            this.currentStage = currentStage;
        }
        public FLOURSTAGES Baking()
        {
            return FLOURSTAGES.Baking;
        }
        public FLOURSTAGES Bringing()
        {
            return FLOURSTAGES.Bringing;
        }
        public FLOURSTAGES MakingDough()
        {
            return FLOURSTAGES.Making_Dough;
        }
        public FLOURSTAGES MakingForm()
        {
            return FLOURSTAGES.Making_Form;
        }
    }

    public class Soup : Food, ISouping
    {
        public HOTLIQUIDSTAGES currentStage = HOTLIQUIDSTAGES.Cutting_Ingredients;
        public Soup()
        {
            this.name = MENULISTDATA.Soup;
            this.timeToCook = new TimeOnly();
        }
        public Soup(HOTLIQUIDSTAGES currentStage)
        {
            this.name = MENULISTDATA.Soup;
            this.timeToCook = new TimeOnly();
            this.currentStage = currentStage;
        }
        public HOTLIQUIDSTAGES BoilingInWater()
        {
            return HOTLIQUIDSTAGES.Boiling_in_Water;
        }
        public HOTLIQUIDSTAGES Bringing()
        {
            return HOTLIQUIDSTAGES.Bringing;
        }
        public HOTLIQUIDSTAGES CuttingIngredients()
        {
            return HOTLIQUIDSTAGES.Cutting_Ingredients;
        }
    }

    public class Wine : Food, IDrinking
    {
        public COLDLIQUIDSTAGES currentStage = COLDLIQUIDSTAGES.Going_To_Fridge;

        public Wine()
        {
            this.name = MENULISTDATA.Wine;
            this.timeToCook = new TimeOnly();
        }
        public Wine(COLDLIQUIDSTAGES currentStage)
        {
            this.name = MENULISTDATA.Wine;
            this.timeToCook = new TimeOnly();
            this.currentStage = currentStage;
        }
        public COLDLIQUIDSTAGES Bringing()
        {
            return COLDLIQUIDSTAGES.Bringing;
        }
        public COLDLIQUIDSTAGES GoingToFridge()
        {
            return COLDLIQUIDSTAGES.Going_To_Fridge;
        }
    }

    public class Cola : Food, IDrinking
    {
        public COLDLIQUIDSTAGES currentStage = COLDLIQUIDSTAGES.Going_To_Fridge;

        public Cola()
        {
            this.name = MENULISTDATA.Cola;
            this.timeToCook = new TimeOnly();
        }
        public Cola(COLDLIQUIDSTAGES currentStage)
        {
            this.name = MENULISTDATA.Cola;
            this.timeToCook = new TimeOnly();
            this.currentStage = currentStage;
        }

        public COLDLIQUIDSTAGES Bringing()
        {
            return COLDLIQUIDSTAGES.Bringing;
        }

        public COLDLIQUIDSTAGES GoingToFridge()
        {
            return COLDLIQUIDSTAGES.Going_To_Fridge;
        }
    }
    public class OrderList
    {
        public List<Food> orders = new List<Food>();
    }

    public class MenuList
    {
        public readonly string menuListName = default;
        public MENULISTDATA MenuProperty { get; set; } = default;

        public override string ToString() => this.menuListName;

        public MenuList(string menuName, MENULISTDATA menuProperty)
        {
            this.MenuProperty = menuProperty;
            this.menuListName = menuName;
        }
    }
    public class Menu : IEnumerable<MenuList>
    {
        public MENULISTDATA moveList = default;
        public List<MenuList> menuList = new List<MenuList>();
        private readonly IEnumerator<MenuList> menuEnumerator;

        public Menu() 
        {
            this.menuEnumerator = new MenuEnumerator(menuList);
        }
        public Menu(MENULISTDATA moveList)
        {
            this.moveList = moveList;
            this.menuEnumerator = new MenuEnumerator(menuList);
        }
        public Menu(MENULISTDATA moveList, List<MenuList> menuList)
        {
            this.moveList = moveList;
            this.menuList = menuList;
            this.menuEnumerator = new MenuEnumerator(menuList);
        }
        public Menu(IEnumerator<MenuList> enumerator, MENULISTDATA moveList)
        {
            this.moveList = moveList;
            this.menuEnumerator = enumerator;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.menuEnumerator;
        }
        public IEnumerator<MenuList> GetEnumerator()
        {
            return this.menuEnumerator;
        }
    }

    public class MenuEnumerator : IEnumerator<MenuList>
    {
        private readonly List<MenuList> lists;
        private MenuList currentList;
        private int index = 0;

        object IEnumerator.Current => this.currentList;
        public MenuList Current => this.currentList;
        public MenuEnumerator(List<MenuList> lists)
        {
            this.lists = lists;
        }
        public bool MoveNext()
        {
            if (index < lists.Count)
            {
                this.currentList = this.lists[index];
                index++;
                return true;
            }
            this.Reset();
            return false;
        }
        public void Reset()
        {
            this.index = 0;
        }
        public void Dispose()
        {

        }
    }
}
