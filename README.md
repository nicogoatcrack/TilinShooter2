Tilin shooter 2 

Tilin shooter 2 es un viedeojuego de Disparos en Primera Persona (FPS) desarrollado en Unity que ofrece un control fluido y responsivo para dispositivos de bajos recursos. El sistema incluye mecánicas avanzadas de movimiento, interacción con el entorno y una arquitectura modular fácil de expandir.

Integrantes
Nicolás Rodríguez- Lorenzo Porta 

 Problema y Solución
Problema Identificado
Los sistemas de movimiento FPS (First Person Shooter) tradicionales suelen presentar:

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

Tecnologías Utilizadas
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
 Requisitos: 4GB de RAM - procesador 4ta generación - 2 GB de memoria

Solicitar una copia y ejecturar el archivo .exe incluido en los archivos 

Escenas y Flujo
Escena Menú (menus.unity)

Botones de inicio y configuración
Transición suave al juego

Escena Juego (juego.unity)

Entorno con colisiones
Sistema de movimiento completo


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







Capturas
Menu 



Juego
  





Project Description

Tilin shooter 2 is a First Person Shooter (FPS) video game developed in Unity that offers fluid and responsive control for low-resource devices. The system includes advanced movement mechanics, interaction with the environment and an easy-to-expand modular architecture.

Members
Nicolás Rodríguez- Lorenzo Porta 

 Problem and Solution
Problem Identified
Traditional FPS (First Person Shooter) motion systems typically feature:

Not very fluid and realistic movement

Inconsistent collisions with the environment

Difficulty implementing advanced movement mechanics

Require a high level of hardware to run satisfactorily

Monolithic code that is difficult to maintain

Solution Implemented
We developed a modular system that includes:

Improved Base Move

Realistic physics with Rigidbody

Accurate soil and slope detection

Speed and acceleration control

Development for low-power hardware

Advanced Mechanics


Dash: Fast Motion with Cooldown

Double Jump: Aerial jump that recharges when it touches the ground

Camera System: Switching between first and third person

Grapling gun: hook for the player to swing around the map


Modular Architecture

Standalone and reusable scripts

Easy customization from the Inspector

Status system for different game modes

Technologies Used
Engine and Languages
Unity 2022.3 LTS


Rigidbody: Character Physics

Character Controller: Alternative for Motion

Camera System: Multiple Cameras with Transition

UI Canvas: Menus and HUDs

Collision Detection: Advanced collision detection

Developed Systems
PlayerMovement.cs - Movimiento principal

WallRunning.cs - Race on walls

DashAbility.cs - Fast Movement

DoubleJump.cs - Salto aéreo

CameraSwitcher.cs - Camera Control

GameStateManager.cs - Game States

 How to Use the System
 Requirements: 4GB RAM - 4th generation processor - 2GB memory

Request a copy and execute the file .exe included in the files 

Scenes and Flow
Scene Menu (menus.unity)

Home and Settings Buttons
Smooth transition to the game

Scene Game (game.unity)

Collision Environment
Full Motion System


 Inputs


 Default Controls:
 WASD - Movement
 Mouse - Look
 Click 1 - primary firing
 Click 2 - Hook Shot
 Space - Jump
 Shift - Run
 E - Dash
 V - Change Camera
 Escape - Pause Menu










