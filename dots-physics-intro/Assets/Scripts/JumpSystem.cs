using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Jobs;
using Unity.Physics;
using Unity.Rendering;
using UnityEngine;

public class JumpSystem : JobComponentSystem
{
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            return Entities.ForEach((ref PhysicsVelocity physicsVelocity) => {
                physicsVelocity.Linear.y = 5f;
            }).Schedule(inputDeps);
        }

        return default;
    }
}
