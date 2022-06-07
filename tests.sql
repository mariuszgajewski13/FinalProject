SELECT * from seriale;
select * from koniec;
SELECT * from gatunki;


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




SELECT id_serialu, seriale.nazwa, seriale.id_gatunku_1, gatunki.nazwa FROM seriale JOIN gatunki ON
seriale.id_gatunku_1 = gatunki.id_gatunku WHERE gatunki.id_gatunku = seriale.id_gatunku_1
UNION
SELECT id_serialu, seriale.nazwa, seriale.id_gatunku_2, gatunki.nazwa FROM seriale JOIN gatunki ON
seriale.id_gatunku_2 = gatunki.id_gatunku WHERE gatunki.id_gatunku = seriale.id_gatunku_2
UNION
SELECT id_serialu, seriale.nazwa, seriale.id_gatunku_3, gatunki.nazwa FROM seriale JOIN gatunki ON
seriale.id_gatunku_3 = gatunki.id_gatunku WHERE gatunki.id_gatunku = seriale.id_gatunku_3