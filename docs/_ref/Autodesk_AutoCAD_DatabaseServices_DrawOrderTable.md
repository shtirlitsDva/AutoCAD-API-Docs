# DrawOrderTable Class

## Overview

#### Description
This .NET class wraps the AcDbSortentsTable ObjectARX class. 
DrawOrderTable is the persistent container for draw order information. It resides in the extension dictionary of an associated BlockTableRecord under the key ACAD_SORTENTS. 
DrawOrderTable contains a set of object ID/handle pairs. The object ID is that of the entity to be drawn, and the handle is that of an entity in the block table record (usually but not always different from the associated object ID), which represents the position in the draw order. Entities are appended to a block table record in order of ascending handle value; in other words, the higher the handle value, the later it appears in a block table record. When it's time to draw entities in a block table record, an iterator goes through the block table record in append order. At each entity, the handle value is obtained and used to query into the sortents table. If there is a match, the object ID associated with the handle value in the sortents table is drawn. If there is no match in the sortents table, then the entity at the iterator position is drawn in its "natural" order. 
When the draw order of entities is modified, many of the entries in the sortents table may be modified. For example, a block table record has five entities with the following handles (usually represented as strings representing hexadecimal numbers): 4A, 4B, 4C, 4D, 4E. These handles appear in ascending order. When an application iterates over the entities in a block table record in the default direction, the handle value always increases from one entity to the next. 
To draw the last entity in the space first (or "behind" the others), five entries in the sortents table must be made, as follows: 
| Entity ID | Draw Order Handle |
| --- | --- |
| 4E | 4A |
| 4A | 4B |
| 4B | 4C |
| 4C | 4D |
| 4D | 4E |

The order of the entries (represented as a row in the preceding table) is irrelevant; draw order processing ends up sorting the entries by the draw order handle when performing the draw. In other words, in a DXF file, the table entries might appear in the following order, but the resultant draw order is identical: 
| Entity ID | Draw Order Handle |
| --- | --- |
| 4C | 4D |
| 4B | 4C |
| 4E | 4A |
| 4D | 4E |
| 4A | 4B |

As another example, the last entity in the space is moved "under" the next-to-last entity in the space, but the rest of the entities are drawn in "natural" order. In that case, the sortents table would only need two entries, as follows: 
| Entity ID | Draw Order Handle |
| --- | --- |
| 4E | 4D |
| 4B=D | 4E |

Adding new entities to the block table record with an implicit draw order of "last" requires no new entry in the sortents table.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.DBObject
    Autodesk.AutoCAD.DatabaseServices.DrawOrderTable
```

```text
public class DrawOrderTable : DBObject;
```

### Methods

- [FirstEntityIsDrawnBeforeSecond](#firstentityisdrawnbeforesecond)
- [GetFullDrawOrder](#getfulldraworder)
- [GetRelativeDrawOrder](#getrelativedraworder)
- [GetSortHandle](#getsorthandle)
- [MoveAbove](#moveabove)
- [MoveBelow](#movebelow)
- [MoveToBottom](#movetobottom)
- [MoveToTop](#movetotop)
- [SetRelativeDrawOrder](#setrelativedraworder)
- [SwapOrder](#swaporder)

### Properties

- [BlockId](#blockid)


## Methods Details

### FirstEntityIsDrawnBeforeSecond

#### Description
Returns true if first is drawn before second.
```text
public bool FirstEntityIsDrawnBeforeSecond(
    ObjectId first, 
    ObjectId second
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId first | Input first object ID |
| ObjectId second | Input second object ID |

### GetFullDrawOrder

#### Description
SYstem 
Returns an collection of the entity object IDs of the block in the order in which they would be drawn in SORTENTS-enabled contexts. 
When one or more bits of the honorSortEntitiesMask parameter is set to 1, the function tests the host database's $SORTENTS variable and, if any corresponding bits are off, it returns the object IDs in natural database order rather than the order specified by the sortents table.
```text
public ObjectIdCollection GetFullDrawOrder(
    byte honorSortEntitiesMask
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte honorSortEntitiesMask | Input indicating whether to test the host database's $SORTENTS variable |

### GetRelativeDrawOrder

#### Description
Rearranges the object IDs in the input array into their current relative draw order. 
When one or more bits of the honorSortEntitiesMask parameter is set to 1, the function tests the host database's $SORTENTS variable and, if any corresponding bits are off, it returns the object IDs in natural database order rather than the order specified by the sortents table.
```text
public ObjectIdCollection GetRelativeDrawOrder(
    byte honorSortEntitiesMask
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| byte honorSortEntitiesMask | Input indicating whether to test the host database's $SORTENTS variable |

### GetSortHandle

#### Description
Given an input object ID, this function returns the Handle that indicates the draw order. Entities with lesser handle values are drawn before/behind entities with higher handle values. This handle, sometimes called its "draw order sort key," may have nothing to do with the object ID, and may no longer even exist in the database. Its numerical value is what is of use, not the object it points to. 
**Note**
This function always returns the correct draw order sort key, regardless of explicit sortents table residency.
```text
public Handle GetSortHandle(
    ObjectId id
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id | Input object ID |

### MoveAbove

#### Description
Places all the entities specified in the input object ID array above the specified target entity. The entities being moved retain their relative draw order.
```text
public void MoveAbove(
    ObjectIdCollection collection, 
    ObjectId target
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection collection | Collection of object IDs |
| ObjectId target | Target entity |

### MoveBelow

#### Description
Places all the entities specified in the input object ID array below the specified target entity. The entities being moved retain their relative draw order.
```text
public void MoveBelow(
    ObjectIdCollection collection, 
    ObjectId target
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection collection | Collection of object IDs |
| ObjectId target | Target entity |

### MoveToBottom

#### Description
Places all the entities specified in the input object ID array at the beginning of the draw order. The entities being moved retain their relative draw order.
```text
public void MoveToBottom(
    ObjectIdCollection collection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection collection | Collection of object IDs |

### MoveToTop

#### Description
Places all the entities specified in the input object ID array at the ending of the draw order. The entities being moved retain their relative draw order.
```text
public void MoveToTop(
    ObjectIdCollection collection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection collection | Collection of object IDs |

### SetRelativeDrawOrder

#### Description
Takes the object IDs in the input collection and moves them in their current associated draw order slots so that they are drawn in the specified order. If you wish to move or consolidate the draw order slots of these object IDs, use the appropriate movexxx() member function to do so, either before or after calling this member.
```text
public void SetRelativeDrawOrder(
    ObjectIdCollection collection
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectIdCollection collection | Collection of object IDs |

### SwapOrder

#### Description
Swaps the draw order positions of the entities.
```text
public void SwapOrder(
    ObjectId id1, 
    ObjectId id2
);
```

#### Parameters
| Parameters | Description |
| --- | --- |
| ObjectId id1 | Object ID of first entity |
| ObjectId id2 | Object ID of second entity |

### BlockId

#### Description
Accesses the object ID for the associated block table record.
```text
public ObjectId BlockId;
```

#### Conditions
Read / Write