# DVLD - Driving License Management System

This repository contains the code for the Driving License Management System (DVLD), a project designed to handle various services related to the issuance and management of driving licenses. This system aims to streamline the processes involved in issuing new licenses, renewing licenses, and replacing lost or damaged licenses, among other services.

## Features

- **License Issuance**: Issue new driving licenses for various categories.
- **License Renewal**: Renew existing driving licenses.
- **Replacement Services**: Replace lost or damaged driving licenses.
- **International Licenses**: Issue international driving licenses.
- **License Release**: Release a previously suspended license.
- **Re-examination Services**: Schedule and manage re-examinations for driving tests.

## License Categories

1. **Motorcycle License (Small)**
   - Minimum Age: 18
   - Fee: $15
   - Validity: 5 years

2. **Motorcycle License (Heavy)**
   - Minimum Age: 21
   - Fee: $30
   - Validity: 5 years

3. **Standard Vehicle License**
   - Minimum Age: 18
   - Fee: $20
   - Validity: 10 years

4. **Commercial Vehicle License (Taxi/Limousine)**
   - Minimum Age: 21
   - Fee: $200
   - Validity: 10 years

5. **Agricultural Vehicle License**
   - Minimum Age: 21
   - Fee: $50
   - Validity: 10 years

6. **Bus License (Small/Medium)**
   - Minimum Age: 21
   - Fee: $250
   - Validity: 10 years

7. **Heavy Vehicle License (Truck/Bus)**
   - Minimum Age: 21
   - Fee: $300
   - Validity: 10 years

## System Requirements

- **Applicant Information**: National ID, full name, date of birth, address, phone number, email, nationality, and a personal photo.
- **Application Information**: Application ID, application date, applicant's national ID, type of application, status of the application, and fees paid.
- **License Information**: License ID, license type, issue date, expiration date, and conditions if any.

## Application Process

1. **Initial Submission**: Submit the application with the required documents and fees.
2. **Medical Examination**: Pass a vision test and other necessary medical checks.
3. **Theoretical Test**: Pass a written test on traffic rules and driving safety.
4. **Practical Test**: Pass a driving test to demonstrate practical driving skills.
5. **License Issuance**: Upon successful completion of all tests and requirements, the driving license will be issued.

## How to Use

### Prerequisites

- **C# .NET and Visual Studio**: Ensure you have Visual Studio installed with C# .NET development capabilities.
- **SQL Server**: A SQL Server instance to host the database.

### Steps to Set Up

1. **Clone the Repository**:
   - Clone this repository to your local machine using the following command:
     ```bash
     git clone <repository-url>
     ```

2. **Restore the Database**:
   - Inside the `Database` folder, you will find the database backup file.
   - Restore this database in your SQL Server instance using SQL Server Management Studio (SSMS) or a similar tool.

3. **Configure the Connection String**:
   - Locate the connection string in the project under `DataLayer -> DBConnection`.
   - Ensure the connection string is correct and matches your SQL Server configuration.
   - The default credentials provided are:
     - **Username**: `user4`
     - **Password**: `1234`

4. **Build and Run the Project**:
   - Open the project in Visual Studio.
   - Build the solution to restore the necessary packages and compile the code.
   - Run the application to start using the Driving License Management System.
