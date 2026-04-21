# 🍕 Pizza S7S - WinForms Application

A desktop pizza ordering application built using **C# and Windows Forms**, focusing on dynamic UI interaction, real-time price calculation, and clean event-driven design.

---

## 🚀 Overview

This project simulates a real-world pizza ordering system where users can:

* Select pizza size
* Choose toppings
* Pick crust type
* Decide whether to eat in or take out
* See a live-updated order summary and total price

The application emphasizes **UI responsiveness and logical separation of concerns**.

---

## 🖼️ Screenshots

### 🎯 Main Screen

![Main UI](PIZZA%20s7s.png)

### 🍕 Order Page

![Order UI](Pizza.jpg.jpg)

### ➡️ Navigation UI

![Arrow](arrowpoint-icon-png.jpg)

---

## 🧠 Core Features

### ✅ Dynamic Price Calculation

* Price updates instantly based on:

  * Size (Small / Medium / Large)
  * Toppings (each adds cost)
  * Crust type

Implemented in:

* `CalculatePrice()` 

---

### ✅ Real-Time Order Summary

* Displays:

  * Selected size
  * Selected toppings
  * Crust type
  * Eat-in / Take-out

Handled via:

* `UpdateToppings()`
* Label bindings

---

### ✅ Interactive UI Feedback

* Selected toppings turn **green**
* Disabled sections after order confirmation
* Clean reset functionality

---

### ✅ Navigation Between Forms

* Entry screen (LoginForm)
* Order screen (FrmOrder)

Navigation logic:

* `FrmOrder frm = new FrmOrder();` 

---

### ✅ Order Validation & Confirmation

* Confirmation dialog before placing order
* Prevents accidental submissions

---

## 🏗️ Project Structure

```
MyFirstWinFormsProject/
│
├── FrmOrder.cs
├── FrmOrder.Designer.cs
│
├── LoginForm.cs
├── LoginForm.Designer.cs
│
├── Program.cs
│
├── Images/
│   ├── pizza.jpg
│   ├── PIZZA s7s.png
│   ├── arrow icon
```

---

## ⚙️ Technologies Used

* C#
* .NET Framework (WinForms)
* Event-Driven Programming
* LINQ (basic usage)

---

## 🧩 Key Technical Concepts

### 🔹 Event-Driven Architecture

Each UI interaction triggers logic:

* RadioButtons → update size & price
* CheckBoxes → update toppings & price

---

### 🔹 Separation of Concerns

Core logic is divided into:

* `CalculatePrice()`
* `GetToppings()`
* `UpdatePrice()`
* `UpdateToppings()`

---

### 🔹 State Management via UI Controls

Application state is derived from:

* Checked RadioButtons
* Checked CheckBoxes

---

## 🔄 Application Flow

1. App starts → `LoginForm` 
2. User clicks **Order Now**
3. Opens `FrmOrder`
4. User customizes pizza
5. Price updates dynamically
6. User confirms order
7. UI locks after submission

---

## 🧪 How to Run

1. Clone the repository
2. Open `.sln` file in Visual Studio
3. Build the solution
4. Run the project

---

## ⚠️ Known Limitations

* Pricing is hardcoded (not configurable)
* Business logic tightly coupled with UI
* No database or persistence layer
* No input validation for missing selections

---

## 🔮 Future Improvements

* Refactor to MVC-like structure
* Add database (SQL Server)
* Implement user authentication
* Convert to REST API backend
* Improve UI/UX (animations, themes)
* Add order history

---

## 👨‍💻 Author

Developed as a practical project to understand:

* WinForms Controls
* UI interaction patterns
* Event-driven programming in C#

---

## 📌 Final Note

This project demonstrates a strong foundation in:

* Desktop application development
* UI logic handling
* Code organization at an intermediate level

Further improvements can elevate it to production-grade quality.
