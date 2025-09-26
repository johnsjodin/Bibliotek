Om projektet
Detta är ett konsolbaserat bibliotekssystem byggt i C# och .NET 8. Systemet hanterar böcker och låneprocesser, och har tre olika användarroller: Bibliotekarie, Låntagare och Administratör. All data om böcker sparas i en JSON-fil.

Projektet är skrivet och designat av Grupp 6 i SYNE25.

Funktioner
Inloggning: Tre fasta användare (bibliotekarie, låntagare, admin) med olika behörigheter.
Bokhantering: Lägg till, ta bort, lista och sök böcker.
Utlåning/Återlämning: Låntagare kan låna och lämna tillbaka böcker.
Status: Systemet visar om en bok är tillgänglig eller utlånad.
Datahantering: Alla böcker sparas och läses från en JSON-fil.
Användarroller
Bibliotekarie
Lägg till böcker
Lista alla böcker
Sök böcker
Låntagare
Låna bok
Lämna tillbaka bok
Visa alla böcker
Admin
Lägg till bok
Sök bok
Ta bort bok
Visa alla böcker
Så här kör du programmet
Klona repot: git clone https://github.com/johnsjodin/Bibliotek.git
Navigera till projektmappen: cd Bibliotek
Bygg projektet: dotnet build
Starta applikationen: dotnet run --project Bibliotek
Inloggningsuppgifter (standard)
Bibliotekarie:
Användarnamn: librarian
Lösenord: librarian123
Låntagare:
Användarnamn: borrower
Lösenord: borrower123
Admin:
Användarnamn: admin
Lösenord: admin123
Reflektioner# Bibliotek
