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
where so.delivery_time < 15 
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
	o.*
from "order" o 
join order_line ol on
	o.id = ol.order_id 
where ol.delivered_quantity is NULL;