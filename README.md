# Bibliotekssystem  

## Skapad av 👥 Grupp 6

- Jenny
- Aygen
- Charlie
- Frans
- John
- Daniel

---

## 📚 Om Applikationen

Detta är ett konsolbaserat bibliotekssystem utvecklat i C# (.NET 8) av Grupp 6. Applikationen gör det möjligt att hantera böcker, användare och låneprocesser på ett enkelt och användarvänligt sätt. Systemet är uppdelat i olika användarroller: **Admin**, **Librarian** (bibliotekarie) och **Borrower** (låntagare), där varje roll har olika behörigheter och funktioner.

---

## 🧑‍💻 Funktioner

- **Inloggning:**  
  Användare loggar in med användarnamn och lösenord. Systemet hanterar olika roller.

- **Admin:**  
  - Lägga till böcker  
  - Söka efter böcker  
  - Ta bort böcker  
  - Visa alla böcker

- **Librarian (Bibliotekarie):**  
  - Lägga till böcker  
  - Visa alla böcker  
  - Söka efter böcker

- **Borrower (Låntagare):**  
  - Låna böcker  
  - Lämna tillbaka böcker  
  - Visa alla böcker  
  - Söka efter böcker

- **Bokhantering:**  
  - Sökning på titel eller författare  
  - Låna och lämna tillbaka böcker  
  - Visuella statusmeddelanden för tillgänglighet

- **Datahantering:**  
  - Alla böcker sparas i en JSON-fil (`books.json`) för beständighet mellan sessioner.

---

## 🚀 Kom igång

### Förutsättningar

- .NET 8 SDK installerad  
- Visual Studio 2022 eller senare

### Installation

1. Klona detta repo:
2. 2. Öppna projektet i Visual Studio.
3. Bygg och kör applikationen.

---

## 📝 Användning

1. Starta programmet.
2. Logga in med någon av följande användare:
- **Admin:**  
  - Användarnamn: `admin`  
  - Lösenord: `admin123`
- **Librarian:** 
  - Användarnamn: `librarian`  
  - Lösenord: `librarian123`
- **Borrower:** 
  - Användarnamn: `borrower` 
  - Lösenord: `borrower123`
3. Navigera i menyn och utför önskade åtgärder beroende på din roll.

---

## 🛠️ Teknisk information

- **Språk:** C# 12.0  
- **Målramverk:** .NET 8  
- **Datafil:** `books.json` (lagrar alla böcker och deras status)
- **Arkitektur:** Objektorienterad, rollbaserad menyhantering

---

## 📄 Licens

Detta projekt är utvecklat i utbildningssyfte av Grupp 6.

---

## 👥 Grupp 6

- Jenny
- Aygen
- Charlie
- Frans
- John
- Daniel



---
