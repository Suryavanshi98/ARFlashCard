using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableUI : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private Canvas canvas2;

    public void DisableInstruction()
    {
        canvas.enabled = false;
        canvas2.enabled = true;
    }

    public void EnableInstruction()
    {
        canvas.enabled = true;
        canvas2.enabled = false;
    }
}
