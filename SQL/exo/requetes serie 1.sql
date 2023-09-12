3.1) 

1 - select * from department ;

2 - select last_name, hiring_date ,superior_id , department_id , salary from employee ; 

3.2)

3 - select title from employee ;

4 - select distinct title from employee ;

3.3)

5 - select * from employee where salary > 25000 ;

6 - select last_name , id , department_id from employee where title ='secrétaire' ;

7 - select name, id from department where id > 40;

3.4)

8 - select first_name , last_name  from employee where first_name < last_name ;

9 - select last_name , salary , department_id from employee where title = 'représentant' and department_id = 35 and salary > 20000 ;

10 - select last_name , title , salary from employee where title ='président' ;

11 - select last_name, title , department_id, salary from employee where department_id = 34 and title ='secrétaire' or department_id = 34 and title ='représentant' ;

12 - select last_name, title , department_id, salary from employee where department_id = 34 and title ='secrétaire' or title ='représentant' ;

13 - select last_name, salary from employee where salary >= 20000 and salary <= 30000 ;

3.5)

14 - select last_name from employee where last_name like 'h%' ;

15 - select last_name from employee where last_name like '%n' ;

16 - select last_name from employee where last_name like  '__u%' ;

3.6)

17 - select salary, last_name from employee where department_id = 41 order by salary asc ;

18 - select salary, last_name from employee where department_id = 41 order by salary desc ;

19 - select title, salary , last_name from employee order by title asc, salary desc ;

3.7)

20 - select commission_rate, salary, last_name from employee order by commission_rate asc ;

21 - select last_name, salary, commission_rate, title from employee where commission_rate is NULL ;

22 - select last_name, salary, commission_rate, title from employee where commission_rate is not NULL ;

23 - select last_name, salary, commission_rate, title from employee where commission_rate < 15 ;

24 - select last_name, salary, commission_rate, title from employee where commission_rate > 15 ;

3.8) 

25 - select last_name, salary, commission_rate, commission_rate * salary as "commission employee" from employee where commission_rate is not null  ;

26 - select last_name, salary, commission_rate, commission_rate * salary as "commission employee" from employee where commission_rate is not null order by commission_rate asc ;

3.9)

27 -  select concat(first_name, ' ', last_name) as "Nom et Prenom" from employee;

3.10)

28 - select substring(last_name, 1 , 5) from employee; 

29 - select last_name,  position('r' in last_name) as "rank" from employee ;

30 - select last_name, upper(last_name), lower(last_name) from employee where last_name ='vrante' ;

31 - select last_name, length(last_name) as "Nombre de caractères" from employee ;
