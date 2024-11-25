[![Open in Codespaces](https://classroom.github.com/assets/launch-codespace-2972f46106e565e64193e422d61a12cf1da4916b45550586e14ef0a7c637dd04.svg)](https://classroom.github.com/open-in-codespaces?assignment_repo_id=17308996)
# OOP-C--temple
Zadání úkolu
Cíl projektu
Cíl: Vytvořit jednoduchou aplikaci pro správu zaměstnanců v jazyce C#, která demonstruje polymorfismus, dědičnost, přetěžování konstruktoru a vlastnosti. Dalším cílem vyzkoušet si práci v týmu.
Popis zadání
Popis: Aplikace bude obsahovat třídu Employee, která bude mít následující atributy a metody:
name - jméno zaměstnance
salary - plat zaměstnance
position - pozice zaměstnance
Employee(name, salary, position) - konstruktor, který inicializuje všechny atributy
Employee(name, salary) - přetížený konstruktor, který inicializuje jméno a plat a nastaví pozici na "Unknown"
Name - vlastnost, která umožňuje čtení a nastavování jména
Salary - vlastnost, která umožňuje čtení a nastavování platu
Position - vlastnost, která umožňuje čtení a nastavování pozice
ToString() - metoda, která vrátí řetězec ve formátu "Name: {name}, Salary: {salary}, Position: {position}"
GetBonus() - abstraktní metoda, která vrátí částku prémie pro zaměstnance podle jeho pozice
Aplikace bude také obsahovat tři odvozené třídy od třídy Employee, které budou reprezentovat různé typy zaměstnanců:
Manager - třída pro manažery, kteří mají navíc atribut teamSize - velikost týmu, který vedou. Tato třída bude mít také svůj vlastní konstruktor a přetíženou metodu ToString(), která zahrne i velikost týmu. Metoda GetBonus() bude vrátit 10% z platu plus 100 Kč za každého člena týmu.
Developer - třída pro vývojáře, kteří mají navíc atribut language - programovací jazyk, ve kterém pracují. Tato třída bude mít také svůj vlastní konstruktor a přetíženou metodu ToString(), která zahrne i programovací jazyk. Metoda GetBonus() bude vrátit 15% z platu plus 500 Kč, pokud jazyk je "C#" nebo 300 Kč pro jiný jazyk.
Salesperson - třída pro obchodníky, kteří mají navíc atribut sales - počet prodejů, které provedli. Tato třída bude mít také svůj vlastní konstruktor a přetíženou metodu ToString(), která zahrne i počet prodejů. Metoda GetBonus() bude vrátit 5% z platu plus 50 Kč za každý prodej.
Aplikace bude také obsahovat třídu Company, která bude mít atribut employees - seznam zaměstnanců. Tato třída bude mít následující metody:
Company() - konstruktor, který vytvoří prázdný seznam zaměstnanců
AddEmployee(employee) - metoda, která přidá zaměstnance do seznamu
RemoveEmployee(name) - metoda, která odstraní zaměstnance podle jména ze seznamu
PrintEmployees() - metoda, která vypíše informace o všech zaměstnancích na konzoli
PayBonuses() - metoda, která vypočte a zaplatí prémie všem zaměstnancům podle jejich typu a pozice
Aplikace bude také obsahovat třídu Program, která bude mít metodu Main(), ve které se vytvoří instance třídy Company a několik instancí odvozených tříd od třídy Employee. Poté se zavolají metody třídy Company pro demonstraci funkčnosti aplikace.
Rozdělení úkolů:
Člen 1: Vytvořit třídu Employee a její atributy, konstruktory, vlastnosti a metody. Napsat technickou dokumentaci pro tuto třídu. Otestovat funkčnost této třídy vytvořením několika instancí této třídy a voláním jejich metod v Program.cs.
Člen 2: Vytvořit tři odvozené třídy od třídy Employee: Manager, Developer a Salesperson. Napsat technickou dokumentaci pro tyto třídy. Otestovat funkčnost těchto tříd vytvořením několika instancí těchto tříd a voláním jejich metod v Program.cs.
Člen 3: Vytvořit třídu Company a její atributy a metody. Napsat technickou dokumentaci pro tuto třídu. Otestovat funkčnost této třídy vytvořením instance této třídy a přidáním, odebráním, vypsáním a zaplacením prémie několika zaměstnancům v Program.cs.
Poznámka: Všechny soubory s kódem a dokumentací budou uloženy v repozitáři na GitHubu, který bude sdílen mezi členy týmu. Každý člen bude používat svou vlastní větev pro práci na svém úkolu a poté provede požadavek na sloučení do hlavní větve po dokončení svého úkolu. Každý člen bude také komentovat svůj kód a dokumentaci pro lepší srozumitelnost.


