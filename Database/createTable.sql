-- isufiyanov."SibintekFile" definition

-- Drop table

-- DROP TABLE isufiyanov."SibintekFile";

CREATE TABLE isufiyanov."SibintekFile" (
	"name" varchar(40) NOT NULL,
	id int4 NOT NULL,
	parentid int4 NULL,
	"path" varchar(150) NULL,
	"type" int4 NULL,
	CONSTRAINT sibintekfile_pk PRIMARY KEY (id),
	CONSTRAINT sibintekfile_fk FOREIGN KEY (parentid) REFERENCES isufiyanov."SibintekFile"(id)
);