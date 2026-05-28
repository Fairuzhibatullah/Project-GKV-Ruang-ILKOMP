using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TapToTouchObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Pointer.current != null && Pointer.current.press.wasPressedThisFrame)
        {
            RaycastHit hit;
            Vector2 pointerPosition = Pointer.current.position.ReadValue();
            Ray ray = Camera.main.ScreenPointToRay(pointerPosition);
            if (Physics.Raycast(ray, out hit, 1000.0f))
            {
                if (hit.collider.CompareTag("GantiScene"))
                {
                    Debug.Log("Ganti Scene: " + hit.collider.gameObject.name);
                    SceneManager.LoadScene(hit.collider.gameObject.name);
                }
            }
        }
    }
}