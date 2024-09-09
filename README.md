<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Ejercicio de testing de DateFormat

## Introducción

Uno de los ejercicios que hicimos para que aprendas a hacer en C# las cosas que
sabías hacer en Python fue convertir una función `DataFormat` en Python a la
correspondiente en C#. Aquí el punto de partida es la solución a ese ejercicio.

## Objetivo

Agregar casos de prueba al código existente.

## Pasos

1. Clona este repositorio en tu equipo.

2. Usando la terminal integrada en Rider, crea la carpeta `tests` en la raíz del
   repo y muévete a esa carpeta para que sea la carpeta actual.

3. Crea en la carpeta que acabas de crear un proyecto de prueba NUnit con el
   comando `dotnet new nunit --name LibraryTests`. La convención es que haya un
   proyecto de prueba para cada biblioteca del proyecto, con el mismo nombre, y
   el sufijo `Tests`; la librería que te damos es `Library`, por lo tanto el
   proyecto de prueba es `LibraryTests`.

4. Renombra el archivo `UnitTests1.cs` creado por el comando anterior a
   `DataFormatterTests` y la clase que contiene de `Tests` a
   `DateFormatterTests`. La convención es que haya una clase de prueba para cada
   clase a probar con el mismo nombre, y el sufijo `Tests`. Como la clase a
   probar es `DateFormatter`, la clase de prueba es `DateFormatterTests`, y el
   archivo `DateFormatterTests.cs` porque, también por convención, el archivo
   tiene el nombre de la clase que contiene.

5. Genera una referencia en `Library.Tests.csproj` hacia `Library.csproj`; para
   eso ejecuta el siguiente comando en la carpeta `tests`: `dotnet add
   ./Library.Tests/Library.Tests.csproj reference
   ../src/Library/Library.csproj`.

6. Muévete a la carpeta raíz de proyecto. Agrega el proyecto a la solución con
   el comando `dotnet sln add ./test/`.

7. Haz uno o más casos de prueba que comprueben que la función está bien
   implementada. Incluye casos de prueba para, al menos, los siguientes casos:
    - Una fecha en formato correcto
    - Una fecha que no tenga el formato correcto
    - Una fecha en blanco

8. Vas a encontrar errores con tus casos de prueba, porque la función que te
   damos no los contempla todos. Corrige el código provisto, para que pasen tus
   casos de prueba.
