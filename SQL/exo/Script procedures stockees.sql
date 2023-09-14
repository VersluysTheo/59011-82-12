-- Creation d'une fonction pour changer la date en chaine de caractere --

create or replace function format_date(date date, separator VARCHAR)
returns VARCHAR
language plpgsql
as $$ 
begin
	return to_char(date, 'DD' || separator || 'MM' || separator || 'YYYY' );
end;
$$

-- Ceci ne fonctionne pas --

create function format_date(date date, separator VARCHAR)
returns VARCHAR
language plpgsql
as $$ 
begin
	return to_char(date, 'DD' / separator / 'MM' / separator / 'YYYY' );
end;
$$



-- Remove une fonction --

drop function format_date(date, separator VARCHAR);

-- Fonction Exemple --

select format_date('11-01-2205', '/'); 

-- Fonction Affichage de date avec un separateur / --

select format_date(o.date, '/') from "order" o ;
select format_date(o.date, '-') from "order" o ;


-- Fonction get items count --

CREATE OR REPLACE FUNCTION get_items_count()
RETURNS integer
LANGUAGE plpgsql
AS $$
declare
items_count integer;
time_now time = now();
begin
select count(id)
into items_count
from item;
raise notice '% articles à %', items_count, time_now;
return items_count;
END;
$$

select get_items_count() from item ;

-- Fonction count items to order -- 

create or replace function count_items_to_order()
returns integer
language plpgsql
as $$
declare 
stock_item integer;
begin
	select count(id)
	into stock_item
	from item 
	where stock_alert > stock ;
raise notice '% en rupture de stock', stock_item;
return stock_item ;
end;
$$

select count_items_to_order() as "Item en rupture de stock" ;


create or replace function best_supplier()
returns integer
language plpgsql
as $$
declare 
best_supplier integer;
begin
	select s.id, count(o.supplier_id)
	into best_supplier
	from supplier s
	join "order" o on s.id = o.supplier_id 
group by s.id, supplier_id
having count(o.supplier_id) > all (count(o.supplier_id)) ;
return best_supplier ;
end;
$$


select best_supplier() as "Meilleur Fournisseur" ;



