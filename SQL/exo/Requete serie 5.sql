select 
	name, city
from hotel ;

select 
	first_name, last_name, address
from client 
where last_name like 'White';

select 
	*
from station 
where altitude < 1000;

select 
	number,capacity 
from room r 
where capacity > 1 ;

select 
	last_name,
	city 
from client c 
where city not like 'Londres' ;

select
	name, city, category
from hotel h 
where city like 'Bretou' and category > 3 ;
