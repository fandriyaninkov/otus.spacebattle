using System.Numerics;

namespace SpaceBattle.Server.Interfaces;

public interface IMovable
{
    /// <summary>
    /// Получить текущую позицию
    /// </summary>
    /// <returns></returns>
    Vector2? GetPosition();

    /// <summary>
    /// Получить текущее смещение
    /// </summary>
    /// <returns></returns>
    Vector2? GetVelocity();

    /// <summary>
    /// Установить новую позицию
    /// </summary>
    /// <param name="newValue"></param>
    void SetPosition(Vector2 newValue);
}