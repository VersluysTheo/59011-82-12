select
	*
from
	client
where
	password = encode(digest('test11',
	'sha1'),
	'hex')
	and first_name = 'Muriel';

select
	ol.last_name ,
	count(co.reference)
from
	customer_order co
join order_line ol on
	co.id = ol.order_id
group by
	ol.last_name
having
	count(co.reference) > 1;

update order_line set total_price = quantity * unit_price ;

select
	ol.total_price,
	co.purchase_date,
	c.first_name,
	c.last_name
from
	client c
join customer_order co on
	c.id = co.client_id
join order_line ol on
	co.client_id = ol.order_id ; 

select
	extract(month from co.purchase_date) as "MOIS",
	sum(ol.total_price) as "Somme du Mois"
from
	client c
join customer_order co on
	c.id = co.client_id
join order_line ol on
	co.client_id = ol.order_id
group by
	"MOIS" ;

select
	c.first_name,
	c.last_name,
	sum(ol.total_price) as "Montant de commandes"
from
	client c
join customer_order co on
	c.id = co.client_id
join order_line ol on
	co.id = ol.order_id 
group by 
	c.last_name,
	c.first_name
order by "Montant de commandes" desc
limit 10 ;

select
	c.first_name,
	c.last_name,
	sum(ol.total_price) as "Montant de commandes"
from
	client c
join customer_order co on
	c.id = co.client_id
join order_line ol on
	co.id = ol.order_id 
group by 
	c.last_name,
	c.first_name
order by "Montant de commandes" desc ;

select 
	extract(day from co.purchase_date) as "Date",
	extract(month from co.purchase_date) as "Mois",
	sum(ol.total_price) as "Somme de la journée"
from 
	client c
join customer_order co on
	c.id = co.client_id 
join order_line ol on
	co.id = ol.order_id
group by 
	"Date",
	"Mois" 
order by "Mois" ;


alter table order_line
add column categorie_commande int4 ;

update order_line set categorie_commande = case 
	when total_price < 200 then 1
	when total_price >= 200 and total_price < 500 then 2
	when total_price >= 500 and total_price < 1000 then 3
	when total_price >= 1000 then 4
	else 0
end ;

