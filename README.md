# ImportStorageSystem

Hey! This is a simple C# Console Application I made to simulate a pallet weighing system for a warehouse. 

## 🚀 How I improved this project

When I first started, my login system was super basic. I was using hardcoded variables (fixed values directly in the code) to check the username and password.

But as I learned new things, I decided to upgrade it:
* Now, instead of fixed credentials, I created a registration form (`RegisterForm`).
* When you register a new operator, the system saves the object inside a `List<T>` in memory.
* The login screen now loops through this `List<OperatorModel>` to validate if the user actually exists.

## 🛠️ What I practiced here

* C# Basics and Logic
* Object-Oriented Programming (OOP)
* Lists and Collections (`List<T>`)
* Sharing the same list instance between different files (`MainMenu`, `Login`, `RegisterForm`)

## 📦 How to run it

Just open your terminal and run:
```cmd
dotnet run
```

## 📬 Find me at
* **[LinkedIn](https://www.linkedin.com/in/raphael-oliveira-1201053ba/)**