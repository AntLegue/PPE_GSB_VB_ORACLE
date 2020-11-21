-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (6/11/2020 11:29:26)
-- -----------------------------------------------------------------------------
--      Nom de la base : GSB
--      Projet : 
--      Auteur : ESTRAN
--      Date de dernière modification : 6/11/2020 11:29:11
-- -----------------------------------------------------------------------------

DROP TABLE SECTEUR CASCADE CONSTRAINTS;

DROP TABLE VISITEUR CASCADE CONSTRAINTS;

DROP TABLE MEDICAMENT CASCADE CONSTRAINTS;

DROP TABLE RESPONSABLE_SECTEUR CASCADE CONSTRAINTS;

DROP TABLE MEDECIN CASCADE CONSTRAINTS;

DROP TABLE DELEGUE_REGIONAL CASCADE CONSTRAINTS;

DROP TABLE COMPTE_RENDU CASCADE CONSTRAINTS;

DROP TABLE REGION CASCADE CONSTRAINTS;

DROP TABLE QUANTITE_MEDICAMENT CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       TABLE : SECTEUR
-- -----------------------------------------------------------------------------

CREATE TABLE SECTEUR
   (
    ID_SEC NUMBER(2)  NOT NULL,
    ID_REG NUMBER(2)  NOT NULL,
    LIB_SEC VARCHAR2(32)  NULL
,   CONSTRAINT PK_SECTEUR PRIMARY KEY (ID_SEC)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : VISITEUR
-- -----------------------------------------------------------------------------

CREATE TABLE VISITEUR
   (
    ID_VIS NUMBER(2)  NOT NULL,
    ID_REG NUMBER(2)  NOT NULL,
    NOM_VIS VARCHAR2(32)  NULL,
    PRENOM_VIS VARCHAR2(32)  NULL,
    ADRESSE_VIS VARCHAR2(32)  NULL,
    CP_VIS VARCHAR2(32)  NULL,
    VILLE_VIS VARCHAR2(32)  NULL
,   CONSTRAINT PK_VISITEUR PRIMARY KEY (ID_VIS)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : MEDICAMENT
-- -----------------------------------------------------------------------------

CREATE TABLE MEDICAMENT
   (
    ID_MEDIC NUMBER(2)  NOT NULL,
    LIB_MEDIC VARCHAR2(32)  NULL,
    TYPE_MEDIC VARCHAR2(32)  NULL,
    MODE_ADMIN_MEDIC VARCHAR2(32)  NULL
,   CONSTRAINT PK_MEDICAMENT PRIMARY KEY (ID_MEDIC)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : RESPONSABLE_SECTEUR
-- -----------------------------------------------------------------------------

CREATE TABLE RESPONSABLE_SECTEUR
   (
    ID_RS NUMBER(2)  NOT NULL,
    ID_SEC NUMBER(2)  NOT NULL,
    NOM_RS VARCHAR2(32)  NULL,
    PRENOM_RS VARCHAR2(32)  NULL,
    ADRESSE_RS VARCHAR2(32)  NULL,
    CP_RS VARCHAR2(32)  NULL,
    VILLE_RS VARCHAR2(32)  NULL
,   CONSTRAINT PK_RESPONSABLE_SECTEUR PRIMARY KEY (ID_RS)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : MEDECIN
-- -----------------------------------------------------------------------------

CREATE TABLE MEDECIN
   (
    ID_MED NUMBER(2)  NOT NULL,
    NOM_MED VARCHAR2(32)  NULL,
    PRENOM_MED VARCHAR2(32)  NULL,
    ADRESSE_MED VARCHAR2(32)  NULL,
    CP_MED VARCHAR2(32)  NULL,
    VILLE_MED VARCHAR2(32)  NULL
,   CONSTRAINT PK_MEDECIN PRIMARY KEY (ID_MED)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : DELEGUE_REGIONAL
-- -----------------------------------------------------------------------------

CREATE TABLE DELEGUE_REGIONAL
   (
    ID_DR NUMBER(2)  NOT NULL,
    ID_REG NUMBER(2)  NOT NULL,
    NOM_DR VARCHAR2(32)  NULL,
    PRENOM_DR VARCHAR2(32)  NULL,
    ADRESSE_DR VARCHAR2(32)  NULL,
    CP_DR VARCHAR2(32)  NULL,
    VILLE_DR VARCHAR2(32)  NULL
,   CONSTRAINT PK_DELEGUE_REGIONAL PRIMARY KEY (ID_DR)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : COMPTE_RENDU
-- -----------------------------------------------------------------------------

CREATE TABLE COMPTE_RENDU
   (
    ID_CR NUMBER(2)  NOT NULL,
    ID_MED NUMBER(2)  NOT NULL,
    ID_VIS NUMBER(2)  NOT NULL,
    NUM_CR VARCHAR2(32)  NULL,
    DATE_CR VARCHAR2(32)  NULL,
    ETAT_CR VARCHAR2(32)  NULL,
    MOTIF_CR VARCHAR2(32)  NULL
,   CONSTRAINT PK_COMPTE_RENDU PRIMARY KEY (ID_CR)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : REGION
-- -----------------------------------------------------------------------------

CREATE TABLE REGION
   (
    ID_REG NUMBER(2)  NOT NULL,
    LIB_REG VARCHAR2(32)  NULL
,   CONSTRAINT PK_REGION PRIMARY KEY (ID_REG)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : QUANTITE_MEDICAMENT
-- -----------------------------------------------------------------------------

CREATE TABLE QUANTITE_MEDICAMENT
   (
    ID_CR NUMBER(2)  NOT NULL,
    ID_MEDIC NUMBER(2)  NOT NULL,
    QTE_MEDIC VARCHAR2(128)  NULL
,   CONSTRAINT PK_QUANTITE_MEDICAMENT PRIMARY KEY (ID_CR, ID_MEDIC)  
   ) ;

-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE VISITEUR ADD (
     CONSTRAINT FK_VISITEUR_REGION
          FOREIGN KEY (ID_REG)
               REFERENCES REGION (ID_REG))   ;



ALTER TABLE DELEGUE_REGIONAL ADD (
     CONSTRAINT FK_DELEGUE_REGIONAL_REGION
          FOREIGN KEY (ID_REG)
               REFERENCES REGION (ID_REG))   ;

ALTER TABLE COMPTE_RENDU ADD (
     CONSTRAINT FK_COMPTE_RENDU_MEDECIN
          FOREIGN KEY (ID_MED)
               REFERENCES MEDECIN (ID_MED))   ;

ALTER TABLE COMPTE_RENDU ADD (
     CONSTRAINT FK_COMPTE_RENDU_VISITEUR
          FOREIGN KEY (ID_VIS)
               REFERENCES VISITEUR (ID_VIS))   ;

ALTER TABLE SECTEUR ADD (
     CONSTRAINT FK_SECTEUR_REGION
          FOREIGN KEY (ID_REG)
               REFERENCES REGION (ID_REG))   ;

ALTER TABLE QUANTITE_MEDICAMENT ADD (
     CONSTRAINT FK_QUANTITE_MEDICAMENT_COMPTE_
          FOREIGN KEY (ID_CR)
               REFERENCES COMPTE_RENDU (ID_CR))   ;

ALTER TABLE QUANTITE_MEDICAMENT ADD (
     CONSTRAINT FK_QUANTITE_MEDICAMENT_MEDICAM
          FOREIGN KEY (ID_MEDIC)
               REFERENCES MEDICAMENT (ID_MEDIC))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------