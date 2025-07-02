# 🏦 Bank Management System

A desktop-based **Bank Management System** built with **C# Windows Forms** and connected to a **SQL Server** database. It features role-based access for Admins and Agents, with full user and transaction management.

## 🚀 Features

### 🔐 Login System
- Role-based login for:
  - **Admin**
  - **Agent**

### 👨‍💼 Admin Dashboard
- View a list of all agents
- Add new agents
- Edit agent details
- Delete agents
- Search for specific agents

#### 👤 Agent Dashboard
- View all users (bank account holders)
- Add new users
- Edit user details
- Delete users
- Search for specific users

#### 💳 Transaction Management
- View user balance
- Deposit money into user account
- Withdraw money from user account
- Transfer money between users

## 🛠️ Technologies Used
- **C# (.NET)**
- **Windows Forms**
- **SQL Server (ADO.NET for DB connection)**
- **Visual Studio**

## 📁 Project Structure
BankManagmentSystem/
├── Forms/ # All UI Forms (Login, Admin, Agent, etc.)
├── Database/ # DB connection logic and scripts
├── Program.cs # Main entry point
└── README.md # Project overview

## 💡 How to Run
1. Clone the repository:  git clone https://github.com/Israa-Alzein/bank-management-system.git
2. Open the solution (`.sln`) in **Visual Studio**.
3. Ensure your **SQL Server** is running and update the connection string in the code (usually in `DatabaseConnection.cs` or `App.config`).
4. Build and run the project.

