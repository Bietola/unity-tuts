using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;

public class InputSystem : JobComponentSystem
{
    private Vector3 velocity = Vector3.zero;
    
    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.velocity = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.velocity = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            this.velocity = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            this.velocity = Vector3.left;
        }

        var velocity = this.velocity;
        Entities.ForEach((ref InputComponent inputComponent) =>
        {
            Debug.Log($"velocity: {velocity}");

            inputComponent.velocity = velocity;
        }).Run();

        return default;
    }
}
