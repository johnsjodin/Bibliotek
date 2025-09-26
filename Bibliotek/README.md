# Bibliotek

## Om projektet

Detta �r ett konsolbaserat bibliotekssystem byggt i C# och .NET 8. Systemet hanterar b�cker och l�neprocesser, 
och har tre olika anv�ndarroller: Bibliotekarie, L�ntagare och Administrat�r. All data om b�cker sparas i en JSON-fil.

Projektet �r skrivet och designat av Grupp 6 i SYNE25.

## Funktioner

- **Inloggning**: Tre fasta anv�ndare (bibliotekarie, l�ntagare, admin) med olika beh�righeter.
- **Bokhantering**: L�gg till, ta bort, lista och s�k b�cker.
- **Utl�ning/�terl�mning**: L�ntagare kan l�na och l�mna tillbaka b�cker.
- **Status**: Systemet visar om en bok �r tillg�nglig eller utl�nad.
- **Datahantering**: Alla b�cker sparas och l�ses fr�n en JSON-fil.

## Anv�ndarroller

- **Bibliotekarie**
  - L�gg till b�cker
  - Lista alla b�cker
  - S�k b�cker
- **L�ntagare**
  - L�na bok
  - L�mna tillbaka bok
  - Visa alla b�cker
- **Admin**
  - L�gg till bok
  - S�k bok
  - Ta bort bok
  - Visa alla b�cker

## S� h�r k�r du programmet

1. Klona repot: git clone https://github.com/johnsjodin/Bibliotek.git
2. Navigera till projektmappen: cd Bibliotek
3. Bygg projektet: dotnet build
4. Starta applikationen: dotnet run --project Bibliotek

## Inloggningsuppgifter (standard)

- Bibliotekarie:  
- Anv�ndarnamn: `librarian`  
- L�senord: `librarian123`
- L�ntagare:  
- Anv�ndarnamn: `borrower`  
- L�senord: `borrower123`
- Admin:  
- Anv�ndarnamn: `admin`  
- L�senord: `admin123`

## Reflektioner

