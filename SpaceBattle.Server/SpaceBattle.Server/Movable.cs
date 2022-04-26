using System.Numerics;
using SpaceBattle.Server.Interfaces;

namespace SpaceBattle.Server;

public class Movable : IMovable
{
    private Vector2? _currentPosition;
    private Vector2? _curentVelocity;

    public Vector2? GetPosition()
    {
        return _currentPosition;
    }

    public Vector2? GetVelocity()
    {
        return _curentVelocity;
    }

    public void SetPosition(Vector2 newValue)
    {
        if (!float.IsFinite(newValue.X) || !float.IsFinite(newValue.Y))
        {
            throw new ArgumentException("Новая позиция не валидна");
        }
        _currentPosition = newValue;
    }
}