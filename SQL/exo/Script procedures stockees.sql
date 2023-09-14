-- Creation d'une fonction pour changer la date en chaine de caractere --

create function format_date(date date, separator VARCHAR)
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

