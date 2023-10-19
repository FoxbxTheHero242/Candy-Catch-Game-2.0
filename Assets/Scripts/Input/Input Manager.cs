using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;
using UnityEngine.InputSystem.Controls;

public static class InputManager
{
    private static Inputs _input;
    
    public static void INIT(PlayerMove playerMove)
    {
        _input = new Inputs();
        _input.Move.Enable();
        _input.Move.AxisH.performed += axis =>
        {
            
            playerMove.MoveMe(axis.ReadValue<Vector2>());
        };



    }
}
