# QR-Based Digital Library System

A desktop-based Digital Library Management System developed using C# Windows Forms and MySQL. The system automates book circulation using QR codes and provides features for book issuing, returning, fine calculation, activity logging, recommendations, and library analytics.

## 📌 Project Overview

The QR-Based Digital Library System is designed to simplify and automate common library operations.

Instead of manually entering book and student information, librarians can use QR codes to quickly issue and return books. The system also maintains digital borrowing records, calculates overdue fines, and provides administrative insights through dashboards and reports.

## ✨ Features

- 🔐 Secure user login and authentication
- 📚 Digital book management
- 👨‍🎓 Student/member management
- 📱 QR code-based book issuing
- 🔄 QR code-based book returns
- 📅 Automatic due-date tracking
- ⚠️ Overdue book detection
- 💰 Automatic fine calculation
- 📊 Library analytics and dashboard
- 📖 Borrowing history tracking
- 🚫 Defaulters identification
- 🤖 Book recommendation functionality
- 👥 Role-based access control
- 📝 Activity and system logging
- 🏢 Multi-branch library support
- 🔒 Security measures against common database attacks
- 💾 Database backup and archival support

## 🛠️ Technologies Used

### Frontend
- C#
- Windows Forms
- Guna UI / Guna2 Controls

### Backend
- MySQL
- MySQL Connector/NET

### QR Code
- ZXing
- AForge.Video

### Development Tools
- Visual Studio
- MySQL Workbench
- Git & GitHub

## 🏗️ System Modules

### Authentication
Provides login functionality and controls access according to the user's role.

### Book Management
Allows administrators and librarians to manage books, availability, authors, publishers, and related information.

### QR-Based Circulation
QR codes are used to quickly identify books and automate issuing and returning operations.

### Fine Management
The system automatically identifies overdue books and calculates applicable fines.

### Dashboard & Analytics
Provides information such as:

- Total issued books
- Overdue books
- Active borrowers
- Fine reports
- Most borrowed books
- Defaulters

### Recommendation System
Provides book recommendations based on available library and borrowing data.

### Activity Logging
Important system activities such as login, book issue, book return, fine payment, and failed attempts can be recorded for monitoring and auditing.

## 📸 Screenshots

### Login

![Login Screen](screenshots/login.png)

### Dashboard

![Dashboard](screenshots/dashboard.png)

### Book Management

![Book Management](screenshots/books.png)

### QR Scanner

![QR Scanner](screenshots/qr-scanner.png)

### My Books

![My Books](screenshots/my-books.png)

## 💻 Installation & Setup

### Prerequisites

Make sure the following software is installed:

- Visual Studio
- .NET Framework / required .NET version
- MySQL Server
- MySQL Workbench

### 1. Clone the Repository

```bash
git clone https://github.com/Azan-Qamar/QR-Based-Digital-Library-System.git