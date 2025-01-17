using Godot;
using System;

public partial class NewScript : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
			GD.Print("Hello World");
			GD.Print("Eu gostaria de para aqui no debug");
			GD.Print("Aqui passou o debug!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
