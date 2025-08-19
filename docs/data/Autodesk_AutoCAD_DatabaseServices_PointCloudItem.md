# PointCloudItem Class

## Overview

#### Description
Class point cloud item, which presents different type of point cloud elements, for example project, scan, region, etc.
Class Hierarchy
```text
Autodesk.AutoCAD.DatabaseServices.Notifier
    Autodesk.AutoCAD.DatabaseServices.PointCloudItem
```

```text
public class PointCloudItem : Notifier;
```

### Constructors

- [PointCloudItem](#pointclouditem)

### Methods

- [Clone](#clone)
- [CompareTo](#compareto)
- [CreatePointCloudDataItemCollection](#createpointclouddataitemcollection)
- [modopt](#modopt)
- [ToCmdString](#tocmdstring)

### Properties

- [CategoryId](#categoryid)
- [Guid](#guid)
- [ItemId](#itemid)
- [Name](#name)
- [ProjectName](#projectname)
- [Visibility](#visibility)


## Constructors Details

### PointCloudItem

#### Description
Default constructor.
```text
public PointCloudItem();
```

### Clone

#### Description
Clone a Point Cloud Item.
```text
public PointCloudItem Clone();
```

### CompareTo

#### Description
Compare two current Point Cloud item to another and check whether they are the same.
```text
public bool CompareTo(
    PointCloudItem other
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| PointCloudItem other | The second point cloud item for comparison. |

#### Returns
Returns true if they are the same.
### CreatePointCloudDataItemCollection

#### Description
Build a point cloud item list from an array of AcPointCloudItem.
```text
public static List<PointCloudItem> CreatePointCloudDataItemCollection(
    IntPtr unmanagedObjPtr
);
```

#### Parameters

| Parameters | Description |
| --- | --- |
| IntPtr unmanagedObjPtr | The pointer of array of AcPointCloudItem |

#### Returns
Returns the list of point cloud item.
### modopt

#### Description
This is modopt, a member of class PointCloudItem.
```text
public ValueType modopt(
    PCAdsName
);
```

### ToCmdString

#### Description
Serialize the point cloud item to a string.
```text
public string ToCmdString();
```

### CategoryId

#### Description
Gets or sets the type of the item.
```text
public PointCloudItemType CategoryId;
```

#### Conditions
Read / Write
### Guid

#### Description
Gets or sets the GUID of item.
```text
public string Guid;
```

#### Conditions
Read / Write
### ItemId

#### Description
Gets or sets id of item.
```text
public int ItemId;
```

#### Conditions
Read / Write
### Name

#### Description
Gets or sets the name of item.
```text
public string Name;
```

#### Conditions
Read / Write
### ProjectName

#### Description
Gets or sets the name of project to which the current item belongs.
```text
public string ProjectName;
```

#### Conditions
Read / Write
### Visibility

#### Description
Gets or sets the visibility of item.
```text
public bool Visibility;
```

#### Conditions
Read / Write