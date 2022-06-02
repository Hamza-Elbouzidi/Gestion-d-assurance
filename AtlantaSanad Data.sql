create Database AtlantaSanad
Use AtlantaSanad

--Table Connexion
Create table Connexion(
 Login Varchar (15),
 Password varchar (15),
 Nom_Admin varchar(20),
 Admin_Ref varchar (20) primary key,
 )
 insert into Connexion values ('Admin1','123456','hamza elbouzidi','ar1')

  Select* from Connexion

  --Table Client--
  Create table Client(
  Code int primary Key ,
  Nom varchar(40) not null,
  Cin varchar(8) not null unique ,
  N_Patante int not null unique ,
  N_Rc int not null unique ,
  Adresse varchar(50) not null,
  Télephone int not null unique,
  Activité varchar (20) not null,
  N_Cnss varchar(20),
  Email varchar(30) not null,CONSTRAINT chk_Email CHECK (Email  LIKE '_%@__%.__%'),
  Qualité varchar (30) not null,
  Profession varchar (30) not null,
  )

  insert into Client values ('1','Hamza Elbouzidi','HH246780','470215','5647855','Avenue Far Immeuble Manal 7 App 22','0642873734','E-commerce','','elbouzidihamza5@gmail.com','Rigueur','Etudiant')
  insert into Client values ('2','Amine Chaouch','HH256987','125689','589685','Avenue Hassan 2 Immeuble Houda app 38','0642879596','Drop Shipping ','CS56589','Amine_Chaouch56@gmail.com','Empathie','Responsable financier')
  
  select*from Client

--Table Vehicule --

  Create table Vehicule (
  N_immatriculation varchar (15) primary key,
  N_chassis Varchar (15),
  Marque varchar(15),
  Type_carrosserie varchar (30),
  Remorque Varchar(50),
  )

  insert into Vehicule values('40756','259859','Tucson','Cyclo','Zero')

  select * from Vehicule 
   Drop
--Table Conducteur--
  Create table Conducteur(
  N_Permis int primary key ,
  Nom varchar (15),
  Prenom varchar (20),
  D_Naissance date,
  Lieu_Naissance varchar(20),
  Ville_Delivre varchar (20),
  Cin_Client varchar(8),
  )

 insert into Conducteur values('08181796','Hamza','Elbouzidi','29-11-2001','Safi','Safi','HH246780')

 select * from Conducteur

 select Code c , Nom c,Cin c from Client c 

