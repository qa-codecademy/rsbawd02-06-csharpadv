namespace CarRaceApp;

public class Car
{
    public string Model { get; set; }
    public int Speed { get; set; }
    public Driver Driver { get; set; }

    public int CalculateSpeed()
    {
        return (int) (Speed * Driver.Skill);
    }
}