using UnityEngine;

// Clase Enemy hereda de TempleObject (Herencia) y representa un enemigo con vida.
// Se aplica Encapsulamiento con la propiedad Health.
// Tambi�n se aplica Polimorfismo sobrescribiendo Interact() con comportamiento espec�fico.

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

    // Interacci�n del jugador: ataca al enemigo.
    public override void Interact()
    {
        TakeDamage(25); // l�gica condicional aplicada
    }

    // M�todo con l�gica condicional para aplicar da�o y destruir al enemigo si llega a 0 de vida.
    private void TakeDamage(int amount)
    {
        Health -= amount;
        Debug.Log($"{objectName} recibi� {amount} de da�o. Salud restante: {Health}");

        if (Health == 0)
            Destroy(gameObject);
    }
}
