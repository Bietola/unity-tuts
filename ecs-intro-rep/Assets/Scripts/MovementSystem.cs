using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Rendering;
using Unity.Transforms;
using UnityEditor;
using UnityEngine;

public class MovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var delta = Time.DeltaTime;
        
        var outDeps = Entities.ForEach((ref Translation translation) =>
        {
            translation.Value += new float3(1, 0, 0) * delta;
        }).Schedule(inputDeps);

        return outDeps;
    }
}
