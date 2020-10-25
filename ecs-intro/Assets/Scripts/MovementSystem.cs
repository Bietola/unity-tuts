using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using UnityEngine;

public class MovementSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        var delta = Time.DeltaTime;

        var outDeps = Entities.ForEach((ref Translation translation, in MovementDir dir) =>
        {
            translation.Value += dir.movementDir * delta;
        }).Schedule(inputDeps);

        return outDeps;
    }
}
