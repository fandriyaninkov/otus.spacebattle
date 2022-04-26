using System;
using System.Numerics;
using NUnit.Framework;
using SpaceBattle.Server;

namespace SpaceBattle.Tests;

public class MovableTest
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Movable_test()
    {
        // Arrange
        var movable = new Movable();
        
        // Act
        movable.SetPosition( Vector2.Add(new Vector2(12, 5), new Vector2(-7, 3)));
        
        // Assert
        Assert.AreEqual(5, movable.GetPosition()!.Value.X);
        Assert.AreEqual(8, movable.GetPosition()!.Value.Y);
    }
    
    [Test]
    public void Movable_BadPosition_test()
    {
        // Arrange
        var movable = new Movable();
        
        // Act and Assert
        Assert.Throws<ArgumentException>(() =>
            movable.SetPosition(Vector2.Add(new Vector2(Single.NaN, Single.NaN), new Vector2(-7, 3))));
    }
    
    [Test]
    public void Movable_BadVelocity_test()
    {
        // Arrange
        var movable = new Movable();
        
        // Act and Assert
        Assert.Throws<ArgumentException>(() =>
            movable.SetPosition(Vector2.Add(new Vector2(-7, 3), new Vector2(Single.NaN, Single.NaN))));
    }
}