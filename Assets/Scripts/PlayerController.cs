using UnityEngine;

// Script que permite controlar al jugador y detectar interacciones.
// Se utiliza Raycasting para detectar objetos cercanos que implementen la interfaz IInteractable.

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract(); // Al presionar E, intenta interactuar
        }
    }

    // Intenta interactuar con el objeto más cercano que implemente la interfaz IInteractable
    void TryInteract()
    {
        float interactRadius = 1.5f; // Radio de búsqueda para detectar objetos interactuables alrededor del jugador

        // Detecta todos los colliders 2D dentro del círculo definido
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, interactRadius);

        Collider2D closest = null; // Guarda el collider más cercano
        float closestDistance = Mathf.Infinity; // Inicializa con una distancia muy grande

        // Recorre todos los objetos detectados dentro del radio
        foreach (var hit in hits)
        {
            // Verifica si el objeto implementa la interfaz IInteractable (Polimorfismo)
            if (hit.TryGetComponent<IInteractable>(out var interactable))
            {
                // Calcula la distancia entre el jugador y el objeto
                float distance = Vector2.Distance(transform.position, hit.transform.position);

                // Si es el más cercano hasta ahora, lo guarda
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closest = hit;
                }
            }
        }

        // Si encontró un objeto interactuable cercano, ejecuta su método Interact()
        if (closest != null && closest.TryGetComponent<IInteractable>(out var closestInteractable))
        {
            closestInteractable.Interact(); // Aplicación de Polimorfismo: llama al método específico según el objeto
        }
    }

}
