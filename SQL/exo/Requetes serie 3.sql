select
	*
from
	client
where
	password = encode(digest('test11',
	'sha1'),
	'hex')
	and first_name = 'Muriel';

select ol.last_name , count(co.reference) from customer_order co join order_line ol on co.id = ol.order_id group by ol.last_name having count(co.reference) > 1;
