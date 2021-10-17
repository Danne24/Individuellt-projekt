# Individuellt-projekt

Introduktion: 

Detta programmet är ett internetbank system där 5 stycken olika användare är inskriva i och kan logga in med sitt användarnamn och sin egna unika pinkod. När dem väl har loggat in så mötts dem av huvudmenyn där det finns 7 olika alternativ. Jag använder en switch case här för att hantera de olika svaren, den funkar väldigt bra som en meny. Användarna och deras pinkoder är sparade i arrayer medans användarnas konton och namnet på dem är sparade i listor. 

Det första alternativet skriver ut den inloggades konton och saldot på dessa. Jag använde en for-loop för att skriva ut all elementen som konto listorna innehåller, jag återanvänder denna flera gånger i koden. 

Det andra alternativet tillåter den inloggade användaren att föra över pengar från ett av sina konton till ett annat av sina konton. 

Det tredje alternativet tillåter användaren att ta ut pengar från ett av sina konton. Här så använde jag for-loopen för att skriva ut kontona igen, användaren väljer konto genom att mata in siffran som representerar det specifika kontots position i listan. 

Det fjärde alternativet loggar ut användaren ur huvudmenyn och hamnar tillbaka i inloggnings algoritmen, där en annan användare kan logga in istället om så önskas. 

Det femte alternativet tillåter användaren att öppna upp ett nytt konto eller att ta bort ett existerande konto som har 0 i saldo. 

Det sjätte alternativet tillåter användaren att sätta in pengar i valfritt konto. 

Det sjunde alternativet ger användaren möjligheten att över föra pengar från valfritt eget konto till valfritt konto som någon av de andra användarna äger. 

 

 

Reflektion: 

Jag är överlag väldigt nöjd med mitt program, det funkar väldigt bra och jag lyckades till och med lägga in hälften av extra utmaningarna. I början så tänkte jag att det här blir nog en väldigt så uppgift som kommer at ta väldigt lång tid att genomföra fast när jag väl började så märkte jag att uppgiften inte var så svår eller så stor som jag trodde att den skulle vara, jag jobbade väldigt metodiskt och gjorde klart en funktionalitet innan jag fortsatte till nästa, jag återanvände också mycket kod, bland annat algoritmen som skriver ut användarnas konton, så även fast mitt program är över 1100 rader kod långt så är ju en rätt så stor del av det återanvänd kod som nästan är helt identiska, det gör ju att programmet, ur ett annat perspektiv, inte alls är så stort som det kan se ut med en första anblick. 

Redan i början av projektet så visste jag att jag ville använda listor för att spara användarnas konton för att det betyder ju att jag kan lägga till fler konton i framtiden och på så sätt klara en av extra utmaningarna, dock så visste jag inte hur man definierar listor eller hur man lägger till nya element i dem, fast efter en snabb Google sökning så lärde jag mig hur man gjorde, det är inte speciellt svårt. Senare, i metoden där jag kan ta bort konton, så tänkte jag först att om man nu lägga till nya element i en lista, betyder det att man också kan ta bort existerande element från en lista? Efter att ha sökt på Google i igen så hittade jag information som visade hur man gjorde och det visade sig ju att det inte var så svårt att ta bort element, det är ju bara att använda RemoveAt(valfritt element);. 

Jag valde att använda arrayer för att spara användarnas namn och pinkod vilket när jag nu reflekterar över det så inser jag att jag egentligen inte behövde göra det, fördelen är dock att det ser lite snyggare ut och det blir väldigt lätt att ändra namnen och pinkoderna om jag så önskar. Jag funderade faktiskt på att också använda listor för användarna och deras pinkoder, så att jag skulle kunna skapa en metod som gör det möjligt att lägga till nya användare fast jag ångrade mig då jag insåg att det skulle bli för komplicerat, programmet skulle nog kunna bli ännu bättre om en sådan metod fanns, å andra sidan så skulle jag vara tvungen att göra stora ändringar i min kod för att åstadkomma detta dock. 

Algoritmen för att kolla om det angivna användarnamnet och pinkoden matchar är jag nöjd över, att användaren släpps in i huvudmenyn om både det angivna användarnamnet och pinkoden har samma position i sin respektive array, exempelvis svarPin == pin[0] && svarAnvändarnamn == användare[0], detta är ju rätt logiskt och gör det lätt att förstå hur algoritmen fungerar. 

För huvudmenyn så valde jag att använda en switch case, jag tycker att den är fenomenal att använda när man vill skapa en meny där användaren kan navigera till olika val, den är lätt att förstå och lätt att definiera. En liten förbättring som jag skulle kunna göra här är att ha de olika alternativen i en logisk ordning, utloggningen borde väl vara det sista alternativet? Som jag har det nu så lade jag bara in ett nytt alternativ när jag gjorde klart en ny metod, vilket exempelvis betyder att det sjätte alternativet är den sjätte metoden som jag skapade. 

En sak som jag är väldigt stolt över var hur jag lyckades lösa problemet med att skriva ut namnet och saldot på användarens konton, jag använde en for-loop som skriver ut ett element för varje iteration som loopen gör, och den upprepar det lika många gånger som listorna har element. I vissa metoder så låter jag även användaren välja ett konto och då så har jag helt enkelt en variabel som har samma siffra som kontot till höger har som plats i sin lista. Jag slet ett bra tag med att skapa denna algoritmen och den fungerar jätte bra, vet inte hur eller om jag kan göra den bättre. I början så tänkte jag att jag kunde använda en for each loop istället för en for loop, där användaren skulle skriva in kontonamnet på det kontot som användaren ville välja, fast det blev för komplicerat så jag beslutade mig att använda en for loop istället. 

En sak som jag ångrar lite nu i efterhand är att jag la till ett sätt för användaren att ångra sig när han eller hon är i en metod och istället återgå till huvudmenyn utan att ändra någonting genom att mata in 111. Visst det funkar faktiskt bra, inga fel vad jag kan se när jag testkör programmet, det jag ångrar var att jag la så pass mycket tid på det, det var förvånansvärt svårt att skapa den funktionalitet och det känns lite som att jag slösade bort tid och energi på att skapa en funktionalitet som ändå mycket sällan kommer att användas. Jag vet inte om jag kunde ha gjort detta på ett enklare sätt, detta var det enda sättet att skapa ett avbryts system som jag kunde tänka på. 

En metod som nog skulle kunna bli bättre är överför pengar till andra användare metoden, som du ser i huvudmenyn så har jag skrivit väldigt mycket kod i case 7 blocket, mycket återanvänd kod, jag försökte att hitta ett sätt så att jag inte behöver skriva så pass mycket kod fast jag kom inte på något bra och snyggt sätt att lösa den på, istället så blev det mycket återanvänd kod, fast nu så funkar den i alla fall och det är ju det viktigaste, har dock den känsla av att det är ganska enkelt att göra så att case 7 blocket ser bättre ut fast jag vet inte hur. 

En annan metod som möjligtvis skulle kunna bli bättre är metoden där användaren kan skicka pengar till en annan användares konto, så som jag har det nu så kan användare 1 se exakt vilket saldo användare 2 har på sina konton och det är kanske lite konstigt? Riktiga internetbanker fungerar inte så där, där så kan man ju sicka pengar till en annan användares konto utan att se vad det kontot har för saldo, det blir ju mer privat då. Jag skulle ju rätt så enkelt kunna ändra så att användares 2 saldo inte syns, dock så ger det ju en bättre respons till användaren med systemet som jag har nu, man ser tydligt att pengarna har översätts på rätt sätt och allting fungerar som det ska. 

En ny insikt som jag har fått här vad gäller programmering är att när man jobbar med så pass stora program som detta, över 1100 rader lång kod, så börjar det att bli lite svårt att hålla reda på alla dessa variabler, metoder och villkor. Jag har verkligen förstått vikten att vara flitig när man namnger, bland annat, variabler och metoder. I början av projektet så var jag tvungen att ändra lite variabel namn för att jag förstod inte med en anblick vad just den variabeln gör för någonting och varför den är viktig, under tiden när jag arbetade så blev jag bättre på att namnge och nu så tycker jag att jag har valt bra namn för mina variabler, listor, arrayer och metoder som jag använder i projektet. Jag har också förstått nyttan som metoder ger, det är väldigt smart att återanvända kod på det sättet, man kan ju också ha samma namn på variabler i olika metoder, till exempel en variabel som heter A och är av typen int och ligger i metoden 1 kommer inte att påverka int variabeln A i metoden 2 överhuvudtaget, detta har jag flitigt utnyttjat i mina egna metoder.
