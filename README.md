# 📦 Tienda - Gestión de Inventario y Ventas

## 📌 Descripción
Este proyecto es una aplicación desarrollada en **C#** que permite **gestionar el inventario de una tienda**, administrando **productos, clientes y ventas**. La aplicación utiliza **Programación Orientada a Objetos (POO)**, **matrices**, **listas** y **diccionarios** para organizar los datos de manera eficiente.

## 👤 Autor
**Marlon Montenegro**

## 🎯 Objetivo
El sistema permite registrar y administrar productos, clientes y ventas, garantizando un control preciso del stock y facilitando el seguimiento de las transacciones comerciales.

---

## 🛠️ **Tecnologías y Conceptos Utilizados**
✅ **C#** - Lenguaje de programación principal  
✅ **POO (Programación Orientada a Objetos)** - Organización del código en clases  
✅ **Matrices (5x10)** - Para almacenar el stock de productos por categoría  
✅ **Listas (`List<T>`)** - Para gestionar clientes  
✅ **Diccionarios (`Dictionary<int, Venta>`)** - Para registrar y gestionar las ventas  
✅ **WinForms** - Interfaz gráfica para la interacción con el usuario  

---

## 📌 **Requerimientos y Funcionalidades**

### 🔹 **1. Clases y Estructura POO**
El proyecto está basado en **clases bien definidas**:

- **`Producto`**: 
  - ID, nombre, categoría, precio, cantidad en stock.
- **`Cliente`**:  
  - ID, nombre, dirección y número de teléfono.
- **`Venta`**:  
  - Relaciona un cliente con productos comprados, cantidad y total a pagar.

---

### 🔹 **2. Gestión de Datos**
- **🗄️ Matrices (Stock de productos)**  
  - Se representa con una **matriz de 5x10**, donde **5 categorías** tienen hasta **10 productos** cada una.
  
- **📋 Listas (`List<T>`)**  
  - Se utilizan para **almacenar clientes registrados**.

- **🛒 Diccionarios (`Dictionary<int, Venta>`)**  
  - La **clave es el ID de la venta** y el **valor es un objeto `Venta`**, lo que facilita la consulta y eliminación de ventas.

---

### 🔹 **3. Funcionalidades Implementadas**
✔ **Registrar nuevos productos y clientes**  
✔ **Mostrar el stock disponible de productos**  
✔ **Realizar ventas asignando un cliente y productos comprados**  
✔ **Consultar ventas realizadas**  
✔ **Eliminar ventas y devolver productos al stock**  

---
