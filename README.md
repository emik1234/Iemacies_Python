# Spēle "Iemācies Python!"

## Instrukcija
1. Ielādē failus .zip formātā
2. Atrodi mapi "IemaciesPython.zip" un atpako to
3. Atpakotajā mapē atver failu "IemaciesPython.exe"
4. Izbaudi spēli!

Spēles faili arī pieejami saitē - [_https://juris420.itch.io/iemacies-python_](https://juris420.itch.io/iemacies-python)

Spēle darbojas tikai uz operētājsistēmas Windows!


## Anotācija

Jaunrades darba “Iemācies Python!” darba autors ir Salaspils 1. vidusskolas 12. b klases skolnieks Emīls Juris Gelašs un darba vadītājs ir Salaspils 1. vidusskolas programmēšanas skolotājs Kirils Logins.

Galvenais projekta darba produkts ir spēles prototips, kas izveidots ar programmatūras “Unity” palīdzību.

Darba mērķis ir izveidot spēli latviešu valodā, kas iemāca programmēšanas valodas “_Python_” pamatus interesantākā un interaktīvā veidā. Spēles mērķauditorija ir skolēni vecumā no 12 līdz 17 gadiem.

Teorētiskajā daļā aprakstīts produkta tirgus, mērķauditorija un tās pamatojums, kā arī programmēšanas valodas izvēle un tās pamatojums.

Praktiskajā daļā aprakstīti spēles elementi un spēlē iekļautās programmēšanas tēmas, izmantotās programmatūras spēles izveidei, spēles ierobežojumi un nepieciešamie uzlabojumi, kā arī spēles testēšanas iegūtie rezultāti.

Spēli testēja desmit 9. klases skolēni, kuri pēc spēle testēšanas aizpildīja anketu, kuras rezultāti un apkopojums redzams diagrammās. Pēc aptaujas rezultātiem tika secināts, ka mācīšanās spēļu formātā ir interesantāks un efektīvāks veids kā apgūt dažādas tēmas, šajā gadījumā programmēšanas valodas pamatus.

## **Pētījuma aktualitāte**

Ar katru dienu programmēšanas nozare paliek pieprasītāka un svarīgāka katra cilvēka dzīvē. Programmēšana tiek pielietota ļoti daudz svarīgās nozarēs, kur bez tās, izdarīt kādu darbu aizņemtu daudz vairāk laika un dažreiz tas pat būtu neiespējami – medicīnā, telekomunikācijā, valsts aizsardzībā, transporta jomā, izglītībā u.c.

Programmēšana ļauj mums automatizēt darbus un procesus, veikt efektīvus pētījumus dažādās nozarēs (medicīna, astronomija), izstrādāt jaunus un noderīgus produktus bez kuriem mūsu dzīve būtu neiedomājama. Protams, kādam šis viss ir jāuzprogrammē, tāpēc ir svarīgi, ka skolēni tiek ieinteresēti programmēšanā, lai netrūktu kvalificētu programmētāju un šis attīstības process neapstātos. (1)

## **Problēma**

Mūsdienās visur pasaulē ļoti trūkst programmētāji, kas nozīmē, ka nav pietiekami daudz skolēnu, kas pēc skolas turpina apgūt programmēšanu. (2) Taču skolēni ir ieinteresēti datorspēlēs, un koncepts “_Gamifying_” (pievienot spēles elementus kādai tēmai) pastāv jau ilgu laiku. (3) Šī interese var tikt izmantota kā iespēja veidot mācību materiālus spēļu formātā, lai palielinātu skolēnu interesi mācīties programmēt un, lai skolēni saprastu, ka programmēšana nav tik sarežģīta, cik tas šķiet.

## **Darba mērķis**

Izveidot interaktīvu spēli/mācību materiālu latviešu valodā, kas saturēs spēļu elementus, lai ieinteresētu skolēnus un jauniešus mācīties programmēt valodā _Python._

## **Darba uzdevumi**

- Izpētīt dažādus spēļu elementus;
- Izveidot interaktīvus uzdevumus, iekļaujot noteiktus spēles elementus;
- Pielāgot uzdevumu sarežģītību mērķauditorijai;
- Izveidot spēles skices, dizainu;
- Izveidot spēli;
- Veikt testēšanu, saņemt atgriezenisko saiti no skolēniem;
- Veikt spēles uzlabošanu, balstoties uz atgriezenisko saiti.

# TEORĒTISKĀ DAĻA

## 1.1 Produkta tirgus

Datorspēles pamatā tiek veidotas, lai spēlētājs, sēžot krēslā, var izdarīt nereālistiskas lietas, ko īstajā dzīvē nav iespējams paveikt. Šīm spēlēm ir ļoti daudz un dažādi žanri – piedzīvojumu spēles, stratēģijas, sacensību, simulācijas spēles un daudz citas. Starp šiem žanriem pastāv arī izglītojošās spēles. Skatoties tieši no programmēšanas aspekta, populārākas ir mājaslapas, kas satur programmēšanas uzdevumus un spēles elementus, piemēram punktu krāšanu, līderu tabulas, u.c. Zināmākās no šīm mājaslapām ir [_https://www.hackerrank.com/_](https://www.hackerrank.com/) _un_ [_https://leetcode.com/_](https://leetcode.com/) , kas satur dažādus programmēšanas uzdevumus, sākot no pavisam vienkāršiem un beidzot ar ļoti sarežģītiem. No spēlēm, zināmākās ir _“CodeMonkey”_ un _“CodeCombat_”. Šīs spēles vairāk liek uzsvaru uz programmēšanu robotikas nozarē, iemācot pārvietot dažādus objektus, lai spēlētājs saprastu programmēšanas ideju. (3, 1) Kā arī visas šīs mājaslapas un spēles ir angļu valodā un latviešu valodā nav pieejamas.

Izpētot pieejamās opcijas latviešu valodā, ir pieejami ļoti daudz maksas un bezmaksas programmēšanas kursi, piemēram [_https://www.codelex.io/_](https://www.codelex.io/) un kā arī video un raksti. No spēļu aspekta izdevās atrast spēli _“100-gades programmēšanas stunda”,_ kas satur 10 dažādus uzdevumus, izmantojot programmēšanas valodu _Java Script._ Ir arī pieejamas dažādas galda spēles, kas ir saistītas ar problēmu atrisināšanas spējām un algoritmisko domāšanu, bet nav cieši saistītas ar programmēšanu. (4)

## 1.2 Mērķauditorija

Spēles galvenā mērķauditorija ir jaunieši no 12 līdz 17 gadu vecumam, kuri saprot latviešu valodu, jo spēles saturs un teksts ir pieejams tikai latviešu valodā. Kā arī ir ļoti ieteicams, ka spēlētājam ir priekšzināšanas par datorikas un programmēšanas būtību un kam tas ir nepieciešams. Šo spēli var arī spēlēt jaunieši, kas ir virs vai zem šīs vecuma grupas, bet uzdevumi un pamācības tika piemērotas norādītajai mērķauditorijai. Attiecīgi jaunākiem skolēniem šie uzdevumi varētu likties par sarežģītu, bet vecākiem – pārāk vienkārši. Tēmas un izskaidrojumi ir sagatavoti ļoti vienkārši ar reāliem dzīves piemēriem, lai skolēniem būtu vienkāršāk saprast tēmas būtību un jēgu. Šo spēli izmantotu skolā un ārpus tās kā mācību materiālu, lai saprastu valodas _Python_ pašus pamatus. Darba autors šo spēli piedāvās Latvijas skolām, skolotājiem un skolēniem, kā arī šo spēli varētu būt iespēja ielādēt ik vienam internetā.

## 1.3 Mērķauditorijas pamatojums

Izpētot 2020. gada _“Stack Overflow”_ programmētāju aptauju (skatīt 1.1. attēlu) par to, cik gadu vecumā programmētāji sāka programmēt, zemāk redzams, ka no 57,900 respondentiem, 51,5% jeb 29,818 cilvēki sāka programmēt vecumā no 12 līdz 17 gadiem. (5) Tātad, šī ir vēlamā mērķauditorija, jo šajā vecumā programmēšanai tiek piesaistīti visvairāk cilvēki.

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/3b0da699-2ae9-4c46-8477-fb8812d4fb79)

1.1 Attēls. Vecumi, kuros aptaujātie programmētāji sāka mācīties programmēt . (5)

## 1.4 Spēles programmēšanas valodas izvēle

Izvērtējot izmantotākās programmēšanas (skatīt 1.2. attēlu) (6), darba autors izvēlējās valodu _Python_, jo gan pēc personīgās pieredzes, gan arī pēc 2022. gada “_Stack Overflow_” programmētāju aptaujas (skatīt 1.3. attēlu) (7), _Python_ ir trešā izmantotākā valoda starp 73,268 respondentiem, kas mācās programmēt. _Python_ tika izveidots, lai tās kods un struktūra būtu vienkārša, viegli salasāma un kodolīga. Kā arī _Python_ sintakse sastāv no vienkāršas angļu valodas, tāpēc to ir daudz vienkāršāk izskaidrot latviešu valodā, salīdzinot ar citām valodām.

![image](https://github.com/emik1234/github_test/assets/79872484/f52ed8f8-9580-44e1-956f-c7df93f98bb1)

1.2 Attēls. Izmantotākās programmēšanas valodas starp 87,585 aptaujātiem programmētājiem. (6)

![image](https://github.com/emik1234/github_test/assets/79872484/47a3ff09-7028-4ba7-b4d7-669e93a1632a)


1.3. Attēls. Izmantotākās programmēšanas valodas starp cilvēkiem, kas mācās programmēt. (7)

# PRAKTISKAIS DARBS

## 2.1 Spēles pamatīpašības un komplektācija

Spēle simulē datora vidi, kurā ir dažādas aplikācijas. (skatīt 2.1. attēlu) Zemāk redzams īss apraksts par katru no aplikācijām, kā arī bilde ar tām.

![image](https://github.com/emik1234/github_test/assets/79872484/a194ab51-8e38-478d-b2c6-b6a4f953cfed)

2.1. Attēls. Spēles datora vide.

Atverot programmu, lietotājam ir jāpieslēdzas vai jāreģistrējas, ja nav izveidots konts (skatīt 2.2. attēlu). Tad kad tas ir izdarīts, lietotāja saglabātie dati tiek ielādēti un lietotājam ir piekļuve spēlei (skatīt 2.1. attēlu).

![image](https://github.com/emik1234/github_test/assets/79872484/1e414363-92c0-4022-8546-5f0d958231bc)

2.2. Attēls. Lietotāja pieslēgšanās.

1. _Piezīmju Grāmatiņa_ (skatīt 2.3. attēlu)

Šī aplikācija strādā tieši tāpat kā jebkurā datorā iebūvētā aplikācija “Piezīmju Grāmatiņa”. Šeit var pierakstīt un saglabāt sev noderīgu un svarīgu informāciju, ja tas ir nepieciešams.

![image](https://github.com/emik1234/github_test/assets/79872484/ecc12303-42d8-4dba-8d41-a8a767a066ad)

2.3. Attēls. _Piezīmju Grāmatiņa._

1. _“Python”,_ jeb koda redaktors (skatīt 2.4. attēlu)

Šī aplikācija ir domāta, lai tajā rakstītu _Python_ kodu, saglabātu to un to testētu. _Python_ kompilācijai tiek izmantota programmatūra “_WinPython”_ (8)

![image](https://github.com/emik1234/github_test/assets/79872484/4c95f126-0cd9-4b32-855d-5b498d44ee58)

2.4. Attēls. _“Python”._

1. _Faili,_ jeb Failu Pārlūks (skatīt 2.5. attēlu)

Šajā aplikācijā iespējams redzēt, atvērt un izdzēst visus saglabātos teksta un _Python_ failus.

![image](https://github.com/emik1234/github_test/assets/79872484/47b5d485-3964-43a5-8e69-f6067007bed7)

2.5. Attēls. _Faili._

1. _Pamācība_ (skatīt 2.6. attēlu)

Šī aplikācija izskatās un darbojas kā grāmata – katrā atvērumā ir informācija un teorija par kādu noteiktu _Python_ tēmu

![image](https://github.com/emik1234/github_test/assets/79872484/2545920a-0657-4ff7-989e-50990d6494ee)

2.6. Attēls. _Pamācība._

1. _Uzdevumi_ (skatīt 2.7. attēlu)

Šajā aplikācijā būs dažādi uzdevumi par dažādām tēmām, lai pārbaudītu un nostiprinātu skolēna zināšanas par šo tēmu

![image](https://github.com/emik1234/github_test/assets/79872484/3089837b-8ca9-4c8c-bff1-7d6248e9c72f)

2.7. Attēls. _Uzdevumi._

1. “Izvēlies Pareizo!” (skatīt 2.8. attēlu)

Šī aplikācija ir viktorīna, kas sastāv no dažādiem jautājumiem par _Python_ sintaksi un loģiku, un uz šiem jautājumiem ir jāatbild 10 sekunžu laikā. Katram jautājumam ir 3 izvēles opcijas un par katru pareizi atbildēto jautājumu tiek piešķirts punktu skaits. Punkti tiek piešķirt tik, cik palikušas sekundes, tas ir, ja atbildot ir palikušas 5 sekundes, spēlētājam tiek piešķirti 5 punkti.

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/2e0f02ca-9d0e-4def-877e-e908969df700)


2.8. Attēls. _“Izvēlies Pareizo!”._

## 2.2 Materiālu izvēle un pamatojums

Šī spēle tika veidota programmēšanas un spēļu platformā _Unity,_ kas piemērota spēļu izveidei. _Unity_ izmanto programmēšanas valodu _C#_ un programmatūru _.NET_, līdz ar ko, programmēšanas valoda, kas tika izmantota, ir _C#_, iekļaujot standarta _Unity_ bibliotēkas. Darba autors izlēma veidot projektu tieši šajā platformā, jo ir iepriekšēja pieredze veidot 2D spēles, kā arī šī platforma ļauj izstrādātājam veikt projektu vienā programmēšanas vidē, nemainot programmēšanas valodas. Lai spēlē varētu darboties ar _Python_ kodu, tika izmantota programmatūra _“WinPython”_ (8), kas ir atvērta pirmkoda programmatūra, lai varētu darboties ar _Python_ kodu bez tā speciālas ielādēšanas lokāli.

Tā kā šis produkts ir domāts, lai iemācītu _Python_ pamatus, tika iekļautas vienkāršākās tēmas sakārtotas no vienkāršākajām līdz salīdzinoši sarežģītākajām, neiekļaujot konceptus, kā piemēram, klases un to mantošana, ārējās bibliotēkas u.c.

Programmā tika iekļautas sekojošās tēmas (9):

- _print()_ funkcija un komentāri;
- Datu Tipi;
- Mainīgie;
- Simbolu virknes, indeksēšana un to funkcijas;
- Loģiskās vērtības;
- Operatori un to pielietošana;
- _if…elif…else_ sazarojumi;
- Saraksts un to funkcijas;
- _“for”_ cikls un funkcija _range();_
- _“while”_ cikls;
- Funkcijas.

## 2.3 Tehnoloģiskais pamatojums un risinājuma elementu pamatojums

Spēle atrodas datora vidē, kuras dizains ir aizņemts no operētājsistēmas _Windows 10,_ lai spēlētājam būtu sajūta, ka viņš darbojas reālā operētājsistēmas vidē. Spēlē var atvērt dažādas aplikācijas, kā arī izdzēst un izveidot jaunus failus, kas vēl vairāk iedod šo datora vides efektu. Datora fona attēls ir “Python” programmēšanas valodas logo, no kā var uzreiz saprast par ko būs spēle. Spēles krāsu toņi pamatā sastāv no pelēkas un melnas krāsas, lai radītu atmosfēru, kas atbilst profesionālai programmēšanas videi. Spēli pašlaik iespējams spēlēt tikai uz datora ar _Windows_ operētājsistēmu “_WinPython_” ierobežojumu dēļ, bet, pievienojot datubāzi, būtu iespējams šo spēli spēlēt arī uz telefoniem un citām ierīcēm ar dažādām operētājsistēmām.

## 2.4 Nepieciešamie resursi produkta izgatavošanai

Lai izveidotu šo projektu, darba autoram bija nepieciešama platforma _Unity_ un izstrādes vide (_Visual Studio_). Izstrādes vides vietā varēja izmantot teksta redaktoru, bet _Visual Studio_ ir standarta izstrādes vide priekš _Unity_, kā arī tas satur īpašus paplašinājumus tieši priekš _Unity_, lai programmās būtu vienkāršāk identificēt kļūdas un atrisināt tās.

Lai izstrādātu šādu spēli ir nepieciešams aptvert un izmantot objektorientētu programmēšanu, kā arī nepieciešamas plašas zināšanas par programmēšanas valodu _C#_ un _Unity_ standarta bibliotēkām. Nepieciešamas arī pamata zināšanas un izpratne par programmēšanas valodu _Python._

## 2.5 Produkta lietošana un lietošanas vides raksturojums

Pagaidām šis produkts ir veidots tikai datoram, jo pagaidām izveidotais dizains nav dinamisks (nepielāgojas ekrāna izmēram), tāpēc to uz telefona vai kādas citas ierīces, kas nav dators, pagaidām nevar izmantot. Lai uz datora varētu spēlēt šo spēli, nepieciešama operētājsistēma _Windows._ Lai šo spēli varētu spēlēt uz citām ierīcēm (telefons, planšetdators) un citām operētājsistēmām, būtu nepieciešams spēlei pievienot datubāzi, kas satur nepieciešamos failus, lai kompilētu _Python_ failus _–_ spēle nosūta pieprasījumu ar noteiktu kodu, datubāzē tiek kompilēts šis kods un izvaddati tiek atgriezti spēlei. Šim piegājienam būtu nepieciešams internets spēlēšanas laikā. Lai zinātu kā jāspēlē spēle, ir ierīkota detalizēta pamācība, kur aprakstīti spēles elementi un kā tos izmantot. Nepieciešams arī internets, lai ielādētu spēles failus uz sava datora, vai arī USB atmiņas karte vai kāda cita ierīce failu uzturēšanai, ja spēles faili jau ir pieejami lokāli. Tā kā spēle aizņem noteiktu atmiņu (262Mb), nepieciešams pieejams norādītais atmiņas apjoms.

Produktam ir pievienota datubāze ar _SQLite3_ palīdzību. Datubāze nodrošina lietotāju reģistrāciju un kontus, kas saglabāti lokāli. Katram lietotājam tiek saglabāti izpildītie uzdevumi.

Spēle pagaidām ir pieejama <https://juris420.itch.io/iemacies-python> (11). Spēles faili ir ielādējami .zip formātā. Lai spēli atvērtu, nepieciešams to atarhivēt, jāatver mape “IemaciesPython1.x” un tad ir jāatver fails “IemaciesPython.exe”.

## 2.5 Datubāze un tās raksturojums

Programma satur 1 lokālu datubāzi, kurā atrodas 2 tabulas:

- Tabula **users**: satur nejauši uzģenerētu lietotāja ID (6 skaitļi), lietotājvārdu un paroli.
- Tabula **data**: izveidota saitne ar tabulu **users.** Satur lietotāju ID un uztur katram lietotājam izpildītos uzdevumus aplikācijā “Uzdevumi”.

Datubāze satur relāciju **viens-pret-vienu** (one-to-one).

## **Tabulu izkārtojums:**

Tabula **users**

| **id INTEGER** | **username TEXT** | **password TEXT** |
| --- | --- | --- |
| **345723** | **lietotajs1** | **S98y3hf^&** |
| **124767** | **lietotajs2** | **Fiurdehs&^** |
| **…** | **…** | **…** |

Tabula **data**

| **id INTEGER** | **completed_tasks TEXT** |
| --- | --- |
| **345723** | Task1;Task2;Task3; |
| **124767** | Task1;Task5;Task8; |
| …   | …   |

## 2.6 Produkta testēšana

Datorikas stundā 9. klases skolēniem tika iedota šī spēle testēšanai un pēc spēles testēšanas skolēniem bija jāizpilda aptauja par spēli. (10) Skolēniem tika dotas nepilnas 40 minūtes spēles testēšanai, tāpēc nebija iespējams iziet cauri visai teorijai un uzdevumiem.

No aptaujātajiem, pusei ir bijusi iepriekšēja pieredze ar jebkāda veida programmēšanu, bet otra puse atzīmēja, ka vai nu varbūt nedaudz ir bijusi saistība ar programmēšanu, vai arī vispār nav bijusi pieredze ar programmēšanu. (skatīt 2.9. attēlu)

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/9df7fbd8-61e4-4810-aac8-907767d74971)

2.9. Attēls. _“Vai esi iepriekš mācījies programmēt?” (skatīt 1. pielikumā 2. jautājumu)_

Jautājumā “Vai spēlējot šo spēli, izprati programmēšanas valodas "_Python_" pamatus un to būtību?”, 40% atbildēja ar atbildi “Jā”, 50% atbildēja “Daļēji” un 10%, jeb 1 cilvēks atbildēja “Nē”. (skatīt 2.10. attēlu)

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/1659b69d-b8dd-49dd-8fc9-ac1a2ed15dc7)

2.10. Attēls. _“Vai spēlējot šo spēli, izprati programmēšanas valodas "Python" pamatus un to būtību?” (skatīt 1. pielikumā 3. jautājumu)_

2.11. attēlā redzams, ka lielākā daļa skolēnu saprata lielāko daļu no programmēšanas valodas teorijas. Ļoti iespējams, ka, savienojot šo spēli ar skolotāja palīdzību, skolēni izprastu visu teoriju un saprastu daudz vairāk. (skatīt 2.11. attēlu)

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/8c64b972-e389-4f55-8d38-c39ac46be796)

2.11. Attēls. _“Cik labi Tu izprati teoriju un iemācīto šajā spēlē?” (skatīt 1. pielikumā 4. jautājumu)_

Kā redzams 2.12. attēlā, 90%, jeb 9 no 10 aptaujātajiem uzskata, ka spēle kā mācību materiāls būtu efektīvāks mācīšanās veids nekā ierastie mācīšanās veidi. (skatīt 2.12. attēlu)

![image](https://github.com/emik1234/Iemacies_Python/assets/79872484/c33e591f-a8df-4d75-8e9a-c40a6525a82e)

2.12. attēls. _“Vai Tu domā, ka šāda veida mācīšana (spēles formātā) varētu būt efektīvāka nekā ierastie mācīšanas veidi?” (skatīt 1. pielikumā 5. jautājumu)_

# SECINĀJUMI

1. 80% no spēles testētājiem izprata lielāko daļu no teorijas, līdz ar ko, šī spēle varētu rosināt skolēnu interesi programmēšanā.
2. 90% no skolēniem uzskata, ka mācīšanās spēles formātā varētu būt efektīvāka nekā ierastie mācīšanās veidi.
3. Turpinot attīstīt šo spēli, varētu izveidot plašākas pamācības, jaunas mini-spēles, kā arī jaunus uzdevumus. Nepieciešams pievienot datubāzi, lai spēli varētu spēlēt uz dažādām operētājsistēmām.
4. Šāda tipa spēli varētu veidot arī citām programmēšanas valodām, piemēram, _Java Script, HTML/CSS, C++,_ un citām.
5. Nepieciešams ieguldīt daudz laiku un pacietību, kā arī nepieciešamas augstas zināšanas par objektu orientētu programmēšanu, lai realizētu šādu darbu.
6. Mācību materiāli spēles formātā ir efektīvs veids kā ieinteresēt skolēnus kādā nozarē, šajā gadījumā - programmēšanā.
7. Spēles faili ir publiski pieejami ikvienam šeit - <https://juris420.itch.io/iemacies-python> (11)

# LITERATŪRAS SARAKSTS

1\. Vanshika. (2022. gada 6. decembris). _Why is Programming important? The importance of computer programming explained_. Ielādēts no Codedamn: <https://codedamn.com/news/programming/why-is-programming-important-2>

2\. Trienpont International. (2023.. gada 17.. augusts). _How Severe Is The Global Shortage of Software Developers?_ Ielādēts no Medium: <https://medium.com/@trienpont/how-severe-is-the-global-shortage-of-software-developers-9b99da78ca13>

3\. Jawad, H. M., & Tout, S. (2021.). Gamifying Computer Science Education for Z Generation. _Information_.

4\. Baiba (2022. gada 18. oktobris). _Vai vēlies, lai tavs bērns kļūst par programmētāju? Lūk, kā vari viņu iedrošināt._ Ielādēts no datuve: <https://datuve.lv/zinas/vai-velies-lai-tavs-berns-klutu-par-programmetaju-luk-ka-vari-vinu-iedrosinat/>

5\. Stack Exchange. (2020. gada 28. februāris). _Stack Overflow_. Ielādēts no 2020 Developer Survey: [https://insights.stackoverflow.com/survey/2020#developer-profile-writing-that-first-line-of-code-overall](https://insights.stackoverflow.com/survey/2020%23developer-profile-writing-that-first-line-of-code-overall)

6\. Vailshery, L. S. (2024. gada 19. janvāris). _Most used programming languages among developers worldwide as of 2023_. Ielādēts no Statista: <https://www.statista.com/statistics/793628/worldwide-developer-survey-most-used-languages/>

7\. Stack Overflow. (2022.). _2022 Developer Survey_. Ielādēts no Stack Overflow: [https://survey.stackoverflow.co/2022/#most-popular-technologies-language-learn](https://survey.stackoverflow.co/2022/%23most-popular-technologies-language-learn)

8\. WinPython programmatūras mājaslapa - <https://winpython.github.io/>

9\. w3schools. (bez datuma). _Python Tutorial_. Ielādēts no w3schools: <https://www.w3schools.com/python/default.asp>

10\. Skolēnu veiktā aptauja: <https://forms.office.com/e/VdXL3Pf0Qy>

11\. Saite uz spēles failiem: <https://juris420.itch.io/iemacies-python>

# PIELIKUMI

## APTAUJAS JAUTĀJUMI

Aptauja pieejama šeit - <https://forms.office.com/e/VdXL3Pf0Qy> (10)

1. Norādi klasi

- 9
- 10
- 11

1. Vai esi iepriekš mācījies programmēt?

- Jā
- Nē
- Varbūt nedaudz

1. Vai spēlējot šo spēli, izprati programmēšanas valodas "Python" pamatus un to būtību?

- Jā
- Daļēji
- Nē

1. Cik labi Tu izprati teoriju un iemācīto šajā spēlē?

- Visu labi sapratu
- Lielāko daļu sapratu
- Pusi sapratu, pusi nesapratu
- Lielāko daļu nesapratu
- Vispār neko nesapratu

1. Vai Tu domā, ka šāda veida mācīšana (spēles formātā) varētu būt efektīvāka nekā ierastie mācīšanas veidi?

- Jā
- Nē

1. Īsi apraksti savas domas par izspēlēto spēli

\-

1. Vai ir kādi uzlabojumi/ieteikumi?

\-

1. Novērtē spēli un tās ideju

![](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAO4AAAAkCAYAAACOnQbwAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAANMSURBVHhe7Zw/b+IwGIdzd5XYGJC6devGxsZ363Ifj42NrVu3DpWQOjCgOz053sMNAWy/aWJLv0eynOaP/TjS++IE0x+fn59/GiFEVfw81UKIilDgClEhgwXu+/t7s9/vm8PhcNpTF/KfFvmnMcgz7m63a6Xh6empLTUh/2mRfzruT1wyjEnD29tbVVlT/tMi/zzcgfv6+trWs9msLWD7akD+0yL/PFyBG2abcIrAvhqypvynRf75uAKXaQGQaR4fH9tiWceOlYz8p0X++WQHLhmFN2lgmQZsm2MlZ035T4v8fWQHbjfbGLVkTflPi/x9ZAUuc/i+bGN0s05pmVP+0yJ/P1e/x6UzBCGsQwkyy2q1Ov31le12e3EuZT6ft39T277vQP7y91C6/0XgIsfr7LDTPujw+fn5v0gXrueLaW87qcj/H/LPoxb/i8DtyxTWKDV/W4mBtsLCjbH2rabd5XLZbnuR/1fM24r8b1OL/9XARYzGYgVToQ/LSPRxbcqRivzjkH8/tfhfvJyyt2Jhw0NDm+F0hKnCUMj/PvK/Ti3+v15eXn6ftlv42D4ej22jlI+Pj2axWDQPDw+nM3yYNFMGIKvZVGQI5H8b+d+mFv+LwIXvkh9K+h7y70f+cdTgf/NnfXRAR3TI9IGOqHMY66aHyP+M/NMp2f9m4MIQ8lzLQ78xxk035C9/D6X63105RQc8PCOLAANJxVaZwJg3HeQvfw+l+kcteaQjxAH5VOwa2hnzphvyl7+HEv2j1yrnZBrDZD1teJG//D2U5h8VuGGWMYkULFtBTsbyIn/5eyjRf5TADa+p8cbL34f8h/ePClz7iA8zRwgP37w1Y6UJ231ydu0UN17+8vdQon/0My50xU3YXpczQLb7BmBZx27CFMhf/h5K8k/6xLXOu8LAGs9wnSfHKJwbEg5mLOR/Rv7plOh/dwEGbDabtkaMjm0gwD5+8Y8wcJx/2cE5JsmAOW6DWK/XbT0W8pe/hxL9owKX7GISRle4C+I2gBDOH+onWLHI/4z80ynRPypwEaAA2QNh6hi6A2AVCoMeE/nL30OJ/lGBC3RMtriWYe5hGSv3ei/yl7+H0vyjA1cIUQ5JXwcJIcpAgStEdTTNXyrSgpka9J5rAAAAAElFTkSuQmCC)

## SPĒLES RESURSI

1. _Python Wallpaper._ Izstrādātājs wallpaperforu. [https://wallpaperforu.com/python-wallpaper-programming-minimalism-grey-technology/](https://wallpaperforu.com/python-wallpaper-programming-minimalism-grey-technology/%20)
2. _Python Logo_. Izstrādātājs FreebieSupply. <https://freebiesupply.com/logos/python-logo/>
3. _Notepad_. Izstrādātājs Freepik. <https://www.freepik.com/icon/notepad_4438839>
4. _Book_. Izstrādātājs zuozuozuozuozuozuo weibo .<https://www.veryicon.com/icons/business/colorful-office-icons/book-52.html>
5. _PC_, Izstrādātājs Freepik. <https://www.freepik.com/icon/pc_2292038>
6. _Question Mark._ Izstrādātājs Flaticon. <https://www.flaticon.com/free-icon/question-mark_4099904>
7. _File Explorer_. Izstrādātājs winaero. <https://winaero.com/download-file-explorer-icon-from-windows-10-build-18298/>
8. _Turn off_. Izstrādātājs Flaticon. <https://www.flaticon.com/free-icon/turn-off_3351670?term=turn+off&page=1&position=26&origin=tag&related_id=3351670>
9. _Close_. Izstrādātājs LogoWik. <https://logowik.com/close-vector-icon-7970.html>
10. _Play_. Izstrādātājs Flaticon. <https://www.flaticon.com/free-icon/play_727245?term=play+button&page=1&position=13&origin=tag&related_id=727245>
11. _Sound._ Izstrādātājs icons8. <https://icons8.com/icon/set/sound/windows--white>
12. _UI Pack (RPG Expansion)._ Izstrādātājs Kenney. <https://www.kenney.nl/assets/ui-pack-rpg-expansion>
