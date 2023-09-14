-- Creation de la première vue

create view hotel_station
as
select h.id as hotel_id,
	h.station_id,
	h."name" as "Nom de l'Hôtel",
	h.category,
	h.address,
	h.city,
	s."name" as "Nom de Station",
	s.altitude
from hotel h 
join station s on h.station_id = s.id ;

-- Affichage de la vue

select * from hotel_station ;

create view booking_client
as
select b.id as booking_id,
	b.room_id,
	b.client_id,
	b.booking_date as "Date de reservation",
	b.stay_start_date as "Date de début de séjour",
	b.stay_end_date as "Date de fin de séjour",
	b.price as "Prix du séjour",
	b.deposit as "Acompte",
	c.first_name as "Prenom",
	c.last_name as "Nom",
	c.address as "Adresse",
	c.city as "Ville"
from booking b 
join client c on b.client_id = c.id ;

select * from booking_client ;


create view room_hotel_station 
as
select 
	s.id as "station_id",
	s."name" as "Nom de Station",
	s.altitude as "Altitude",
	h."name" as "Nom de l'hôtel",
	h.category as "Categorie",
	h.address as "Adresse",
	h.city as "Ville",
	r."number" as "Numéro de chambre",
	r.capacity as "Capacité",
	r."type" as "Type de chambre"	
from station s 
join hotel h on s.id = h.station_id
join room r on h.id = r.hotel_id ;

select * from room_hotel_station ;

create view booking_hotel_client
as
select
	h.id as "hotel_id",
	h.name as "Nom de l'hôtel",
	h.category as "Categorie",
	h.address as "Adresse",
	h.city as "Ville",
	r."number" as "Numéro de chambre",
	r.capacity as "Capacité de la chambre",
	r."type" as "Type de chambre",
	b.booking_date as "Date de reservation",
	b.stay_start_date as "Date de début de séjour",
	b.stay_end_date as "Date de fin de séjour",
	b.price as "Prix du séjour",
	b.deposit as "Acompte",
	c.first_name as "Prenom du client",
	c.last_name as "Nom du Client",
	c.address as "Adresse du client",
	c.city as "Ville du client"
from hotel h 
join room r on h.id = r.hotel_id 
join booking b on r.id = b.room_id
join client c on b.client_id = c.id ;


select * from booking_hotel_client ;


-- Rename d'une vue -- 

alter view booking_hotel_client rename to jeanjacques ;

-- Selection dans ROLES --

select * from pg_roles ;
select rolname from pg_roles ;

-- Creation d'un role  --

create role	application_admin
LOGIN
password '54156' ;

-- Ajout de Permission -- 

grant select , insert , update , delete 
on hotel 
to application_admin ;

-- Ajout de TOUTES les Permissions sur TOUTES les tables --

grant all
on all tables 
in schema "public"
to  application_admin ;

-- Ajout du Role client --

create role application_client
LOGIN
password 'jesuisunclient';

-- Ajout des Permissions du role client --

grant read 
on room_hotel_station
to application_client ;