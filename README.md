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
Luka Nižić | lnizic21@foi.hr | 0016155331 | lnizic21
David Škudar | dskudar20@foi.hr | 0016147892 | dskudar20
Marino Štura | mstura21@student.foi.hr | 0016153181 | mstura21-FOI

## Opis domene
Domena aplikacije za posudbu knjiga Scriptify obuhvaća stvaranje digitalne platforme koja omogućuje korisnicima posudbu knjiga od strane knjižnica. Ova aplikacija treba biti korisniku prijateljska, sigurna i pouzdana, istovremeno pružajući autenticiranu i raznovrsnu kolekciju knjiga. Glavni problem koji se rješava ovom aplikacijom je olakšavanje procesa pronalaženja te posudbe knjiga za kupca.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija | Knjižnićari mogu registrirati knjižnicu pri čemu unose naziv, adresu, email, porezni broj, OIB vlasnika, kontakt vlasnika knjižnice te lozinku. Nakon registracije uneseni podaci se zapisuju u bazu podataka. | ...
F02 | Login | Knjižnice tj. knjižničari se prijavljuju koristeći svoje korisničke podatke, email i lozinku.| ...
F03 | Menadžment | Knjižnice imaju mogućnost dodavanja knjiga pri ćemu dodaju sliku knjige, naziv knjige, kratki opis, žanr te prosječno vrijeme čitanja. Knjižnice mogu naknadno mijenjati podatke o pojedinoj knjizi te se sve promjene automatski pohranjuju i ažuriraju u bazi podataka. | ...
F04 | Pregled dostupnih knjiga | Korisnici mogu u aplikaciji pregledati sve dostupne knjige svake registrirane knjižnice te klikom na pojedinu knjigu pregledati sve detaljne informacije o pojedinoj knjizi. |...
F05 | Posudba knjige | Korisnici mogu putem aplikacije posuditi neku od dostupnih knjiga pri čemu je rok posudbe mjesec dana.  | ...
F06 | Pregled posudbi | Kada se knjižnićar prijavi može vidjetu popis svih knjiga koje su posuđene te koji korisnik je posudio koju knjigu. | ...
F07 | Obavijest o isteku posudbe | Knjižnica prima obavijest kada se rok za vraćanje knjiga približava ili kada je istekao kako bi poduzeli određene radnje. | ...
F08 | Ocjena i recenzija knjiga | Korisnici mogu ocjenjivati i recenzirati knjige koje su posudili kako bi podijelili svoje iskustvo s drugim korisnicima. | ...
F09 | Povrat knjige | Nakon isteka roka za vraćanje knjige, korisnici trebaju imati mogućnost označiti povrat knjige kako bi označili da su je vratili knjižnici. | ...
## Tehnologije i oprema
Implementaciju naše aplikacije radit ćemo u programskom jeziku C# te koristiti Microsoft Visual Studio razvojno okruženje. Za verzioniranje programskog koda koristit ćemo Git i GitHub. Kako bi pratili razvoj naše aplikacije pisat ćemo jednostavnu dokumentaciju u Github Wiki, a projektne zadatke ćemo planirati i pratiti u alatu GitHub projects.
