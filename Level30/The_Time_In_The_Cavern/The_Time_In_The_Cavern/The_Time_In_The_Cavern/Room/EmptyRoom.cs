namespace The_Fountain_of_Objects.Room;

public class EmptyRoom : BaseRoom
{
    public EmptyRoom(int x, int y)
    {
        Name = "Empty Room";
        X = x;
        Y = y;
    }

    public override string RoomKnowledge()
    {
        // if (X == 0 && Y == 0)
        // {
        //     return "You see light coming from the cavern entrance.";
        // }

        return "";
    }
}