namespace rest
{
    using menu;
    using System.Collections;

    public class RestaurantApp
    {
        public List<Menu> Menu = new List<Menu>();
        public OrderList orderList = new OrderList();
        public int[] lengthOfMenu = new int[100];

        public RestaurantApp() {}
        public RestaurantApp(List<Menu> menu)
        {
            this.Menu = menu;
        }
        public RestaurantApp(List<MenuList> menuList, MENULISTDATA nameOfMenu)
        {
            this.Menu[(int)nameOfMenu].menuList = menuList;
        }
        public RestaurantApp(bool standart)
        {
            // if true, will leave 3 standard choices (Order food, See Orders, Exit)
            if (standart)
            {
                this.AddMenu(MENULISTDATA.Main_Menu);
                this.AddMenu(MENULISTDATA.Order_food);
                this.AddMenu(MENULISTDATA.Order_list);
                this.AddMenu(MENULISTDATA.Exit);
                this.AddMenu(MENULISTDATA.Pizza);
                this.AddMenu(MENULISTDATA.Soup);
                this.AddMenu(MENULISTDATA.Wine);
                this.AddMenu(MENULISTDATA.Cola);
                this.AddMenuToList(new MenuList("Order food", MENULISTDATA.Order_food), this.Menu[(int)MENULISTDATA.Main_Menu].moveList);
                this.AddMenuToList(new MenuList("See orders", MENULISTDATA.Order_list), this.Menu[(int)MENULISTDATA.Main_Menu].moveList);
                this.AddMenuToList(new MenuList("Exit", MENULISTDATA.Exit), this.Menu[(int)MENULISTDATA.Main_Menu].moveList);
                this.AddMenuToList(new MenuList("Pizza", MENULISTDATA.Pizza), this.Menu[(int)MENULISTDATA.Order_food].moveList);
                this.AddMenuToList(new MenuList("Soup", MENULISTDATA.Soup), this.Menu[(int)MENULISTDATA.Order_food].moveList);
                this.AddMenuToList(new MenuList("Wine", MENULISTDATA.Wine), this.Menu[(int)MENULISTDATA.Order_food].moveList);
                this.AddMenuToList(new MenuList("Cola", MENULISTDATA.Cola), this.Menu[(int)MENULISTDATA.Order_food].moveList);
            }
        }

        public void AddMenuToList(MenuList menuList, MENULISTDATA nameOfMenu)
        {
            this.Menu[(int)nameOfMenu].menuList.Add(menuList);
            this.lengthOfMenu[(int)nameOfMenu]++;
        }
        public void AddMenuToList(IEnumerable<MenuList> menuList, MENULISTDATA nameOfMenu)
        {
            this.Menu[(int)nameOfMenu].menuList.AddRange(menuList);
        }
        public void AddMenu(MENULISTDATA nameOfMenu)
        {
            this.Menu.Add(new Menu(nameOfMenu));
        }
        public void AddMenu(MENULISTDATA nameOfMenu, List<MenuList> menuList)
        {
            this.Menu.Add(new Menu(nameOfMenu, menuList));
        }
        public void AddOrder(MENULISTDATA nameOfMenu)
        {
            if (nameOfMenu > MENULISTDATA.Exit && (int)nameOfMenu <= ((int)MENULISTDATA.Exit + this.lengthOfMenu[(int)MENULISTDATA.Order_food]))
            {
                switch (nameOfMenu)
                {
                    case MENULISTDATA.Pizza:
                        this.orderList.orders.Add(new Pizza());
                        this.AddMenuToList(new MenuList("Pizza", MENULISTDATA.Pizza), this.Menu[(int)MENULISTDATA.Order_list].moveList);
                        break;
                    case MENULISTDATA.Soup:
                        this.orderList.orders.Add(new Soup());
                        this.AddMenuToList(new MenuList("Soup", MENULISTDATA.Soup), this.Menu[(int)MENULISTDATA.Order_list].moveList);
                        break;
                    case MENULISTDATA.Wine:
                        this.orderList.orders.Add(new Wine());
                        this.AddMenuToList(new MenuList("Wine", MENULISTDATA.Wine), this.Menu[(int)MENULISTDATA.Order_list].moveList);
                        break;
                    case MENULISTDATA.Cola:
                        this.orderList.orders.Add(new Cola());
                        this.AddMenuToList(new MenuList("Cola", MENULISTDATA.Cola), this.Menu[(int)MENULISTDATA.Order_list].moveList);
                        break;
                    default:
                        break;
                }
            }
        }
        public void ChangeStage(Food food, ref bool hasFinished)
        {
            if (food is Pizza)
            {
                Pizza pizza = food as Pizza;
                if (pizza.timeToCook.Second > ((int)pizza.currentStage * 3))
                {
                    if (pizza.currentStage == FLOURSTAGES.Bringing)
                        hasFinished = true;
                    else
                        pizza.currentStage++;
                }
            }
            else if (food is Soup)
            {
                Soup soup = food as Soup;
                if (soup.timeToCook.Second > ((int)soup.currentStage * 6))
                {
                    if (soup.currentStage == HOTLIQUIDSTAGES.Bringing)
                        hasFinished = true;
                    else
                        soup.currentStage++;
                }
            }
            else if (food is Wine)
            {
                Wine wine = food as Wine;
                if (wine.timeToCook.Second > ((int)wine.currentStage * 3))
                {
                    if (wine.currentStage == COLDLIQUIDSTAGES.Bringing)
                        hasFinished = true;
                    else
                        wine.currentStage++;
                }
            }
            else if (food is Cola)
            {
                Cola cola = food as Cola;
                if (cola.timeToCook.Second > ((int)cola.currentStage * 3))
                {
                    if (cola.currentStage == COLDLIQUIDSTAGES.Bringing)
                        hasFinished = true;
                    else
                        cola.currentStage++;
                }
            }


        }
        public void CheckStages()
        {
            foreach (var item in this.orderList.orders)
            {
                bool hasFinished = false;
                item.timeToCook = item.timeToCook.Add(TimeSpan.FromMilliseconds(0.1));
                ChangeStage(item, ref hasFinished);
                if (hasFinished)
                    this.orderList.orders.Remove(item);
            }
        }
        public void ShowMenus(MENULISTDATA nameOfMenu, MENULISTDATA oldNameOfMenu)
        {
            if (oldNameOfMenu == MENULISTDATA.Main_Menu && (int)nameOfMenu > this.lengthOfMenu[(int)oldNameOfMenu])
            {
                throw new ArgumentException(message: "Wrong choice choosing!");
            }
            if (((int)nameOfMenu - this.lengthOfMenu[(int)oldNameOfMenu] + 1) > this.lengthOfMenu[(int)oldNameOfMenu] || (int)nameOfMenu < 0)
            {
                if ((int)nameOfMenu != 0)
                    throw new ArgumentException(message: "Wrong choice choosing!");
            }

            int index = 1;
            Console.WriteLine($"{this.Menu[(int)nameOfMenu].moveList}");
            if (nameOfMenu != MENULISTDATA.Main_Menu && nameOfMenu != MENULISTDATA.Exit)
                Console.WriteLine("0. Return to Main Menu");
            if (oldNameOfMenu == MENULISTDATA.Main_Menu && nameOfMenu == MENULISTDATA.Order_list)
            {
                for (int i = 0; i < this.orderList.orders.Count; i++)
                {
                    Console.WriteLine($"{index++}) {this.orderList.orders[i].name} - {this.orderList.orders[i].timeToCook.Second} sec");
                }
            }
            else
            {
                foreach (var item in this.Menu[(int)nameOfMenu])
                {
                    Console.WriteLine($"{index++}. {item.menuListName}");
                }
            }
        }
    }
}
