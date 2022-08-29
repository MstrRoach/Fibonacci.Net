# Fibonacci Api Rest

De acuerdo a lo solicitado, se realizó un endpoint para calcular el numero de fibonacci segun el indice pasado por ruta.

## Proceso:
- Comencé creando el proceso principal para el calculo de fibonacci. Utilizamos variables totalmente explicativas, para evitar la sobrecarga mental. 
- La idea es pensar en la sucesion de fibonacci, como una cinta donde estan todos los valores de fibonacci. Las variables usadas nos permiten movernos 
en triadas de numeros a traves de la cinta. El valor pasado, el actual y el siguiente nos van indicando el a donde continuar.
- La inicializacion de las 3 variables, segun el lugar inicial, en este caso, como valor pasado el cero, como valor actual el cero y como valor futuro el 1, 
nos indican desde que punto se parte, evitando las comprobaciones comunes para el caso inicial cero.
- El indice que se pasa por la ruta del api, lo usamos como nuestro limite de ejecucion, comenzando desde el caso cero, e iterando incrementalmente hasta
llegar al punto donde la iteracion es igual al indice. Hasta ahora, se ha evitado el uso de variables y comprobaciones inecesarias que agreguen sobrecarga 
mental al momento de seguir con la ejecucion.
- El ciclo for para el recorrido de la cinta de valores en la progresion nos lleva desde el origen cero, hasta el destino que es igual al index pasado por parametro,
justo ahi nos detenemos, y el valor almacenado en last se convierte en nuestra respuesta.

## Notas

Si bien el proceso utilizado se ve natural, es cierto que se hacen dos calculos extra, pues el valor buscado aparece dos indices antes,
pero tambien es cierto que eso nos obliga a definir estrictamente que el indice 0 es 0 y el indice 1 es 1, anclando los valores de fibonacci,
que si bien puede realizarse de esa manera, al menos creo que agrega sobrecarga para entender o para encontrar la naturaleza de la operacion.

Si bien creeria que cualquier optimizacion buscada para este proceso puede ser sobreoptimizacion, podemos aplicar el enfoque descrito
antes. Con esto nos ahorrariamos memoria al almacenar el valor buscado como el que guardda mas memoria y no como la variable con menos memoria
utilizada. El ejemplo para este caso es cuando llegamos al valor limite de 200:  en ese punto last es 4845216997073188000
, current en ese punto tiene un desbordamiento de enteros al igual que next. Esas serian las optimizaciones que desde este punto 
tendriamos que aplicar. En lugar de tomar last como nuestro valor objetivo, utilizar next como tal y evitar los desbordamientos de 
enteros asi como el almacenamiento innecesario de enteros que al llegar al objetivo no sirven para nada mas.