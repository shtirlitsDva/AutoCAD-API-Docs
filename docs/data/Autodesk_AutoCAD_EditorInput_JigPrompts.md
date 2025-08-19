# JigPrompts Class

## Overview

#### Description
This class provides a collection of sampling functions for Jig data acquisition.
Class Hierarchy
```text
Autodesk.AutoCAD.EditorInput.JigPrompts
```

```text
public sealed class JigPrompts;
```

### Methods

- [AcquireAngle()](#acquireangle())
- [AcquireAngle(JigPromptAngleOptions)](#acquireangle(jigpromptangleoptions))
- [AcquireAngle(string)](#acquireangle(string))
- [AcquireAngle(string, string)](#acquireangle(string,-string))
- [AcquireDistance()](#acquiredistance())
- [AcquireDistance(JigPromptDistanceOptions)](#acquiredistance(jigpromptdistanceoptions))
- [AcquireDistance(string)](#acquiredistance(string))
- [AcquireDistance(string, string)](#acquiredistance(string,-string))
- [AcquirePoint()](#acquirepoint())
- [AcquirePoint(JigPromptPointOptions)](#acquirepoint(jigpromptpointoptions))
- [AcquirePoint(string)](#acquirepoint(string))
- [AcquirePoint(string, string)](#acquirepoint(string,-string))
- [AcquireString()](#acquirestring())
- [AcquireString(JigPromptStringOptions)](#acquirestring(jigpromptstringoptions))
- [AcquireString(string)](#acquirestring(string))
- [AcquireString(string, string)](#acquirestring(string,-string))


## Methods Details

### AcquireAngle()

#### Description
Returns the Jig angle.
```text
public PromptDoubleResult AcquireAngle();
```

### AcquireAngle(JigPromptAngleOptions)

#### Description
Sets the angle based on the options selected by the user.
```text
public PromptDoubleResult AcquireAngle(
    JigPromptAngleOptions options
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| JigPromptAngleOptions options | Input prompt angle options |

### AcquireAngle(string)

#### Description
Returns a system message based on the option selected by the user.
```text
public PromptDoubleResult AcquireAngle(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### AcquireAngle(string, string)

#### Description
Returns an angle with the associated strings.
```text
public PromptDoubleResult AcquireAngle(
    string messageAndKeywords, 
    string globalKeywords
);
```

### AcquireDistance()

#### Description
Obtains a distance based on the current cursor position. Sets distance to the distance between the specified basepoint and the current cursor position. 
Returns the result of the prompt.
```text
public PromptDoubleResult AcquireDistance();
```

### AcquireDistance(JigPromptDistanceOptions)

#### Description
Obtains a distance based on the current cursor position and the prompt option selected by the user.
```text
public PromptDoubleResult AcquireDistance(
    JigPromptDistanceOptions options
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| JigPromptDistanceOptions options | Input prompt distance options |

### AcquireDistance(string)

#### Description
Returns the string based on the prompt option selected by the user.
```text
public PromptDoubleResult AcquireDistance(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### AcquireDistance(string, string)

#### Description
Returns a string based on the keyword entered by the user from DragStatus enumerated type.
```text
public PromptDoubleResult AcquireDistance(
    string messageAndKeywords, 
    string globalKeywords
);
```

### AcquirePoint()

#### Description
Obtains a point based on the current cursor position. 
Returns the result of the prompt.
```text
public PromptPointResult AcquirePoint();
```

### AcquirePoint(JigPromptPointOptions)

#### Description
Obtains the point based on the options selected.
```text
public PromptPointResult AcquirePoint(
    JigPromptPointOptions options
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| JigPromptPointOptions options | Input prompt point options |

### AcquirePoint(string)

#### Description
Returns a message based on the options selected from the prompt.
```text
public PromptPointResult AcquirePoint(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### AcquirePoint(string, string)

#### Description
Returns a string based on the keyword entered by the user from AcEdJig.DragStatus> enumerated type.
```text
public PromptPointResult AcquirePoint(
    string messageAndKeywords, 
    string globalKeywords
);
```

### AcquireString()

#### Description
Prompts the user to enter a string. 
Returns the result of the prompt.
```text
public PromptResult AcquireString();
```

### AcquireString(JigPromptStringOptions)

#### Description
Returns the prompt results based on the options selected by the user.
```text
public PromptResult AcquireString(
    JigPromptStringOptions options
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| JigPromptStringOptions options | Input prompt string options |

### AcquireString(string)

#### Description
Returns the string based on the options selected from the prompt.
```text
public PromptResult AcquireString(
    string message
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| string message | Input prompt message |

### AcquireString(string, string)

#### Description
Returns a string based on the keyword entered by the user from DragStatus enumerated type.
```text
public PromptResult AcquireString(
    string messageAndKeywords, 
    string globalKeywords
);
```
