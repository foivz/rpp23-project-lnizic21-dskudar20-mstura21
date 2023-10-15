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
F01 | Registracija | Imamo dva različita registracijska ekrana, pri ćemu je jedan za registraciju korisnika, a drugi za registraciju knjižnica. Korisnici prilikom registracije unose ime, prezime, adresu i email, dok knjižnice unose naziv, adresu, email, porezni broj, OIB vlasnika te kontakt vlasnika knjižnice. Podatci registriranih korisnika i knjižnica se zapisuju u bazu podataka. | ...
F02 | Login | Registrirani korisnici tj. knjižnice se prijavljuju svojim osobnim podacima. Korisnici se mogu prijaviti samo kao korisnici, a ne kao knjižnjice i obrnuto.| ...
F03 | Menadžment | Registrirane knjižnice imaju mogućnost dodavanja knjiga pri ćemu dodaju sliku knjige, naziv knjige, kratki opis, žanr, prosječno vrijeme čitanja te oznaku Scriptify Aproved. Korisnik može naknadno mijenjati podatke o pojedinoj knjizi te se sve promjene automatski pohranjuju i ažuriraju u bazi podataka. | ...
F04 | Pregled knjiga | Nakon što se korisnik logira u sustav, vidi popis svih knjižnica koje su registrirane u sustav. Korisnik može kliknuti na bilo koju knjižnicu i vdijeti popis knjiga koje odabrana knjižnica posjeduje. Ako korisnik klikne na neku od knjige, otvara se pregled svih informacija o toj knjizi koju želi posuditi. |...
F05 | Upravljanje knjigama | Knjižnice mogu vidjeti sve korisnike koji su posudili knjigu/e te vidjeti o kojoj/ima knjigama se radi. | ...
F06 | Posudba knjige | Omogućuje korisnicima da posude knjigu nakon što se klikne na gumb posudi, klikom na gumb otvara se opis knjige koju posuđuje. | ...
F07 | Recenzije i ocjene | Omogućuje korisnicima da ocjenjuju i recenziraju knjige. Agregiranje ocjena i recenzija kako bi korisnicima pomoglo u donošenju informiranih odluka. | ...
F08 | Primitak knjige | Korisnik u narudžbama ima knjigu koju je naručio i status je pending, sve dok korisnik ne dobije knjigu. Kada služba za dostavljanje dostavi korisniku knjigu, korisnik je dužan obavijestiti da je knjigu prihvatio. Pritiskom na gumb obavljeno, narudžba će biti obavljena.
F09 |Scriptify Aproved program | Korisnici koji imaju Scriptify wallet, mogu platiti one-time cijenu za posebne ponude knjiga, knjige koje tek dolaze ili koje su tek najavljane. Knjižare imaju opciju za svaku knjigu staviti Scriptify Aprooved tag gdje u tom slučaju samo korisnici iz ovog programa mogu čitati knjigu. Za druge korisnike koji nisu platili knjiga se neće pojaviti.
## Tehnologije i oprema
Implementaciju naše aplikacije radit ćemo u programskom jeziku C# te koristiti Microsoft Visual Studio razvojno okruženje. Za verzioniranje programskog koda koristit ćemo Git i GitHub. Kako bi pratili razvoj naše aplikacije pisat ćemo jednostavnu dokumentaciju u Github Wiki, a projektne zadatke ćemo planirati i pratiti u alatu GitHub projects.
