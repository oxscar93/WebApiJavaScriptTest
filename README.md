# Web API RestFull and JavaScript Test

## Getting Started

Clonar repositorio para descargar el proyecto de web api y el test de java script

### Prerequisites

Visual studio 2015, IIS y una base de datos SQL server

### Installing

1- Correr script para crear la base de datos, tablas y datos dummy alojado dentro de WebApi/Scripts
2- Modificar archivo Web.Config: Cambiar dentro de connection string la instancia de SQL server para apuntar a la base de datos SQL server local 
3- Correr Web Api desde visual studio

## Running the tests

Para correr los unit test: Menu Test -> Run All Test (se utilizó el framework de unit que provee .NET de manera nativa)

### API y contracts

(GET) {locahost}/MyResftfullApp/Cotizacion/MONEDA -> Para obtener la cotizacion actual
(GET) {localhost}/MyRestfullApp/Users/GetUsers -> Para obtener todos los usuarios
(POST) {localhost}/MyRestfullApp/Users/CreateUser -> Para crear un usuario
(POST) {localhost}/MyRestfullApp/Users/UpdateUser/{id} -> Para actualizar un usuario en base a un id de usuario
(POST) {localhost}/MyRestfullApp/Users/DeleteUser/{id} -> Para borrar un usuario en base a un id de usuario

Contrato JSON para actualizar o crear un usuario:

{
  "LastName" : "a lastname",
  "FirstName" : "a firstname",
  "Email" : "a email",
  "UserPassword" : "a password"
}

```



