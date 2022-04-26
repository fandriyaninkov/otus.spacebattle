using System;
using System.Numerics;
using NUnit.Framework;
using SpaceBattle.Server;

namespace SpaceBattle.Tests;

public class RotationTest
{
    [Test]
    public void Rotation_test()
    {
        // Arrange
        var direction = new Direction();
        
        // Act
        direction.ChangeDirection(25);
        
        // Assert
        Assert.AreEqual(25, direction.Angular);
    }
    
    [Test]
    public void Rotation_BadAngular_test()
    {
        // Arrange
        var direction = new Direction();
        
        // Act
        Assert.Throws<ArgumentException>(() => direction.ChangeDirection(Double.NaN));
    }
}