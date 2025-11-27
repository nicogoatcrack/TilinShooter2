using UnityEngine;
using System.Collections;

public class SmoothCameraSwitcher : MonoBehaviour
{
    [Header("Referencias de Cámaras")]
    public Camera camaraPrimeraPersona;
    public Camera camaraTerceraPersona;
    
    [Header("Configuración")]
    public KeyCode teclaCambio = KeyCode.V;
    public bool empezarConPrimeraPersona = true;
    public float duracionTransicion = 0.5f;

    private bool esPrimeraPersona;
    private bool estaCambiando = false;

    void Start()
    {
        if (camaraPrimeraPersona == null || camaraTerceraPersona == null)
        {
            Debug.LogError("¡Asigna ambas cámaras en el Inspector!");
            return;
        }

        esPrimeraPersona = empezarConPrimeraPersona;
        ActualizarCamaras();
    }

    void Update()
    {
        if (Input.GetKeyDown(teclaCambio) && !estaCambiando)
        {
            StartCoroutine(CambiarCamaraConTransicion());
        }
    }

    private IEnumerator CambiarCamaraConTransicion()
    {
        estaCambiando = true;

        // Pequeño delay antes del cambio
        yield return new WaitForSeconds(0.1f);

        // Cambiar estado
        esPrimeraPersona = !esPrimeraPersona;
        
        // Actualizar cámaras
        ActualizarCamaras();

        // Esperar un poco antes de permitir otro cambio
        yield return new WaitForSeconds(duracionTransicion);
        
        estaCambiando = false;
        Debug.Log($"Cambiado a: {(esPrimeraPersona ? "Primera Persona" : "Tercera Persona")}");
    }

    private void ActualizarCamaras()
    {
        camaraPrimeraPersona.gameObject.SetActive(esPrimeraPersona);
        camaraTerceraPersona.gameObject.SetActive(!esPrimeraPersona);
    }

    public void CambiarCamaraInmediato()
    {
        esPrimeraPersona = !esPrimeraPersona;
        ActualizarCamaras();
        Debug.Log($"Cambiado a: {(esPrimeraPersona ? "Primera Persona" : "Tercera Persona")}");
    }
}