namespace The_Fountain_of_Objects.Room;

public class BaseRoom
{
    private string _name = "Base Room";

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    
    private int _x;

    public int X
    {
        get => _x; 
        set => _x = value;
    }
    
    private int _y;

    public int Y
    {
        get => _y; 
        set => _y = value;
    }

    public virtual string RoomKnowledge()
    {
        return "";
    }
}