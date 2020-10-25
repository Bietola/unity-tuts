using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;

[GenerateAuthoringComponent]
public struct InputComponent : IComponentData
{
    public Vector3 velocity;
}
