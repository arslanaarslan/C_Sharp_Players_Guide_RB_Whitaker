namespace The_Fountain_of_Objects.Room;

public class EntranceRoom : BaseRoom
{    public EntranceRoom(int x, int y)
     {
         Name = "Entrance Room";
         X = x;
         Y = y;
     }
 
     public override string RoomKnowledge()
     {
         return "You see light coming from the cavern entrance.";
     }
}