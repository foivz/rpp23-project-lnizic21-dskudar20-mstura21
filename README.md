# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa nastavnicima ili u sklopu WBL-a je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
(u redak iznad navedite kratki proizvoljni naziv projekta prikladan akademskoj zajednici, a ovaj tekst obrišite)

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Ime i prezime | mojaadresa@foi.hr | 000000000 | githubuser
Ime i prezime | ... | ... | ...

## Opis domene
Umjesto ovih uputa opišite domenu ili problem koji pokrivate vašim  projektom. Domena može biti proizvoljna, ali obratite pozornost da sukladno ishodima učenja, domena omogući primjenu zahtijevanih koncepata kako je to navedeno u sljedećem poglavlju. Priložite odgovarajuće skice gdje je to prikladno.

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija | Imamo dva različita registracijska ekrana, pri ćemu je jedan za registraciju korisnika, a drugi za registraciju knjižnica. Korisnici prilikom registracije unose ime, prezime, adresu i email, dok knjižnice unose naziv, adresu, email, porezni broj, OIB vlasnika te kontakt vlasnika knjižnice. Podatci registriranih korisnika i knjižnica se zapisuju u bazu podataka. | Zlatko Stapić
F02 | Login | Registrirani korisnici tj. knjižnice se prijavljuju svojim osobnim podacima. Korisnici se mogu prijaviti samo kao korisnici, a ne kao knjižnjice i obrnuto.| ...
F03 | Menadžment | Registrirane knjižnice imaju mogućnost dodavanja knjiga pri ćemu dodaju sliku knjige, naziv knjige, kratki opis, žanr, prosječno vrijeme čitanja te oznaku Scriptify Aproved. Korisnik može naknadno mijenjati podatke o pojedinoj knjizi te se sve promjene automatski pohranjuju i ažuriraju u bazi podataka. | ...
F04 | Pregled knjiga | Nakon što se korisnik logira u sustav, vidi popis svih knjižnica koje su registrirane u sustav. Korisnik može kliknuti na bilo koju knjižnicu i vdijeti popis knjiga koje odabrana knjižnica posjeduje. Ako korisnik klikne na neku od knjige, otvara se pregled svih informacija o toj knjizi koju želi posuditi. |...
F05 | Upravljanje knjigama | Knjižnice mogu vidjeti sve korisnike koji su posudili knjigu/e te vidjeti o kojoj/ima knjigama se radi. | ...
F06 | Posudba knjige | Omogućuje korisnicima da posude knjigu nakon što se klikne na gumb posudi, klikom na gumb otvara se opis knjige koju posuđuje. | ...
F07 | Recenzije i ocjene | Omogućuje korisnicima da ocjenjuju i recenziraju knjige. Agregiranje ocjena i recenzija kako bi korisnicima pomoglo u donošenju informiranih odluka. | ...
F08 | ... | ...

## Tehnologije i oprema
Umjesto ovih uputa jasno popišite sve tehnologije, alate i opremu koju ćete koristiti pri implementaciji vašeg rješenja. Ne zaboravite planirati korištenje tehnologija u aktivnostima kao što su projektni menadžment ili priprema dokumentacije. Tehnologije koje ćete koristiti bi trebale biti javno dostupne, a ako ih ne budemo obrađivali na vježbama u vašoj dokumentaciji ćete morati navesti način preuzimanja, instaliranja i korištenja onih tehnologija koje su neopbodne kako bi se vaš programski proizvod preveo i pokrenuo. Pazite da svi alati koje ćete koristiti moraju imati odgovarajuću licencu.
