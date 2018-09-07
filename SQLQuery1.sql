
CREATE TABLE IT_CLIENT (
Num_cli INTEGER PRIMARY KEY  IDENTITY ,
nom VARCHAR(20),
prenom VARCHAR(20),
Address VARCHAR(50),
ville VARCHAR(30),
CONSTRAINT pr_nom_prenom UNIQUE (nom,prenom),


);

INSERT INTO dbo.IT_CLIENT
(
    nom,
    prenom,
    Address,
    ville
)
VALUES
(   'Pattre', -- nom - varchar(20)
    'Brod', -- prenom - varchar(20)
    '14, avenue du Parc', -- Address - varchar(50)
    'LaMuque'  -- ville - varchar(30)
    )

	INSERT INTO dbo.IT_CLIENT
(
    nom,
    prenom,
    Address,
    ville
)
VALUES
(   'Juna', -- nom - varchar(20)
    'Mina', -- prenom - varchar(20)
    '554, Blvd des reveurs,', -- Address - varchar(50)
    'Bartue sur le Lac'  -- ville - varchar(30)
    )

		INSERT INTO dbo.IT_CLIENT
(
    nom,
    prenom,
    Address,
    ville
)
VALUES
(   'Icano', -- nom - varchar(20)
    'Sal', -- prenom - varchar(20)
    '4555, Chemin du Lac', -- Address - varchar(50)
    'LaMuque'  -- ville - varchar(30)
    )