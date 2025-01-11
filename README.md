1. Temat i cel biznesowy aplikacji
Temat
Bankowa aplikacja desktopowa, umożliwiająca zarządzanie wieloma kontami, przeprowadzanie transakcji oraz przeglądanie statystyk finansowych.

Cel biznesowy
Aplikacja ma na celu uproszczenie zarządzania finansami osobistymi poprzez:

- Monitorowanie salda na wielu kontach.
- Zarządzanie transakcjami (wpływy i wydatki).
- Prezentowanie statystyk finansowych w formie wykresów.
- Obsługę różnych walut z uwzględnieniem kursów wymiany.


2. Użyte technologie
- Język programowania: C# (.NET Framework)
- Baza danych: SQLite
- Interfejs użytkownika: Windows Forms
Inne: Model obiektowy, implementacja interfejsów, LINQ

3. Lista funkcjonalności
   
Funkcjonalności aplikacji:
Zarządzanie kontami:

- Wyświetlanie listy kont bankowych z saldem i walutą.
- Przełączanie między kontami.
- Wyświetlanie szczegółów transakcji dla wybranego konta.
  
Transakcje:

- Przeprowadzanie transakcji (wpływy i wydatki).
- Aktualizacja salda konta po każdej transakcji.
- Przechowywanie historii transakcji w bazie danych.
  
Statystyki finansowe:

- Prezentacja wykresu słupkowego z dochodami i wydatkami.
  
Obsługa walut:

- Automatyczne przeliczanie kwoty na lokalną walutę z uwzględnieniem kursu wymiany.


Przykładowy zrzut ekranu:
Zarządzanie kontami:

![Zrzut ekranu 2025-01-11 191540](https://github.com/user-attachments/assets/474fbd89-6c17-450c-8e66-9d2b22fc3cba)


Statystyki finansowe:

![Zrzut ekranu 2025-01-11 191548](https://github.com/user-attachments/assets/59ed55da-2a35-4f75-a887-95829563a026)


4. Instalacja i uruchomienie
Wymagania wstępne:
- Visual Studio 2019/2022 (lub nowsze) z zainstalowanym .NET Framework.
- SQLite (plik data.db dostępny w repozytorium).
  
Kroki instalacji:
Sklonuj repozytorium:
- git clone [https://github.com/TwojRepozytorium/BankApp.git](https://github.com/xClaudi/BankApp.git)
- Otwórz projekt w Visual Studio.
- Przygotuj bazę danych SQLite:
- Plik data.db umieść w katalogu projektu (ścieżka jest już skonfigurowana w kodzie).
  
Uruchom aplikację:
- Wybierz projekt jako główny i uruchom (F5).

  5. Opis architektury
Ogólna architektura:
- Aplikacja oparta na wzorcu obiektowym:
- Klasy Account i CurrencyAccount reprezentują konta.
- Klasa Transaction przechowuje dane o transakcjach.
- Klasa Database obsługuje interakcje z bazą danych SQLite.
- Interfejs graficzny (GUI) oparty na Windows Forms:
- Formularz główny (MainForm) umożliwia dostęp do funkcji aplikacji.
- Formularze (AccountForm, StatForm) wyświetlają szczegóły kont i statystyki.
  
Główne elementy obiektowe
Account (klasa bazowa):

Właściwości: Currency, Amount, AccountNumber, Transactions.
Metody: DoTransaction.
CurrencyAccount (klasa pochodna):

Dodatkowe właściwości: ExchangeRate, Symbol.
Metoda: GetNativeCurrencyAmount.
Transaction:

Właściwości: Amount, Merchant.
Database:

Obsługuje zapytania SQL, pobieranie danych o kontach i transakcjach.


     Klasa	  Dziedziczenie 	Interfejs	Relacja
   Account	        -	         IAccount  Klasa bazowa
CurrencyAccount	 Account	        -	   Dziedziczy
  Transaction	   -	            -	   Kompozycja
   Database	       -	            -	  Obsługuje bazę

6. Diagram klas UML
Diagram UML dla aplikacji:

+---------------------+
|      IAccount       |
+---------------------+
| + Amount: double    |
| + Currency: string  |
| + AccountNumber: int|
| + Transactions: List<Transaction> |
| + DoTransaction()   |
+---------------------+
           ^
           |
+---------------------+
|      Account        |
+---------------------+
| + Amount: double    |
| + Currency: string  |
| + AccountNumber: int|
| + Transactions: List<Transaction> |
| + DoTransaction()   |
| + GetNativeCurrencyAmount() |
+---------------------+
           ^
           |
+---------------------+
|   CurrencyAccount   |
+---------------------+
| + ExchangeRate: double |
| + Symbol: string       |
| + GetNativeCurrencyAmount() |
+---------------------+

+---------------------+
|      Transaction    |
+---------------------+
| + Amount: double    |
| + Merchant: string  |
+---------------------+

+---------------------+
|      Database       |
+---------------------+
| + GetAccounts(): List<IAccount> |
| + DoTransfer()                   |
| + GetTransactions(): List<Transaction> |
+---------------------+




