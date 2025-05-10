
# 🏨 TP4 - Hotellerie ASP.NET Core MVC

This is a Code First ASP.NET Core MVC web application developed for **TP4**, featuring hotel management and user appreciation tracking.

---

## 📚 Features

- ✅ List, create, edit, and delete **Hotels**
- ✅ Add and view **Appreciations** (user reviews)
- ✅ Display **average note** per hotel
- ✅ Entity Framework Core with **Code First Migrations**
- ✅ Razor Views & Tag Helpers
- ✅ Fully localized (French labels & validation messages)

---

## ⚙️ Technologies Used

| Tech | Version |
|------|---------|
| ASP.NET Core MVC | 6 / 7 / 8 (depending on your SDK) |
| Entity Framework Core | ✔️ Code First |
| SQL Server / LocalDB | ✔️ |
| Razor Pages / Bootstrap | ✔️ |
| Visual Studio 2022 | ✔️ |

---

## 🏗️ Project Structure

```
TP4/
├── Controllers/
│   └── HotelsController.cs
│   └── AppreciationsController.cs
├── Models/
│   └── Hotel.cs
│   └── Appreciation.cs
├── Views/
│   ├── Hotels/
│   ├── Appreciations/
│   └── Shared/
├── Data/
│   └── HotellerieDbContext.cs
├── wwwroot/
```

---
![image](https://github.com/user-attachments/assets/da9ffe1b-9bba-46d2-8b52-4f9a45898658)
![image](https://github.com/user-attachments/assets/3c5537bc-221c-43de-85d3-6896accd0a9e)

## 🧪 How to Run Locally

### 1. Clone the repository

```bash
git clone https://github.com/EyaBenFredj/TP4.git
cd TP4
```

### 2. Restore dependencies

Open the solution in **Visual Studio**, or use:

```bash
dotnet restore
```

### 3. Apply migrations (Code First)

```bash
dotnet ef database update
```

> 💡 Make sure `appsettings.json` has the correct connection string.

### 4. Run the application

```bash
dotnet run
```

Then go to:  
🌐 `https://localhost:5001`

---

## 🧾 Database Schema

- **Hotels**
  - Id (PK)
  - Nom
  - Ville
  - Tel
  - SiteWeb
  - Etoiles 🌟
  - Pays

- **Appreciations**
  - Id (PK)
  - NomPers (User's name)
  - Commentaire
  - Note (1–10)
  - HotelId (FK)

---

## 📸 Screenshots

| Hotels List | Hotel Details + Notes |
|-------------|------------------------|
| ![Hotel Index](screenshots/hotels-list.png) | ![Details](screenshots/hotel-details.png) |

> 💡 Create a `screenshots/` folder and add your screenshots there.

---

## 📦 Deployment (Optional)

You can deploy this app on:

- **Azure App Service**
- **IIS**
- or host it via `dotnet publish`

Let me know if you want deployment instructions!

---

## 👩‍💻 Author

**Eya Ben Fredj**  
📬 [GitHub Profile](https://github.com/EyaBenFredj)  
🎓 TP4 Project — ASP.NET Core MVC


