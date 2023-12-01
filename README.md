# Inicijalne upute za prijavu projekta iz Razvoja programskih proizvoda

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Razvoj programskih proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. Mentor će vam slati povratne informacije kroz sekciju Discussions također dostupnu na GitHubu vašeg projekta. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Scriptify
"Scriptify: Where Every Page Finds its Perfect Reader!"

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Luka Krševan Nižić | lnizic21@foi.hr | 0016155331 | lnizic21
David Škudar | dskudar20@foi.hr | 0016147892 | dskudar20
Marino Štura | mstura21@student.foi.hr | 0016153181 | mstura21-FOI

## Opis domene
Domena aplikacije za posudbu knjiga Scriptify obuhvaća stvaranje digitalne platforme koja omogućuje korisnicima posudbu knjiga od strane knjižnica. Ova aplikacija treba biti korisniku prijateljska, sigurna i pouzdana, istovremeno pružajući autenticiranu i raznovrsnu kolekciju knjiga. Glavni problem koji se rješava ovom aplikacijom je olakšavanje procesa pronalaženja te posudbe knjiga za kupca.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Autentikacija | Knjižnice se registriraju, a zatim knjižničari koriste svoje podatke za prijavu.| Luka Krševan Nižić
F02 | Upravljanje katalogom knjiga | Knjižnice dodaju, ažuriraju i brišu knjige s informacijama o slici, nazivu, opisu, žanru i vremenu čitanja. | Marino Štura
F03 | Napredno filtriranje i pretraživanje knjiga | Knjižnićari mogu koristiti napredno filtriranje i pretraživanje kako bi brže pronašli knjige. | David Škudar
F04 |Popis rezervacija | Prikazuje rezervacije za nedostupne resurse i obavještava o potrebi za novim primjercima često posuđivanih knjiga. | Luka Krševan Nižić
F05 | Pregled posudbi | Knjižničari mogu vidjeti popis posuđenih knjiga i informacije o posuđivaču. | Marino Štura
F06 | Upravljanje posudbama i sankcijama | Prima obavijest o isteku posudbe, prati povijest posudbi i primjenjuje sankcije za kašnjenje s vraćanjem resursa. | David Škudar
F07 | Izvještaji i statistika | Generira izvještaje o aktivnostima knjižnice, uključujući statistiku posudbe i popularnost resursa. | David Škudar
F08 | Posuđivanje/vraćanje knjige | Knjižničari evidentiraju posudbu i vraćanje knjiga. | Luka Krševan Nižić
F09 | Scriptify Aproved program | Knjižnica koja ima više od 30 posudbi ulazi u Scriptify Aproved program te se pojavljuje kao prva na listi knjižnica. | Marino Štura 
## Tehnologije i oprema
Implementaciju naše aplikacije radit ćemo u programskom jeziku C# te koristiti Microsoft Visual Studio razvojno okruženje. Za verzioniranje programskog koda koristit ćemo Git i GitHub. Kako bi pratili razvoj naše aplikacije pisat ćemo jednostavnu dokumentaciju u Github Wiki, a projektne zadatke ćemo planirati i pratiti u alatu GitHub projects. Za Backend koristimo lokalni Express.js i MySql bazu podataka za oba projekta. Express će komunicirati sa bazom dok će naše aplikacije hitati Express servis api-e i tako dobavljati podatke.
