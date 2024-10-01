# Unity_introduction
Este proyecto en Unity se compone de objetos en 3D que formas unos obstaculos y un jugador con movimiento para superar esos obtaculos, el jugador puede moverse, saltar y girar la cámara. También cuando se ejecuta, con otro script se registran as coordenadas de todos los objetos 3D en la escena y las muestra en la consola en tiempo real.

## Descripción del trabajo
El script `Movement.cs` se le agrega al player y es el encargado de los movimientos del jugador.
El script `Coordenadas.cs` se agrega a un objeto en la escena, y se le asigna una lista de objetos 3D para seguir. Cada vez que el juego se ejecuta, las coordenadas (posiciones en el espacio) de esos objetos se imprimen en la consola de Unity.

A continuación se muestra una animación de la ejecución del script:

![GIF de la ejecución](Intrduccion_unity.gif)
