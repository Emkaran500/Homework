namespace EB_DZ_43.Models;
public class Map
{
    public char[,] mapTiles = new char[10,20];
    private static Map map;

    public static Map Instance
    {
        get
        {
            if (map == null)
            {
                map = new Map();
            }
            return map;
        }
    }

    private Map()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (i == 0 || j == 0)
                {
                    this.mapTiles[i, j] = '0';
                }
                else if (i == 9 || j == 19)
                {
                    this.mapTiles[i, j] = '0';
                }
                else
                {
                    this.mapTiles[i, j] = ' ';
                }
            }
        }
    }

    public void DrawMap()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                Console.Write(this.mapTiles[i,j]);
                if (j == 19)
                    Console.WriteLine("");
            }
        }
    }
}
