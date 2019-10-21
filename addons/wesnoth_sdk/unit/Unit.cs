using Godot;
using System;

public class Unit : Node2D
{
    private static PackedScene packedScene = GD.Load<PackedScene>("res://addons/wesnoth_sdk/unit/Unit.tscn");
    public static Unit Instance() { return packedScene.Instance() as Unit; }

    public int Health { get => health; }
    public int Experience { get => experience; }
    public int Moves { get => moves; }

    private int health = 0;
    private int experience = 0;
    private int moves = 0;

    // Child Nodes
    private UnitType type;

    public UnitType Type
    { 
        get { return type; }
        set { type = value; }
    }


    public override void _Ready()
    {
        AddChild(type);
        health = type.Health;
        moves = type.Moves;
    }
}
