using System;
using System.Numerics;
using CompositeExample;
using CompositeExample.Shapes;

// Create Strange Man
CompoundGraphicElement strangePerson = new("Strange Person");

// Create his body
ConsoleTriangle body = new("Body");
body.Transform.Position = Vector3.Zero;

// Create his arms
ConsoleRectangle larm = new("Left arm");
ConsoleRectangle rarm = new("Right arm");
larm.Transform.Position = -Vector3.UnitX;
rarm.Transform.Position =  Vector3.UnitX;

// Create his hands
ConsoleCircle lhand = new("Left hand");
ConsoleCircle rhand = new("Right hand");
lhand.Transform.Position = -Vector3.UnitX * 0.5f;
rhand.Transform.Position =  Vector3.UnitX * 0.5f;

// Create his fingers
ConsoleTriangle lfinger = new("Left finger");
ConsoleTriangle rfinger = new("Right finger");
lfinger.Transform.Position = -Vector3.UnitX * 0.1f;
rfinger.Transform.Position =  Vector3.UnitX * 0.1f;

// Create his ears and head
Leaf rear = new();
Leaf lear = new();
lear.Transform.Position = new(-0.2f, 0.2f, 0.0f);
rear.Transform.Position = new( 0.2f, 0.2f, 0.0f);

ConsoleCircle head = new("Head");
head.Transform.Position = Vector3.UnitY * 0.5f;

// Build his hierarchy

// Add ears to head
head.Add(lear, rear);

// Add fingers to hands
lhand.Add(lfinger);
rhand.Add(rfinger);

// Add hands to arms
larm.Add(lhand);
rarm.Add(rhand);

// Add arms and head to body
body.Add(larm, rarm, head);

// Add body to our object
strangePerson.Add(body);

// Draw them
strangePerson.Draw();
Console.ReadLine();

// Rotate their arms by 45º degrees
larm.Transform.Rotation = Vector3.UnitZ * MathF.PI / 4;
rarm.Transform.Rotation = Vector3.UnitZ * MathF.PI / 4;

// Rotate their head by 90º degrees
head.Transform.Rotation = Vector3.UnitZ * MathF.PI / 2;

// Draw them
strangePerson.Draw();
Console.ReadLine();