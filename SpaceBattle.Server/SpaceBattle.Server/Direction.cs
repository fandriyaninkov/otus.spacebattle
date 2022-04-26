using SpaceBattle.Server.Interfaces;

namespace SpaceBattle.Server;

/// <summary>
/// направление объекта
/// </summary>
public class Direction : IRotable
{
    /// <summary>
    /// Значение в радианах
    /// </summary>
    public double Angular { get; set; }

    public void ChangeDirection(double angular)
    {
        if (!double.IsFinite(angular))
        {
            throw new ArgumentException("Угол поворота должен быть действительным числом");
        }
        this.Angular += angular;
    }
}