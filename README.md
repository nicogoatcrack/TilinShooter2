# TilinShooter2
Descripción del Proyecto

Sistema de movimiento en primera persona (FPS) desarrollado en Unity que ofrece un control fluido y responsivo para juegos de disparos en primera persona. El sistema incluye mecánicas avanzadas de movimiento, interacción con el entorno y una arquitectura modular fácil de expandir.

Integrantes
Nicolás Rodríguez- Lorenzo Porta 

 Problema y Solución
Problema Identificado
Los sistemas de movimiento FPS tradicionales suelen presentar:

Movimiento poco fluido y realista

Colisiones inconsistentes con el entorno

Dificultad para implementar mecánicas avanzadas de movimiento

Precisan alto nivel de hardware para ejecutarse satisfactoriamente

Código monolítico difícil de mantener

Solución Implementada
Desarrollamos un sistema modular que incluye:

Movimiento Base Mejorado

Física realista con Rigidbody

Detección precisa de suelo y pendientes

Control de velocidad y aceleración

Desarrollo para hardware de bajo consumo

Mecánicas Avanzadas


Dash: Movimiento rápido con cooldown

Doble Salto: Salto aéreo que se recarga al tocar el suelo

Sistema de Cámaras: Cambio entre primera y tercera persona

Grapling gun: gancho para que el jugador se balancee por el mapa


Arquitectura Modular

Scripts independientes y reutilizables

Fácil personalización desde el Inspector

Sistema de estados para diferentes modos de juego

🛠️ Tecnologías Utilizadas
Motor y Lenguajes
Unity 2022.3 LTS


Rigidbody: Física del personaje

Character Controller: Alternativa para movimiento

Camera System: Múltiples cámaras con transición

UI Canvas: Menús y HUD

Collision Detection: Detección avanzada de colisiones

Sistemas Desarrollados
PlayerMovement.cs - Movimiento principal

WallRunning.cs - Carrera en paredes

DashAbility.cs - Movimiento rápido

DoubleJump.cs - Salto aéreo

CameraSwitcher.cs - Control de cámaras

GameStateManager.cs - Estados del juego

 Cómo Usar el Sistema
 Requisitos: 4GB de RAM - procesador 5ta generación - 2 GB de memoria






 Inputs


 Controles predeterminados:
 WASD - Movimiento
 Mouse - Mirar
 Click 1 - disparo primario
 Click 2 - disparo del gancho
 Space - Saltar
 Shift - Correr
 E - Dash
 V - Cambiar cámara
 Escape - Menú pausa



Escenas y Flujo
Escena Menú (menus.unity)

Botones de inicio y configuración
Transición suave al juego

Escena Juego (juego.unity)

Entorno con colisiones
Sistema de movimiento completo

Menú de pausa integrado



Solución de Problemas Comunes
Error: "No camera rendering"

csharp

Error: Movimiento no funciona

Verificar que los scripts estén habilitados

Confirmar que el Rigidbody no sea kinematic

Revisar colliders del suelo y jugador

Optimización
Usar FixedUpdate para física

Implementar object pooling para efectos

Optimizar detección de colisiones con layers

