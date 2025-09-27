Bibliotekssystem
Skapad av 👥 Grupp 6
Jenny
Aygen
Charlie
Frans
John
Daniel
📚 Om Applikationen
Detta är ett konsolbaserat bibliotekssystem utvecklat i C# (.NET 8) av Grupp 6. Applikationen gör det möjligt att hantera böcker, användare och låneprocesser på ett enkelt och användarvänligt sätt. Systemet är uppdelat i olika användarroller: Admin, Librarian (bibliotekarie) och Borrower (låntagare), där varje roll har olika behörigheter och funktioner.

🧑‍💻 Funktioner
Inloggning:
Användare loggar in med användarnamn och lösenord. Systemet hanterar olika roller.

Admin:

Lägga till böcker
Söka efter böcker
Ta bort böcker
Visa alla böcker
Librarian (Bibliotekarie):

Lägga till böcker
Visa alla böcker
Söka efter böcker
Borrower (Låntagare):

Låna böcker
Lämna tillbaka böcker
Visa alla böcker
Söka efter böcker
Bokhantering:

Sökning på titel eller författare
Låna och lämna tillbaka böcker
Visuella statusmeddelanden för tillgänglighet
Datahantering:

Alla böcker sparas i en JSON-fil (books.json) för beständighet mellan sessioner.
🚀 Kom igång
Förutsättningar
.NET 8 SDK installerad
Visual Studio 2022 eller senare
Installation
Klona detta repo:
2. Öppna projektet i Visual Studio.
Bygg och kör applikationen.
📝 Användning
Starta programmet.
Logga in med någon av följande användare:
Admin:
Användarnamn: admin
Lösenord: admin123
Librarian:
Användarnamn: librarian
Lösenord: librarian123
Borrower:
Användarnamn: borrower
Lösenord: borrower123
Navigera i menyn och utför önskade åtgärder beroende på din roll.
🛠️ Teknisk information
Språk: C# 12.0
Målramverk: .NET 8
Datafil: books.json (lagrar alla böcker och deras status)
Arkitektur: Objektorienterad, rollbaserad menyhantering
📄 Licens
Detta projekt är utvecklat i utbildningssyfte av Grupp 6.

👥 Reflektioner från Grupp 6
Hur gick samarbetet i gruppen?
Att samarbeta är en viktig del när man jobbar i grupp, och det är inte alltid enkelt. De flesta av oss har jobbat i grupp tidigare, men den här gången kändes det lite annorlunda.

Vi skapade en ToDo-lista och lade till uppgifter som behövde göras. Därefter valde vi själva vilka uppgifter vi ville ta ansvar för och började koda.

Det som var svårt var att programmet ibland kraschade när vi skulle slå ihop koden. Det var också utmanande att "göra om" koden för att få allt att fungera ihop.

Vi är en bra grupp med olika nivåer av kunskap i C#, och den här gången blev det så att de som kunde lite mer gjorde en större del av arbetet. Det är något vi lär oss av till nästa gång att fördela uppgifterna ännu bättre.

Vad har ni lärt er?
Vi har lärt oss att det är viktigt att först planera strukturen för hela projektet innan man börjar koda. Det hade sparat oss mycket tid och minskat risken för missförstånd och onödiga diskussioner.

Vi har också lärt oss att alltid göra en pull från GitHub innan man börjar koda, så man inte råkar skriva på gammal kod.

Vad var svårt eller utmanande?
Det var svårt att få all kod att fungera tillsammans, särskilt när olika delar var skrivna av olika personer. Även att förstå hur man använder interface i praktiken var en utmaning.

Vad gick bra?
Det gick bra att dela upp arbetet i mindre delar via vår ToDo-lista. Alla visste vad de skulle göra. Samarbetet fungerade bra trots svårigheterna, och vi lyckades till slut få ett fungerande program.

Hur var det att använda Git och Copilot?
Git var nytt för oss, och det tog några famlande försök i början att förstå hur det funkar med pull requests och att godkänna dem. Samt att starta nya brancher innan man kan pusha det man har programmerat. I framtiden kommer även detta att behöva diskuteras och planeras inför nya projekt, hur man ska namnge brancherna och vad som krävs av oss innan vi skickar upp något som ska godkännas.

Copilot verkar ha en tendens att inte titta på de andra filerna och klasserna i programmet, utan bara skriva nytt rakt av varje gång man använder den. Det kan vara något vi har missat om hur man ska använda det, men det medförde mer problem än lösningar. Den var väldigt dålig på att implementera existerande metoder där det är logiskt att använda dem och istället skriva nya metoder som gör samma sak.

