#  Pharmacy Management System (.NET Windows Forms)

## 📌 Project Overview  
The **Pharmacy Management System** is a desktop-based application developed in **C# (.NET Windows Forms)** with **SQL Server** as the backend database.  
It provides a structured way to manage **customers, medicines, prescriptions, and sales** while ensuring real-time synchronization with the inventory.  

This solution is built using a **layered architecture**:  
- **UI Layer (Forms)** → Handles user interaction.  
- **Business Logic Layer (Classes)** → Contains domain-specific operations.  
- **Data Access Layer (DBConnection)** → Centralized database connection handling.  

---

##  System Workflow  

### 1. Authentication & Access Control  
- The system starts with a **login form**.  
- After successful login, the user is redirected to the **Main Menu**.  

![Login Screen](img/login.png)

---

### 2. Main Menu (Navigation Hub)  
- Provides access to different modules:  
  - **Customer Management**  
  - **Medicine Inventory**  
  - **Prescription Handling**  
  - **Sales & Billing**  
- Includes a **Logout option** for secure exit.  

![Main Menu](img/main-menu.png)  
![Main Menu - Prescriptions](img/main-menu2.png)  
![Main Menu - Sales](img/main-menu3.png)  
![Main Menu - Inventory](img/main-menu4.png)  
![Main Menu - Customer](img/main-menu5.png)  
![Logout](img/main-menu-logout.png)  

---

### 3. Modules Workflow  

#### 🧑‍🤝‍🧑 Customer Module  
- Add, update, delete, and search customers.  
- Customer data is linked to prescriptions.  

![Deleting Customer](img/deleting-cust-record.png)

---

####  Medicine Module  
- Manage stock (insert/update/delete/search).  
- Medicines are directly connected to sales and prescriptions.  

![Add Medicine](img/adding-medicines-record.png)  
![View Medicines Stock](img/viewing-medicines-stock.png)

---

####  Prescription Module  
- Handles prescriptions linked with **customers** and **medicines**.  
- Supports adding, deleting, and viewing prescriptions.  

*(Image: Already shown in main-menu2 for prescriptions section)*

---

####  Sales Module  
- Handles medicine selling, updates inventory in real time, and stores billing records.  

![Make Sale](img/sale-making.png)

---

####  Inventory Module  
- Real-time stock monitoring.  
- Allows searching medicines and viewing available quantities.  

![Search Inventory](img/viewing-searching-inventory.png)

---

### 4. Database Interaction  
- All modules depend on the `DBConnection` class to communicate with the **SQL Server** database.  
- SQL queries are executed using parameterized commands to insert, update, delete, and fetch records.  

---

## 🗂 File & Class Workflow Explanation  

| **File / Class**        | **Purpose**                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------------|
| `DBConnection.cs`        | Provides centralized methods for **connecting and disconnecting** the SQL Server database. All other classes use this connection. |
| `customerClass.cs`       | Contains all **business logic for Customer entity** → Add, Update, Delete, Search customers, and retrieve their prescriptions. |
| `medicineClass.cs`       | (Similar to customerClass) → Handles **CRUD operations for medicines** and manages the pharmacy’s inventory. |
| `prescriptionClass.cs`   | Manages prescription records, linking **customers** with their **prescribed medicines**. |
| `saleClass.cs`           | Handles **sales transactions**, updates stock after sales, and records billing data. |
| `MainMenu.cs` (Form)     | UI Form shown after login. Provides menus/buttons for navigating to different modules. |
| `Login.cs` (Form)        | UI Form for user authentication. Verifies credentials before granting access. |
| `*.Designer.cs` files    | Auto-generated UI design files created by Visual Studio for Windows Forms layout. |
| `Program.cs`             | Entry point of the application. Defines startup logic and initializes the login screen. |
| `PharmacyUser.cs`        | Handles **user authentication** by validating login credentials against the `login` table in SQL Server. Called from the Login Form. |

---

##  Technology Stack  
- **Programming Language**: C#  
- **Framework**: .NET Windows Forms  
- **Database**: Microsoft SQL Server (Relational Database)  
- **Architecture**: Layered (UI Layer → Business Logic Layer → Data Access Layer)  

---

##  Key Features  
- User authentication with secure session handling.  
- Centralized navigation via Main Menu.  
- Independent modules for Customer, Medicine, Prescription, and Sales.  
- Real-time inventory updates after sales.  
- Database-driven operations with exception handling.  

---
