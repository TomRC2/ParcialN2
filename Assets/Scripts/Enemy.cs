using UnityEngine;

// Clase Enemy hereda de TempleObject (Herencia) y representa un enemigo con vida.
// Se aplica Encapsulamiento con la propiedad Health.
// También se aplica Polimorfismo sobrescribiendo Interact() con comportamiento específico.

public class Enemy : TempleObject
{
    // Variable privada, protegida mediante propiedad (Encapsulamiento)
    [SerializeField] private int health = 100;

    // Getter/Setter controlado: garantiza que la salud no sea menor a 0
    public int Health
    {
        get => health;
        private set => health = Mathf.Max(0, value);
    }

    // Interacción del jugador: ataca al enemigo.
    public override void Interact()
    {
        TakeDamage(25); // lógica condicional aplicada
    }

    // Método con lógica condicional para aplicar daño y destruir al enemigo si llega a 0 de vida.
    private void TakeDamage(int amount)
    {
        Health -= amount;
        Debug.Log($"{objectName} recibió {amount} de daño. Salud restante: {Health}");

        if (Health == 0)
            Destroy(gameObject);
    }
}
