namespace SpaceBattle.Server.Interfaces;

public interface IRotable
{
    /// <summary>
    /// Изменение направления
    /// </summary>
    /// <param name="angular"></param>
    /// <returns></returns>
    void ChangeDirection(double angular);
}