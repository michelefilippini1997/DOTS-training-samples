﻿using Unity.Entities;
 
[GenerateAuthoringComponent]
public struct CurrentSegment : IComponentData
{
    public Segment Value;
}
