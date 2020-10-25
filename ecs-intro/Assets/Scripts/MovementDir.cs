using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct MovementDir : IComponentData
{
    [SerializeField] public float3 movementDir;
}
