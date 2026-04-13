# 🚢 Hundir la Flota

## 📌 Descripción
Proyecto de consola en C# que simula el juego clásico "Hundir la Flota" (Battleship).  
El jugador compite contra la CPU intentando hundir todos los barcos enemigos.

---

## 🧱 UML (Diseño de clases)

### Clases principales:

- **Casilla**
  - Representa una celda del tablero
  - Tiene: fila, columna, barco, disparada

- **Barco**
  - Representa un barco
  - Tiene: nombre, tamaño, impactos

- **Tablero**
  - Contiene una matriz 10x10 de Casillas
  - Gestiona colocación de barcos y disparos

- **Jugador**
  - Tiene un tablero y estadísticas

- **Cpu**
  - Hereda de Jugador
  - Juega automáticamente con posiciones aleatorias

- **Juego**
  - Controla todo el flujo del juego

- **ResultadoDisparo (enum)**
  - Agua | Impacto | Hundido | YaDisparado

---

## 📜 Reglas del juego

- El tablero es de **10x10**
- Cada jugador tiene una flota de barcos
- Los jugadores disparan por turnos
- El objetivo es hundir todos los barcos del enemigo
- Gana quien destruya primero toda la flota rival

---

## 🚢 Flota

La flota estándar contiene:

| Barco         | Tamaño |
|--------------|--------|
| Portaaviones | 5      |
| Acorazado    | 4      |
| Destructor   | 3      |
| Submarino    | 3      |
| Patrullera   | 2      |

---

## ⚙️ Mecánicas del juego

### 🔹 Colocación de barcos
- Se colocan automáticamente
- Pueden ser horizontales o verticales
- No pueden solaparse

---

### 🔹 Disparos
- El jugador introduce coordenadas (ej: A1, B5)
- El sistema responde con:
  - **Agua** 💧
  - **Impacto** 💥
  - **Hundido** 🚢
  - **YaDisparado** ⚠️

---

### 🔹 Turnos
- Turno del jugador
- Turno de la CPU (aleatorio)

---

### 🔹 Fin del juego
- El juego termina cuando todos los barcos de un jugador están hundidos

---

## ▶️ Ejecución

```bash
dotnet run

