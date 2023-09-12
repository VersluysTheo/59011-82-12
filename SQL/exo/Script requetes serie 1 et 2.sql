-- Debut serie 1 --

select
	*
from
	department ;

select
	*
from
	employee ;

select
	first_name,
	hiring_date ,
	superior_id ,
	department_id ,
	salary
from
	employee ;

select
	title
from
	employee ;

select
	distinct title
from
	employee ;

select
	*
from
	employee
where
	salary > 25000 ;

select
	first_name ,
	id ,
	department_id
from
	employee
where
	title = 'secrétaire' ;

select
	name,
	id
from
	department
where
	id > 40 ;

select
	first_name ,
	last_name
from
	employee
where
	first_name < last_name ;

select
	first_name ,
	salary ,
	department_id
from
	employee
where
	title = 'représentant'
	and department_id = 35
	and salary > 20000 ;

select
	first_name ,
	title ,
	salary
from
	employee
where
	title = 'président' ;

select
	first_name,
	title ,
	department_id,
	salary
from
	employee
where
	department_id = 34
	and title = 'secrétaire'
	or department_id = 34
	and title = 'représentant' ;

select
	first_name,
	title ,
	department_id,
	salary
from
	employee
where
	department_id = 34
	and title = 'secrétaire'
	or title = 'représentant' ;

select
	first_name,
	salary
from
	employee
where
	salary >= 20000
	and salary <= 30000 ;

select
	last_name
from
	employee
where
	last_name like 'h%' ;

select
	last_name
from
	employee
where
	last_name like '%n' ;

select
	last_name
from
	employee
where
	last_name like '__u%' ;

select
	salary,
	last_name
from
	employee
where
	department_id = 41
order by
	salary asc ;

select
	salary,
	last_name
from
	employee
where
	department_id = 41
order by
	salary desc ;

select
	title,
	salary ,
	last_name
from
	employee
order by
	title asc,
	salary desc ;

select
	commission_rate,
	salary,
	last_name
from
	employee
order by
	commission_rate asc ;

select
	last_name,
	salary,
	commission_rate,
	title
from
	employee
where
	commission_rate is null ;

select
	last_name,
	salary,
	commission_rate,
	title
from
	employee
where
	commission_rate is not null ;

select
	last_name,
	salary,
	commission_rate,
	title
from
	employee
where
	commission_rate < 15 ;

select
	last_name,
	salary,
	commission_rate,
	title
from
	employee
where
	commission_rate > 15 ;

select
	last_name,
	salary,
	commission_rate,
	commission_rate * salary as "commission employee"
from
	employee
where
	commission_rate is not null ;

select
	last_name,
	salary,
	commission_rate,
	commission_rate * salary as "commission employee"
from
	employee
where
	commission_rate is not null
order by
	commission_rate asc ;

select
	concat(first_name,
	' ',
	last_name) as "Nom et Prenom"
from
	employee;

select
	substring(last_name,
	1 ,
	5)
from
	employee;

select
	last_name,
	position('r' in last_name) as "rank"
from
	employee ;

select
	last_name,
	upper(last_name),
	lower(last_name)
from
	employee
where
	last_name = 'vrante' ;

select
	last_name,
	length(last_name) as "Nombre de caractères"
from
	employee ;

-- Debut Serie 2 --


select
	*
from
	employee e
join department d on
	e.department_id = d.id ;


select
	department_id,
	d.name as "nom du departement",
	last_name
from
	employee e
join department d on
	e.department_id = d.id ;


select
	last_name
from
	employee e
join department d on
	e.department_id = d.id ;


select
	e.last_name,
	e.salary,
	e2.last_name,
	e2.salary
from
	employee e
join employee e2 on
	e.id = e2.superior_id
where
	e.salary < e2.salary ;
 

select
	last_name
from
	employee
where
	department_id in (
	select
		id
	from
		department
	where
		name like 'finance' );
	
select
	last_name,
	title
from
	employee
where
	title in(
	select
		title
	from
		employee
	where
		last_name like 'amartakaldire');

select
	last_name,
	salary,
	department_id
from
	employee
where
	salary > any(
	select
		salary
	from
		employee
	where
		department_id = 31 );

select
	last_name,
	salary,
	department_id
from
	employee
where
	salary > all(
	select
		salary
	from
		employee
	where
		department_id = 31 );

select
	last_name,
	title
from
	employee
where
	department_id = 31
	and title in(
	select
		title
	from
		employee
	where
		department_id = 32);

select
	last_name,
	title
from
	employee
where
	department_id = 31
	and title not in(
	select
		title
	from
		employee
	where
		department_id = 32);

select
	last_name,
	title,
	salary
from
	employee
where
	salary in(
	select
		salary
	from
		employee
	where
		last_name like 'fairent')
	and title in(
	select
		title
	from
		employee
	where
		last_name like 'fairent') ;

select
	department_id,
	name,
	last_name
from
	employee e
left join department d on
	e.department_id = d.id
order by
	department_id asc ;

select
	avg(salary) as "salaire moyen des secretaires"
from
	employee
where
	title like 'secrétaire' ;

select
	title ,
	count(last_name) as "effectif"
from
	employee
group by
	title ;

select
	department_id,
	avg(salary) as "Salaire Moyen",
	sum(salary) as "Somme des salaires"
from
	employee
group by
	department_id ;

select
	department_id
from
	employee
group by
	department_id
having
	count(last_name) >= 3 ;

select
	substring(last_name ,
	1 ,
	1) as "Initial",
	count(*)
from
	employee
group by
	"Initial"
having
	count(*) >= 3;

select
	max(salary) as "Salaire Maximum",
	min(salary) as "Salaire Minimum",
	max(salary)-min(salary) as "Etendue"
from
	employee ;

select
	count(distinct title)
from
	employee ;

select
	title,
	count(title) as "Effectif"
from
	employee
group by
	title ;

select
	name,
	count(*) as "Effectif"
from
	employee e
right join department d on
	e.department_id = d.id
group by
	name ;

select
	title,
	avg(salary) as "Moyenne_de_salaire"
from
	employee
group by
	title
having
	avg(salary) > (
	select
		avg(salary)
	from
		employee
	where
		title like 'représentant') ;

select
	title,
	avg(salary) as "Moyenne_de_salaire"
from
	employee
group by
	title
having
	avg(salary) > (
	select
		avg(salary)
	from
		employee
	where
		title like 'représentant') ;


select
	commission_rate as "Taux de commission",
	count(commission_rate) as "Taux de commission renseignés",
	count(salary) as "Nombre de salaires renseignés"
from
	employee
group by
	commission_rate ;







