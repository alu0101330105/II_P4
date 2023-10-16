# Practica 4: Eventos
Jorge González Delgado (alu0101330105@ull.edu.es)

## Ejercicio 1
![Ejercicio 1](./ej1.gif)

En este ejercicio partimos de donde lo habíamos dejado en la practica anterior, y ahora establecemos eventos para dotar de nuevas funcionalidades a nuestros objetos. En este ejercicio se debe de hacer que el grupo 2 de esferas se acerque al cilindro cada vez que este colisiona con un cubo, y hacer que el grupo 1 de esferas cambie su color.

## Ejericio 2
![Ejercicio 2](./ej2.gif)

En este ejercicio hemos cambiado de objeto a controlar y hemos vuelto al cubo. La funcionalidad que debemoa añadir ahora es que cuando el cubo colisione con cualquier objeto que no sea un esfera del grupo 1, éstas se moverán hacia el cilindro. En cambio si colisionamos contra entas esferas, serán las esferas del grupo 2 las que aumentarán su tamaño.

## Ejercicio 3
![Ejercicio 3](./ej3.gif)

En este ejercicio, debemos de crear un nuevo evento que se lanzará no con una colición, sino cuando nos acerquemos al cilindro. En este caso, cuando nos acerquemos al cilindro, las esferas del grupo 1 darán un salto, y las del grupo 2 se orientarán (en mi caso) hacia otro cubo que tiene una tag específica.

## Ejercicio 4
![Ejercicio 4](./ej4.gif)

En este ejercicio, nos olvidamos de las colisiones, ya que convertiremos las esferas en objetos colecionables que podemos recojer con nuestro cubo. Estas esferas sumarán a la puntuación, que se muestra por consola. Las esferas del grupo 1 proporcionan 5 puntos mientras que las del grupo 2 proporcionan 10.

## Ejercicio 5
![Ejercicio 5](./ej5.gif)

Ahora se trata de colocar la puntuación que mostrábamos por consola en un elemento de la interfaz. Esto se hace utilizando un canvas.

## Ejercicio 6
![Ejercicio 6](./ej6.gif)

Este ejercicio libre trata de englobar todo lo aprendido en este práctica y las anteriores, haciendo un minijuego que utilize las herramientas vistas hasta el momento. En mi caso he decidido realizar una versión 3D y más Fácil (por el momento) de "World's Hardest Game", en el que debes recoger todas las esferas sin que te alcancen los pilares enemigos. En esta primera versión, el jugador no muere por contacto con los pilares ni tiene una velocidad de movimiento reducida, ya que es simplemente una deomstración de lo que se puede hacer con lo aprendido hasta el momento.