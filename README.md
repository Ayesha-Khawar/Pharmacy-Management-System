# Pharmacy Management System (.NET Windows Forms)

## 📌 Project Overview  
The **Pharmacy Management System** is a desktop-based application developed in **C# (.NET Windows Forms)** with **SQL Server** as the backend database.  
It provides a structured way to manage **customers, medicines, prescriptions, and sales** while ensuring real-time synchronization with the inventory.  

This solution is built using a **layered architecture**:  
- **UI Layer (Forms)** → Handles user interaction.  
- **Business Logic Layer (Classes)** → Contains domain-specific operations.  
- **Data Access Layer (DBConnection)** → Centralized database connection handling.  

---

##  System Workflow  

1. **Authentication & Access Control**  
   - The system starts with a login form.  
   - After successful login, the user is redirected to the **Main Menu**.  

2. **Main Menu (Navigation Hub)**  
   - Provides access to different modules:  
     - **Customer Management**  
     - **Medicine Inventory**  
     - **Prescription Handling**  
     - **Sales & Billing**  
   - Includes a **Logout option** for secure exit.  

3. **Modules Workflow**  
   - **Customer Module**: Add, update, delete, and search customers. Linked to prescriptions.  
   - **Medicine Module**: Manage stock (insert/update/delete/search). Used in sales and prescriptions.  
   - **Prescription Module**: Connects customers with prescribed medicines.  
   - **Sales Module**: Handles selling medicines, updating inventory, and storing billing records.  

4. **Database Interaction**  
   - All modules depend on the `DBConnection` class to communicate with the **SQL Server** database.  
   - SQL queries are executed using parameterized commands to insert, update, delete, and fetch records.  

---

##  File & Class Workflow Explanation  

| **File / Class**        | **Purpose**                                                                                     |
|--------------------------|-------------------------------------------------------------------------------------------------|
| `DBConnection.cs`        | Provides centralized methods for **connecting and disconnecting** the SQL Server database. All other classes use this connection. |
| `customerClass.cs`       | Contains all **business logic for Customer entity** → Add, Update, Delete, Search customers, and retrieve their prescriptions. |
| `medicineClass.cs `       | (Similar to customerClass) → Handles **CRUD operations for medicines** and manages the pharmacy’s inventory. |
| `prescriptionClass.cs`   | Manages prescription records, linking **customers** with their **prescribed medicines**. |
| `saleClass.cs`          | Handles **sales transactions**, updates stock after sales, and records billing data. |
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
