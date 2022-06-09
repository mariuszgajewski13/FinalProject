SELECT * from seriale;
select * from koniec;
SELECT * from gatunki;
select * from do_obejrzenia;
select * from przerwa;
select * from na_biezaco;

SELECT seriale.nazwa, rok_rozpoczecia, rok_zakonczenia, gatunki.nazwa 
from koniec 
join seriale on koniec.id_serialu = seriale.id_serialu 
join gatunki  on gatunki.id_gatunku = seriale.id_gatunku_1 
where koniec.id_serialu = seriale.id_serialu 
and 
seriale.id_gatunku_1 = gatunki.id_gatunku
UNION
SELECT seriale.nazwa, rok_rozpoczecia, rok_zakonczenia, gatunki.nazwa 
from koniec 
join seriale on koniec.id_serialu = seriale.id_serialu 
join gatunki  on gatunki.id_gatunku = seriale.id_gatunku_2
where koniec.id_serialu = seriale.id_serialu 
and 
seriale.id_gatunku_2 = gatunki.id_gatunku
UNION
SELECT seriale.nazwa, rok_rozpoczecia, rok_zakonczenia, gatunki.nazwa 
from koniec 
join seriale on koniec.id_serialu = seriale.id_serialu 
join gatunki  on gatunki.id_gatunku = seriale.id_gatunku_3
where koniec.id_serialu = seriale.id_serialu 
and 
seriale.id_gatunku_3 = gatunki.id_gatunku

SELECT id_serialu, seriale.nazwa, gatunki.nazwa FROM seriale INNER JOIN gatunki ON
seriale.id_gatunku_1 = gatunki.id_gatunku WHERE gatunki.id_gatunku = seriale.id_gatunku_1
and  EXISTS
(SELECT gatunki.nazwa FROM seriale INNER JOIN gatunki ON
seriale.id_gatunku_2 = gatunki.id_gatunku WHERE gatunki.id_gatunku = seriale.id_gatunku_2)

SELECT DISTINCT seriale.nazwa, gatunki.nazwa 
FROM gatunki JOIN seriale ON gatunki.id_gatunku = seriale.id_gatunku_1
GROUP BY gatunki.nazwa, seriale.id_serialu, seriale.nazwa
UNION
SELECT DISTINCT seriale.nazwa, gatunki.nazwa 
FROM gatunki JOIN seriale ON gatunki.id_gatunku = seriale.id_gatunku_2
GROUP BY gatunki.nazwa, seriale.id_serialu, seriale.nazwa


