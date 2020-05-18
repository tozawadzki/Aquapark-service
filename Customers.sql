--------------------------------------------------------
--  File created - poniedzia�ek-maja-18-2020   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table CUSTOMERS
--------------------------------------------------------

  CREATE TABLE "AQUAPARK"."CUSTOMERS" 
   (	"ID" NUMBER, 
	"FIRSTNAME" VARCHAR2(50 BYTE), 
	"LASTNAME" VARCHAR2(50 BYTE), 
	"DISCOUNTID" NUMBER
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into AQUAPARK.CUSTOMERS
SET DEFINE OFF;
Insert into AQUAPARK.CUSTOMERS (ID,FIRSTNAME,LASTNAME,DISCOUNTID) values ('1','Jakub','Zato�','1');
Insert into AQUAPARK.CUSTOMERS (ID,FIRSTNAME,LASTNAME,DISCOUNTID) values ('2','Tomasz','Zawadzki','1');
Insert into AQUAPARK.CUSTOMERS (ID,FIRSTNAME,LASTNAME,DISCOUNTID) values ('3','Michal','Kaminski','2');
Insert into AQUAPARK.CUSTOMERS (ID,FIRSTNAME,LASTNAME,DISCOUNTID) values ('4','Janek','Dziecinny','3');
--------------------------------------------------------
--  DDL for Index CUSTOMERS_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "AQUAPARK"."CUSTOMERS_PK" ON "AQUAPARK"."CUSTOMERS" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  Constraints for Table CUSTOMERS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CUSTOMERS" MODIFY ("ID" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."CUSTOMERS" MODIFY ("FIRSTNAME" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."CUSTOMERS" MODIFY ("LASTNAME" NOT NULL ENABLE);
  ALTER TABLE "AQUAPARK"."CUSTOMERS" ADD CONSTRAINT "CUSTOMERS_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table CUSTOMERS
--------------------------------------------------------

  ALTER TABLE "AQUAPARK"."CUSTOMERS" ADD CONSTRAINT "DISCOUNTID" FOREIGN KEY ("DISCOUNTID")
	  REFERENCES "AQUAPARK"."DISCOUNTS" ("ID") ENABLE;
