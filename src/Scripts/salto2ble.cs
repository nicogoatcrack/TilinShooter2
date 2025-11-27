using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    [Header("Double Jump Settings")]
    public bool enableDoubleJump = true;
    public float doubleJumpForce = 550f;
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Visual Feedback")]
    public ParticleSystem doubleJumpEffect;
    public AudioClip doubleJumpSound;

    // Private variables
    private PlayerMovement playerMovement;
    private Rigidbody rb;
    private bool hasDoubleJump = true;
    private bool wasGrounded = true;

    void Start()
    {
        // Obtener referencias
        playerMovement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
        
        if (playerMovement == null)
        {
            Debug.LogError("PlayerMovement no encontrado!");
        }
    }

    void Update()
    {
        if (!enableDoubleJump) return;

        HandleDoubleJump();
        CheckGroundedStatus();
    }

    private void HandleDoubleJump()
    {
        // Verificar si presionó la tecla de salto en el aire
        if (Input.GetKeyDown(jumpKey) && !playerMovement.grounded && hasDoubleJump)
        {
            PerformDoubleJump();
        }
    }

    private void CheckGroundedStatus()
    {
        // Si acaba de tocar el suelo, recargar el doble salto
        if (playerMovement.grounded && !wasGrounded)
        {
            ResetDoubleJump();
        }

        // Actualizar estado anterior
        wasGrounded = playerMovement.grounded;
    }

    private void PerformDoubleJump()
    {
        // Aplicar fuerza del doble salto
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z); // Reset Y velocity
        rb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);

        // Consumir el doble salto
        hasDoubleJump = false;

        // Efectos visuales y de sonido
        PlayDoubleJumpEffects();

        Debug.Log("¡Doble salto!");
    }

    private void ResetDoubleJump()
    {
        hasDoubleJump = true;
        
        // Efecto opcional al recargar
        if (doubleJumpEffect != null)
        {
            // Podrías añadir un efecto de partículas al tocar el suelo
        }

        Debug.Log("Doble salto recargado");
    }

    private void PlayDoubleJumpEffects()
    {
        // Efecto de partículas
        if (doubleJumpEffect != null)
        {
            Instantiate(doubleJumpEffect, transform.position, Quaternion.identity);
        }

        // Sonido
        if (doubleJumpSound != null)
        {
            AudioSource.PlayClipAtPoint(doubleJumpSound, transform.position);
        }
    }

    // Métodos públicos para otros scripts
    public bool HasDoubleJumpAvailable()
    {
        return hasDoubleJump;
    }

    public void EnableDoubleJump(bool enable)
    {
        enableDoubleJump = enable;
    }

    public void ResetJumpOnLand()
    {
        // Método público para resetear manualmente
        ResetDoubleJump();
    }
}