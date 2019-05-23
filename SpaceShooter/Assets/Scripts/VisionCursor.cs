using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionCursor : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; //разблокируем курсор
        Cursor.visible = true; //заставляем курсор мыши появиться
    }
}
