namespace BattleShipsLibrary.Models;

public class PlayerInfoModel
{
    public string UsersName { get; set; }
    public List<GridSpotModel> ShipLocations { get; set; }
    public List<GridSpotModel> ShotGrid { get; set; }
}