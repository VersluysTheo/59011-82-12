-- Quadruples inner join pour avoir toute les valeurs --

select 
	* 
from "order" o 
join order_line ol on 
	o.id = ol.order_id 
join item i on
	ol.item_id = i.id 
join sale_offer so on 
	i.id = so.item_id
join supplier s on 
	so.supplier_id = s.id ;
	
select
	s.*
from supplier s 
join sale_offer so on
	s.id = so.supplier_id 
where so.delivery_time <= 15 
group by s.id ;


select 
	s.*,
	count(so.supplier_id) as "Nombre item"
	from supplier s 
join sale_offer so on
	s.id = so.supplier_id 
group by s.id, so.supplier_id 
having count(so.supplier_id) > 2 
order by so.supplier_id asc ;

select 
	*
from "order" o  
join order_line ol on
	o.id = ol.order_id 
where ol.delivered_quantity is NULL;


select 
	i.*,
	s.*
from item i 
join sale_offer so on
	i.id = so.item_id 
join supplier s on
	so.supplier_id = s.id 
group by i.id,s.id 
having s."name" like 'DICOBOL';

select
	ol.*
from "order" o  
join order_line ol on
	o.id = ol.order_id 
where o.date > '2021-01-10' and o.date < '2021-01-20' ; 

select
	o.*,
	count(o.supplier_id) as "Nombre item"
from "order" o  
join order_line ol on
	o.id = ol.order_id
join item i on 
	ol.item_id = i.id 
group by o.id, o.supplier_id 
having count(o.supplier_id) > 2 ;


select
	o.*,
	so.delivery_time 
from supplier s 
join sale_offer so on
	s.id = so.supplier_id 
join "order" o on 
	s.id = o.supplier_id 
where so.delivery_time < 15 
group by o.id, so.delivery_time ;

select
	o.*,
	ol.*
from item i 
join order_line ol on
	i.id = ol.item_id
join "order" o on
	ol.order_id = o.id 
where stock < stock_alert ;

select 
	s.*
from supplier s 
join "order" o on
	s.id = o.supplier_id 
join order_line ol on
	o.id = ol.order_id
where ol.unit_price * ol.delivered_quantity > 10000000 ;