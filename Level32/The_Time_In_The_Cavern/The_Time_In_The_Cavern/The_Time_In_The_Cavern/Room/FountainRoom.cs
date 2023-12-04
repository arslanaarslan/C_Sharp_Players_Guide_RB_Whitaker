namespace The_Fountain_of_Objects.Room;

public class FountainRoom : BaseRoom
{
    private Boolean _fountainActivated;

    private Boolean FountainActivated
    {
        get => _fountainActivated; 
        set => _fountainActivated = value;
    }
    public FountainRoom(int x, int y)
    {
        Name = "Fountain Room";
        X = x;
        Y = y;
        FountainActivated = false;
    }

    public override string RoomKnowledge()
    {
        if (!FountainActivated)
        {
            return "You hear water dripping in this room. The Fountain of Objects is here!";
        }
        else
        {
            return "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
        }
    }

    public void ActivateFountain()
    {
        FountainActivated = true;
    }
    
    public void DeactivateFountain()
    {
        FountainActivated = false;
    }

    public Boolean FountainStatus()
    {
        return FountainActivated;
    }
}