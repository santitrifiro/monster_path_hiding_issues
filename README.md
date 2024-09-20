# Monster Path - Hiding Issues

## Descripción

Este proyecto implementa un movimiento inteligente del monstruo en tiempo de caza. Empleando scripts y algoritmos el monstruo decide qué camino tomar y cómo recorrerlo de manera óptima.

## Características

- **Movimiento Inteligente**: El monstruo calcula su ruta en función de su entorno.
- **Evitación de Obstáculos**: Implementación de técnicas para evitar colisiones con obstáculos.
- **Rutas Óptimas**: El monstruo elige las mejores rutas para alcanzar su objetivo.

## Instrucciones para el Uso del Proyecto

Para hacer uso de este proyecto, solo es necesario importar en nuestro proyecto principal los scripts `MonsterManager.cs` y `StepManager.cs`, y cumplir con los siguientes pasos:

1. **Asignar al objeto que será el monstruo el componente `MonsterManager.cs`.**
2. **Crear un objeto vacío llamado `MonsterPath`**, y dentro definir el camino por defecto que tomaría el monstruo con objetos vacíos (nombrar los objetos vacíos como: `1`, `2`, `3`).
3. **Asignar a los objetos vacíos el componente `StepManager.cs`.**
4. **Asignar los objetos vecinos para cada objeto de `MonsterPath`.**
5. **Configurar los objetos del `MonsterPath` a nuestros requerimientos**, como especificar si es un objeto que corresponde a una sala y asignarle una posibilidad de ingreso para el monstruo.
6. **Configurar el monstruo a nuestros requerimientos.**
7. **Activar la variable `monstruo_libre` del monstruo.**

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu_usuario/monster_path_hiding_issues.git
