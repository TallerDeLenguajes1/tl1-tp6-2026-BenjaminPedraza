# Respuestas

## ¿String es un tipo por valor o un tipo por referencia?

`String` en C# es un **tipo por referencia**.
Esto significa que las variables de tipo `string` almacenan una referencia a la ubicación de la cadena en memoria y no el valor directamente.

Ejemplo:

```csharp
string texto1 = "Hola";
string texto2 = texto1;
```

Ambas variables hacen referencia al mismo contenido.

---

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape más utilizadas en `string` son:

| Secuencia | Descripción           |
| --------- | --------------------- |
| `\n`      | Salto de línea        |
| `\t`      | Tabulación            |
| `\\`      | Barra invertida (`\`) |
| `\"`      | Comillas dobles       |
| `\'`      | Comillas simples      |
| `\r`      | Retorno de carro      |
| `\b`      | Retroceso             |
| `\0`      | Carácter nulo         |

Ejemplo:

```csharp
string mensaje = "Hola\nMundo";
```

---

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

### `@` → Cadena verbatim

El carácter `@` permite escribir cadenas de texto sin escapar caracteres especiales.

Ejemplo:

```csharp
string ruta = @"C:\Usuarios\Santiago\Documentos";
```

Sin `@` habría que usar `\\`.

También permite escribir texto en múltiples líneas.

---

### `$` → Interpolación de cadenas

El carácter `$` permite insertar variables o expresiones dentro de una cadena usando `{}`.

Ejemplo:

```csharp
string nombre = "Santiago";
string saludo = $"Hola {nombre}";
```

Resultado:

```text
Hola Santiago
```

---

### Uso combinado `@$`

Se pueden combinar ambos caracteres:

```csharp
string nombre = "Santiago";

string texto = $@"Hola {nombre}
Bienvenido";
```
