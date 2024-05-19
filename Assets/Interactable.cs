using UnityEngine;

public class Interactable : MonoBehaviour
{
    public void OnInteract()
    {
        // Aquí va la lógica de interacción, por ejemplo:
        Debug.Log("Interacted with " + gameObject.name);
        // Puedes agregar más lógica aquí, como abrir un menú, recoger un objeto, etc.
    }
}
