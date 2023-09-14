create table equipe (
	id 		SERIAL primary KEY, 
	code_equipe 		INT,
	nom 	VARCHAR(50),
	capacity 		INT,
	date_de_creation		DATE, 
);

create table joueur(
	id		SERIAL primary key,
	immatriculation		INT,
	nom		VARCHAR(50),
	prenom		VARCHAR(50),
	date_de_naissance		DATE,
	foreign key (equipe_id) references equipe(id)
	)
	
create table "match"(
	id 		SERIAL primary key,
	"date"		DATE,
	heure_debut		TIME,
	score		INT,
	foreign key (matcheq_id) references equipe(id)
)

create table arbitre(
	id		SERIAL primary key,
	nom		VARCHAR(50),
	prenom		VARCHAR(50),
	foreign key (match_id) references "match"(id)
)