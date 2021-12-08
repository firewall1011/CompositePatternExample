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

// Build his hierarchy

// Add fingers to hands
lhand.Add(lfinger);
rhand.Add(rfinger);

// Add hands to arms
larm.Add(lhand);
rarm.Add(rhand);

// Add arms to body
body.Add(larm, rarm);

// Add body to our object
strangePerson.Add(body);

// Draw them
strangePerson.Draw();
Console.ReadLine();

// Rotate their arms by 45º degrees
larm.Transform.Rotation = Vector3.UnitZ * MathF.PI / 4;
rarm.Transform.Rotation = Vector3.UnitZ * MathF.PI / 4;

// Draw them
strangePerson.Draw();
Console.ReadLine();