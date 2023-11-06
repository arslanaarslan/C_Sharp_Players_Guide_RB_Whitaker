using The_Fountain_of_Objects.Room;

namespace The_Fountain_of_Objects;

public class Game
{
    private int mapSize = 0;
    public static Hero? hero;
    public static Map? map;
    public static Announcer? announcer;

    public Game()
    {
        CreateMap();
        Start();
    }

    public void CreateMap()
    {
        Boolean success = false;
        string? answer = "";

        while (!success)
        {
            Console.WriteLine("Which size do you prefer your map, small(4x4), medium(6x6) or large(8x8)?");
            answer = Console.ReadLine()?.ToLower();
            switch (answer)
            {
                case "small":
                    mapSize = 4;
                    success = true;
                    break;
                case "medium":
                    mapSize = 6;
                    success = true;
                    break;
                case "large":
                    mapSize = 8;
                    success = true;
                    break;
                default:
                    Console.WriteLine("Invalid map size!");
                    continue;
            }
        }

        map = new Map(mapSize, hero);
        hero = new Hero(map.GetEntranceXCoordinate(), map.GetEntranceYCoordinate(), mapSize);
        announcer = new Announcer(hero, map);

    }

    public void Start()
    {
        if (map != null)
        {
            FountainRoom? fountainRoom =
                (FountainRoom)map?.MapArray[map.GetFountainYCoordinate(), map.GetFountainXCoordinate()]!;

            string? answer = "";

            while (hero != null && map != null && !(hero.X == map.GetEntranceXCoordinate() && hero.Y == map.GetEntranceYCoordinate() && fountainRoom.FountainStatus()))
            {
                announcer?.Announce();

                answer = Console.ReadLine();

                if (answer != null && map != null)
                {
                    // Console.WriteLine("Hero Coordinate: X: " + hero.X + " Y: " + hero.Y);
                    // Console.WriteLine("Fountain Coordinte: X: " + map.GetFountainXCoordinate() + " Y: " +
                    //                   map.GetFountainYCoordinate());
                    if (answer.ToLower() == "enable fountain" && hero.X == map.GetFountainXCoordinate() && hero.Y == map.GetFountainYCoordinate())
                    {
                        fountainRoom.ActivateFountain();
                    }
                    else
                    {
                        hero.MoveCommand(answer);
                    }
                }
            }
        }

        // Announce Last State
        announcer?.Announce();
        
    }
    

}