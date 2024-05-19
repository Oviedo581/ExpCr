using UnityEngine;

public class PointerController : MonoBehaviour
{
    public float rayDistance = 100f; // Distancia del raycast

    private Camera mainCamera;

    void Start()
    {
        // Referenciar la cámara principal automáticamente
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Detectar el clic del ratón
        if (Input.GetMouseButtonDown(0)) // Botón izquierdo del ratón
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Realizar el raycast
            if (Physics.Raycast(ray, out hit, rayDistance))
            {
                // Aquí puedes agregar la lógica para lo que sucede cuando se hace clic en un objeto
                Debug.Log("Clicked on: " + hit.transform.name);

                // Si el objeto tiene un componente específico, puedes interactuar con él
                // Ejemplo: si tiene un script llamado "Interactable"
                Interactable interactable = hit.transform.GetComponent<Interactable>();
                if (interactable != null)
                {
                    interactable.OnInteract();
                }
            }
        }
    }
}
