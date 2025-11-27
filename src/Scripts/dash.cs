using UnityEngine;

public class DashAbility : MonoBehaviour
{
    [Header("Dash Settings")]
    public float dashSpeedMultiplier = 1.5f;
    public float dashDuration = 0.2f;
    public float dashCooldown = 3f;
    public KeyCode dashKey = KeyCode.E;

    [Header("References")]
    public Transform orientation; // El cuerpo vacío que apunta hacia donde mira

    // Private variables
    private Rigidbody rb;
    private PlayerMovement playerMovement;
    private bool isDashing = false;
    private bool canDash = true;
    private float dashTimer = 0f;
    private float cooldownTimer = 0f;

    // Para almacenar la velocidad original
    private float originalWalkSpeed;
    private float originalRunSpeed;

    void Start()
    {
        // Obtener referencias
        rb = GetComponent<Rigidbody>();
        playerMovement = GetComponent<PlayerMovement>();

        // Guardar velocidades originales
        if (playerMovement != null)
        {
            originalWalkSpeed = playerMovement.walkSpeed;
            originalRunSpeed = playerMovement.runSpeed;
        }

        canDash = true;
    }

    void Update()
    {
        HandleInput();
        HandleDash();
        HandleCooldown();
    }

    private void HandleInput()
    {
        // Solo procesar input si puede hacer dash y no está en cooldown
        if (Input.GetKeyDown(dashKey) && canDash && !isDashing)
        {
            StartDash();
        }
    }

    private void StartDash()
    {
        isDashing = true;
        canDash = false;
        dashTimer = dashDuration;
        cooldownTimer = dashCooldown;

        // Aplicar el impulso del dash
        ApplyDashForce();

        Debug.Log("¡Dash activado!");
    }

    private void ApplyDashForce()
    {
        if (rb == null || orientation == null) return;

        // Resetear velocidad vertical para que el dash sea más horizontal
        Vector3 currentVelocity = rb.linearVelocity;
        rb.linearVelocity = new Vector3(currentVelocity.x * 0.5f, currentVelocity.y * 0.2f, currentVelocity.z * 0.5f);

        // Calcular dirección del dash (hacia donde mira el orientation)
        Vector3 dashDirection = orientation.forward;

        // Calcular fuerza del dash basada en la velocidad actual
        float currentSpeed = rb.linearVelocity.magnitude;
        float dashForce = Mathf.Max(currentSpeed, originalWalkSpeed) * dashSpeedMultiplier;

        // Aplicar fuerza de impulso
        rb.AddForce(dashDirection * dashForce, ForceMode.VelocityChange);

        // Opcional: Aumentar velocidad temporalmente en PlayerMovement
        if (playerMovement != null)
        {
            playerMovement.walkSpeed = originalWalkSpeed * dashSpeedMultiplier;
            playerMovement.runSpeed = originalRunSpeed * dashSpeedMultiplier;
        }
    }

    private void HandleDash()
    {
        if (isDashing)
        {
            dashTimer -= Time.deltaTime;

            if (dashTimer <= 0f)
            {
                EndDash();
            }
        }
    }

    private void EndDash()
    {
        isDashing = false;

        // Restaurar velocidades originales
        if (playerMovement != null)
        {
            playerMovement.walkSpeed = originalWalkSpeed;
            playerMovement.runSpeed = originalRunSpeed;
        }

        Debug.Log("Dash terminado");
    }

    private void HandleCooldown()
    {
        if (!canDash && !isDashing)
        {
            cooldownTimer -= Time.deltaTime;

            if (cooldownTimer <= 0f)
            {
                canDash = true;
                Debug.Log("Dash listo de nuevo!");
            }
        }
    }

    // Métodos públicos para UI o otros scripts
    public bool IsDashing()
    {
        return isDashing;
    }

    public bool CanDash()
    {
        return canDash;
    }

    public float GetCooldownPercent()
    {
        if (canDash) return 1f;
        return 1f - (cooldownTimer / dashCooldown);
    }

    // Visual debugging
    private void OnDrawGizmos()
    {
        if (isDashing && orientation != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawRay(transform.position, orientation.forward * 3f);
        }
    }
}