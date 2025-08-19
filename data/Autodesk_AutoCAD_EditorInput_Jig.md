# Jig Class

## Overview

#### Description
This .NET class wraps the AcEdJig ObjectARX class. 
Jig provides a base class from which custom classes can be derived that make use of the Jig functionality. This functionality provides graphical representation and user interaction in the process of setting the entity's parameters to the user's specifications. 
Essentially the jig creates an entity object and then goes into a loop that: 
  * Gets a user drag movement
  * Interprets this as a distance, angle, or point
  * Uses this value to update the entity's data
  * Calls the entity's WorldDraw method to redraw it on screen

When all necessary data is obtained, the loop is exited and, if desired, the entity is appended to the current space (that is, Model or Paper). 
The Jig class supports dynamic dimensions. Specifically, it 
  * Displays the dynamic dimensions while dragging the entity being acquired
  * Provides in-place editing for dynamic dimension values
  * Allows dynamic dimension values to drive the geometry for the entity being acquired

Note that this "data acquisition" loop occurs for each drag increment or keystroke, including the "final" keystroke.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.Jig
    Autodesk.AutoCAD.EditorInput.DrawJig
    Autodesk.AutoCAD.EditorInput.EntityJig
```

```text
public abstract class Jig;
```